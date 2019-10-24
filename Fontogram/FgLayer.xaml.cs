using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PergleLabs.UI
{

    internal partial class FgLayer
        : UserControl
    {

        public FgLayer()
        {
            InitializeComponent();

            DataContext = _BindingProps;

            this.SizeChanged += FgControl_SizeChanged;
        }


        private void FgControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            _BindingProps.OnControlSizeChanged(e.NewSize.Width, e.NewSize.Height);
        }


        private static void DispatchValues(string cslVals, params TranslatedProperty[] xProperties)
        {
            string[] partsIn = cslVals.Split(';').Select(part => part.Trim()).ToArray();

            for (int i = 0; i < xProperties.Length; i++)
                xProperties[i].In =
                    partsIn.Length <= i ? null : partsIn[i];            
        }

        private static string RevealValues(params TranslatedProperty[] xProperties)
        {
            return string.Join(";", xProperties.Select(xProp => xProp.In));
        }


        #region Fontogram-originated properties

        // see FgLayerProps.cs, generated from FgLayerProps.tt

        #endregion


        private readonly LayerBindingProps _BindingProps = new LayerBindingProps();

    }

}
