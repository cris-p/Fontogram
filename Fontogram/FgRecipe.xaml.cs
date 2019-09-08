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

    public interface RecipeProperties
    {
        string FontSizeRel { set; }
    }


    /// <summary>
    /// Interaction logic for FgRecipe.xaml
    /// </summary>
    internal partial class FgRecipe
        : UserControl
        , RecipeProperties
    {

        public FgRecipe()
        {
            InitializeComponent();

            DataContext = _XamlProps;

            this.SizeChanged += FgFormula_SizeChanged;
        }


        private void FgFormula_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateFontSize(e.NewSize.Height);
        }


        private void UpdateFontSize(double controlHeight)
        {
            if (controlHeight > 0)
                _XamlProps.FontSize = controlHeight * _fontSizeVal / 100;
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



        private readonly XamlProps _XamlProps = new XamlProps();

    }

}
