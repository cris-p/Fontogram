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
    /// Interaction logic for Fontogram.xaml
    /// </summary>
    public partial class Fontogram : UserControl
    {
        public Fontogram()
        {
            InitializeComponent();

            DataContext = this;

            FontSizeRel = 97;

            this.SizeChanged += Fontogram_SizeChanged;
        }


        private void Fontogram_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateFontSize(e.NewSize.Height);
        }


        private void UpdateFontSize(double controlHeight)
        {
            if (controlHeight > 0)
                this.TestLabel.FontSize = controlHeight * this.FontSizeRel / 100;
        }

        private int _fontSizeRel = 80;
        public int FontSizeRel
        {
            get { return _fontSizeRel; }
            set
            {
                _fontSizeRel = value;

                UpdateFontSize(this.ActualHeight);
            }
        }

    }
}
