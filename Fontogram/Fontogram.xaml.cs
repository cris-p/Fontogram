using System.Windows;
using System.Windows.Controls;


namespace PergleLabs.UI
{

    /// <summary>
    /// Interaction logic for Fontogram.xaml
    /// </summary>
    public partial class Fontogram
        : UserControl
    {

        public Fontogram()
        {
            InitializeComponent();

            DataContext = _XamlProps;

            this.SizeChanged += Fontogram_SizeChanged;
        }


        private void Fontogram_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            UpdateFontSize(e.NewSize.Height);
        }


        private void UpdateFontSize(double controlHeight)
        {
            if (controlHeight > 0)
                _XamlProps.FontSize = controlHeight * _fontSizeRel / 100;
        }

        private int _fontSizeRel = 80;
        public int FontSizeRel
        {
            set
            {
                _fontSizeRel = value;

                UpdateFontSize(this.ActualHeight);
            }
        }


        private readonly XamlProps _XamlProps = new XamlProps();

    }

}
