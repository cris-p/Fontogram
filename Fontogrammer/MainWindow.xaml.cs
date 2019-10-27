using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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


namespace PergleLabs.Fontogrammer
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
        : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWndDataContext(fgPreview, uiLayerBox);
        }

        private void GridSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // set square
            GridSplitter splitter = sender as GridSplitter;

            var rowDefs = _PreviewGrid.RowDefinitions;
            var colDefs = _PreviewGrid.ColumnDefinitions;

            var w0 = colDefs[0].ActualWidth;
            var w1 = colDefs[1].ActualWidth;
            var w2 = colDefs[2].ActualWidth;
            var h0 = rowDefs[0].ActualHeight;
            var h1 = rowDefs[1].ActualHeight;
            var h2 = rowDefs[2].ActualHeight;

            double W0 = w0, W1 = w1, W2 = w2, H0 = h0, H1 = h1, H2 = h2;

            const double Min = 5;

            if (splitter.VerticalAlignment == VerticalAlignment.Top)
            {
                H0 = h0 + h1 - w1;
                if (H0 < 0)
                    H0 = Min;
                H1 = h0 + h1 - H0;
            }
            else if (splitter.VerticalAlignment == VerticalAlignment.Bottom)
            {
                H2 = h2 + h1 - w1;
                if (H2 < 0)
                    H2 = Min;
                H1 = h2 + h1 - H2;
            }
            else if (splitter.HorizontalAlignment == HorizontalAlignment.Left)
            {
                W0 = w0 + w1 - h1;
                if (W0 < 0)
                    W0 = Min;
                W1 = w0 + w1 - W0;
            }
            else //(splitter.HorizontalAlignment == HorizontalAlignment.Right)
            {
                W2 = w2 + w1 - h1;
                if (W2 < 0)
                    W2 = Min;
                W1 = w2 + w1 - W2;
            }

            // using 'Pixel' would mess with the functioning of the Splitter - those sizes will not change.
            rowDefs[0].Height = new GridLength(H0, GridUnitType.Star);
            rowDefs[1].Height = new GridLength(H1, GridUnitType.Star);
            rowDefs[2].Height = new GridLength(H2, GridUnitType.Star);
            colDefs[0].Width = new GridLength(W0, GridUnitType.Star);
            colDefs[1].Width = new GridLength(W1, GridUnitType.Star);
            colDefs[2].Width = new GridLength(W2, GridUnitType.Star);
        }

    }

}
