using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;


namespace PergleLabs.UI
{

    /// <summary>
    /// Properties to be used in XAML
    /// </summary>
    /// 
    /// <remarks>
    /// This interface is shared between Fontogram and FgLayer - important for 'SetPropertyValuesInLayers' (the 'string' type also helps).
    /// 
    /// Values are '|'-separated - one for each layer.
    /// 
    /// All size-like values are in percentages relative to the *height* of the Fontogram. Left and Right margins
    /// are considered relative to a square whose top and bottom edges coincide with that of the Fontogram, centered
    /// within Fontogram's actual horizontal span.
    /// 
    /// Font size is inferred from TextMarginRel.
    /// 
    /// Most characters of regular (non-icon) fonts don't fill the full text height; in these cases,
    /// the symbol(s) will not extend to the specified top and bottom margins. The remedy is to specify margins
    /// that are outside of the symbol's actual desired margins (values to be determined by experiment).
    /// In addition, the left and right margins will not cause the symbol to be stretched horizontally -
    /// instead, it will just be centered between the specified margins.
    /// 
    /// Transforms apply to each layer (backdrop + text) as a whole.
    /// </remarks>
    public interface FontogramProperties
    {

        //string AspectRatio // "3:4"

        //// e.g. "Segoe UI Emoji", "Arial", "Monospace", "Wingdings 3"
        //// default "Segoe MDL2 Assets"
        //string TextFont { set; }

        //// e.g. "Bold"
        //// default "Normal"
        //string TextFontWeight { set; }

        //// e.g. "#f00" (red), "#880088FF" (half transparent greenish blue)
        //// default "Black"
        //string TextColor { set; }

        //// e.g. "25,25,25,25" (centered half-size square), "0,-60,-60,0" (left-bottom aligned square; symbol cropped at top, and possibly at right, depending on actual width)
        //// default "0,0,0,0"
        //string TextMarginRel { set; }

        //// e.g. "25" (a quarter of the height from the bottom)
        //// default "0"
        //// It's the font's baseline. Some characters may extend below the baseline -
        //// quite common for emojis. Find the right value by experiment.
        //string TextYRel { set; }

        ////
        ////
        //// This is relative to the left boundary of a square aligned with the top and bottom
        //// of the control, centered horizontally relative to the control. Characters' left side
        //// boundaries are in general not perfectly aligned with this value. So experiment.
        //string TextXRel { set; }


        //// e.g. "50" (half of the control's height)
        //// default "100"
        //// It's the height of the font. Different characters may or may not fill this specified height.
        //string TextHeightRel { set; }


        // e.g. "?", "Abc", "!"
        // default "" (no text)
        string Text { set; }

        // e.g. "Arial,bold,#f00"; "Segoe UI Emoji,,"
        // FontFamily,FontWeight,Color
        string TextAttr { set; }

        // e.g. "-10,10,60"
        // default "0,0,100"
        // FontSizeRel,xShiftRel,yShiftRel
        string TextPosRel { set; }

        string TextTransform { set; }


        // Transforms are: RotAngle, ScaleX, ScaleY, SkewAngleX, SkewAngleY; ... ; ...
        // relative to center of text or backdrop

        // Opacity,FillColor,StrokeThicknessRel,StrokeColor
        string BackAttr { set; }

        // (wRel, hRel, shiftXRel, shiftYRel)
        string BackPosRel { set; }

        // e.g. "50,50,0,0" (half disk)
        // default "10,10,10,10" (slightly rounded corners)
        string BackCornerRadiusRel { set; }

        string BackTransform { set; }


        //// e.g. "0.5"
        //// default "1"
        //string BackOpacity { set; }

        //// e.g. "#f00" (red), "#880088FF" (half transparent greenish blue)
        //// default "Transparent" (no backdrop)
        //string BackFillColor { set; }

        //// e.g. "10" (10% of Fontogram height)
        //// default "0" (no border)
        //string BackStrokeThicknessRel { set; }

        //// e.g. "#f00" (red), "#880088FF" (half transparent greenish blue)
        //// default "Black"
        //string BackStrokeColor { set; }

        ////// e.g. "25,25,25,25" (centered half-size square), "0,-60,-60,0" (left-bottom aligned square; symbol cropped at top, and possibly at right, depending on actual width)
        ////// default "0,0,0,0"
        ////string BackMarginRel { set; }

        //// (wRel, hRel, shiftXRel, shiftYRel)
        //string BackPosRel { set; }

        //// e.g. "50,50,0,0" (half disk)
        //// default "10,10,10,10" (slightly rounded corners)
        //string BackCornerRadiusRel { set; }



        //string RotAngle { set; }

        //// like https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.skewtransform.anglexproperty
        //// center in the middle of the text
        //string SkewAngleX { set; }

        //// like https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.skewtransform.angleyproperty
        //// center in the middle
        //string SkewAngleY { set; }

    }


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


        private void SetPropertyValuesInLayers(string explicitAttrString, string readyMadeAttrString, [CallerMemberName] string propertyName = "")
        {
            if (string.IsNullOrWhiteSpace(explicitAttrString))
                explicitAttrString = "";
            if (string.IsNullOrWhiteSpace(readyMadeAttrString))
                readyMadeAttrString = "";


            PropertyInfo layerPropInfo = typeof(FgLayer).GetProperty(propertyName);

            string[] explicitValues = explicitAttrString.Split('|');
            string[] readyMadeValues = readyMadeAttrString.Split('|');

            int potentialLayerCount = Math.Max(explicitValues.Length, readyMadeValues.Length);

            for (int n = 0; n < potentialLayerCount; n++)
            {
                string explicitValue = explicitValues.Length > n ? explicitValues[n] : "";
                string readyMadeValue = readyMadeValues.Length > n ? readyMadeValues[n] : "";

                // explicit value takes priority
                string actualValue = string.IsNullOrWhiteSpace(explicitValue) ? readyMadeValue : explicitValue;

                FgLayer layer = GetOrCreateNthLayer(n);

                layerPropInfo.SetValue(layer, actualValue);
            }

            if (SelectiveLayerEnable != (int)SelectiveLayerEnableProperty.DefaultMetadata.DefaultValue)
                EnableLayerSelectively(SelectiveLayerEnable);
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

        private void ClearLayers()
        {
            _ParentGrid.Children.Clear();
        }


        #region The Properties

        // see FontogramBaseProps.cs, generated from FontogramBaseProps.tt

        #endregion


        protected readonly Dictionary<string, string> _ReadyMadeValues = new Dictionary<string, string>();

        protected readonly Dictionary<string, string> _EffectiveValues = new Dictionary<string, string>();


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
