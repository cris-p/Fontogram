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


    /// <summary>
    /// Interaction logic for FgRecipe.xaml
    /// </summary>
    internal partial class FgRecipe
        : UserControl
        , FontogramProperties   // flowing down from Fontogram
    {

        public FgRecipe()
        {
            InitializeComponent();

            DataContext = _BindingProps;

            this.SizeChanged += FgFormula_SizeChanged;
        }


        private void FgFormula_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateFontSize(e.NewSize.Height);
        }


        private void UpdateFontSize(double controlHeight)
        {
            if (controlHeight > 0)
                _BindingProps.SymbolFontSize = controlHeight * _fontSizeVal / 100;
        }


        private int _fontSizeVal = 20;
        public string FontSizeRel
        {
            set
            {
                try
                {
                    _fontSizeVal = int.Parse(value);

                    UpdateFontSize(this.ActualHeight);
                }
                catch { }
            }
        }

        #region Fontogram-specified Properties

        public string SymbolFont { set { } }
        public string SymbolFontWeight { set { } }
        public string SymbolColor { set { } }
        public string SymbolMarginRel { set { } }
        public string SymbolText { set { } }
        public string BackOpacity { set { } }
        public string BackFillColor { set { } }
        public string BackStrokeColor { set { } }
        public string BackMarginRel { set { } }
        public string BackStrokeThicknessRel { set { } }
        public string BackCornerRadiusRel { set { } }

        #endregion

        private readonly RecipeBindingProps _BindingProps = new RecipeBindingProps();

    }

}
