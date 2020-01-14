using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Linq;


namespace PergleLabs.UI
{

    /// <summary>
    /// Interaction logic for Fontogram.xaml
    /// </summary>
    public partial class FontogramBase
        : UserControl
    {
        public Grid _ParentGrid;

        public FontogramBase()
        {
            _ParentGrid = new Grid();
            _ParentGrid.ClipToBounds = true;

            this.AddChild(_ParentGrid);
        }

        private static IEnumerable<string> ComputeEffectivePerLayerValues(string readyMadeAttrString, string explicitAttrString)
        {
            // Split the value into its component values - first at layer level, then within layer.
            // Any "explicit" value overrides any "ready-made" value. Whitespace or null string means missing value.

            if (string.IsNullOrWhiteSpace(readyMadeAttrString))
                readyMadeAttrString = "";
            if (string.IsNullOrWhiteSpace(explicitAttrString))
                explicitAttrString = "";

            string[] readyMadePerLayerValues = readyMadeAttrString.Split('|');
            string[] explicitPerLayerValues = explicitAttrString.Split('|');

            int potentialLayerCount = Math.Max(explicitPerLayerValues.Length, readyMadePerLayerValues.Length);

            for (int layer = 0; layer < potentialLayerCount; layer++)
            {
                string readyMadeLayerValue = readyMadePerLayerValues.Length > layer ? readyMadePerLayerValues[layer] : "";
                string explicitLayerValue = explicitPerLayerValues.Length > layer ? explicitPerLayerValues[layer] : "";

                string[] readyMadeIntraLayerValues = readyMadeLayerValue.Split(';');
                string[] explicitIntraLayerValues = explicitLayerValue.Split(';');

                int intraLayerCount = Math.Max(readyMadeIntraLayerValues.Length, explicitIntraLayerValues.Length);

                string[] effectiveIntraLayerValues = new string[intraLayerCount];

                for (int n = 0; n < intraLayerCount; n++)
                {
                    string readyMadeValue = readyMadeIntraLayerValues.Length > n ? readyMadeIntraLayerValues[n] : "";
                    string explicitValue = explicitIntraLayerValues.Length > n ? explicitIntraLayerValues[n] : "";


                    // explicit value takes priority
                    string effectiveValue = string.IsNullOrWhiteSpace(explicitValue) ? readyMadeValue : explicitValue;

                    effectiveIntraLayerValues[n] = effectiveValue;
                }

                yield return string.Join(";", effectiveIntraLayerValues);
            }

        }

        private void SetPropertyValuesInLayers(string explicitAttrString, string readyMadeAttrString, [CallerMemberName] string propertyName = "")
        {
            PropertyInfo layerPropInfo = typeof(FgLayer).GetProperty(propertyName);

            int layerNo = 0;
            foreach (var effectivePerLayerValue in ComputeEffectivePerLayerValues(readyMadeAttrString, explicitAttrString))
            {
                FgLayer layer = GetOrCreateNthLayer(layerNo);

                layerPropInfo.SetValue(layer, effectivePerLayerValue);

                layerNo++;
            }

            if (SelectiveLayerEnable != (int)SelectiveLayerEnableProperty.DefaultMetadata.DefaultValue)
                EnableLayerSelectively(SelectiveLayerEnable);
        }


        private string GetPropertyValuesFromLayers([CallerMemberName] string propertyName = "")
        {
            PropertyInfo layerPropInfo = typeof(FgLayer).GetProperty(propertyName);

            return string.Join("|", _ParentGrid.Children.Cast<UIElement>().Select(layer => layerPropInfo.GetValue(layer)));
        }


        // SelectiveLayerEnable
        public static readonly DependencyProperty SelectiveLayerEnableProperty = DependencyProperty.Register(
            "SelectiveLayerEnable", typeof(int), typeof(FontogramBase), new PropertyMetadata(-1, OnSelectiveLayerEnableChanged));
        private static void OnSelectiveLayerEnableChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs e)
        {
            (depObj as FontogramBase).EnableLayerSelectively((int)e.NewValue);
        }
        public int SelectiveLayerEnable
        {
            get { return (int)GetValue(SelectiveLayerEnableProperty); }
            set { SetValue(SelectiveLayerEnableProperty, value); }
        }

        private void EnableLayerSelectively(int layerPos)
        {
            for (int i = 0; i < _ParentGrid.Children.Count; i++)
            {
                FgLayer layer = _ParentGrid.Children[i] as FgLayer;

                layer.Visibility =
                    (layerPos == (int)SelectiveLayerEnableProperty.DefaultMetadata.DefaultValue
                        ? Visibility.Visible
                        : (layerPos == i
                            ? Visibility.Visible
                            : Visibility.Hidden
                            )
                        );
            }
        }


        public void ShowLayer(int layerPos, bool doShow)
        {
            if (layerPos < 0 && layerPos >= _ParentGrid.Children.Count)
                return;

            FgLayer layer = _ParentGrid.Children[layerPos] as FgLayer;
            layer.Visibility = doShow ? Visibility.Visible : Visibility.Hidden;
        }


        private void ClearLayers()
        {
            _ParentGrid.Children.Clear();
        }


        #region The Properties

        // see FontogramBaseProps.cs, generated from FontogramBaseProps.tt

        #endregion


        private FgLayer GetOrCreateNthLayer(int n)
        {
            if (n < _ParentGrid.Children.Count)
                return _ParentGrid.Children[n] as FgLayer;

            if (n > _ParentGrid.Children.Count)
                return null;


            // 'n' is 1 past the end of the current list -> add new layer

            FgLayer newLayer = new FgLayer();

            _ParentGrid.Children.Add(newLayer);

            return newLayer;
        }

        private FgLayer GetNthLayer(int n)
        {
            if (n < _ParentGrid.Children.Count)
                return _ParentGrid.Children[n] as FgLayer;

            return null;
        }

    }

}
