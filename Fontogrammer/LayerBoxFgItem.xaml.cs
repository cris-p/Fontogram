using PergleLabs.UI;
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

namespace PergleLabs.Fontogrammer
{
    /// <summary>
    /// Interaction logic for LayerBoxFgItem.xaml
    /// </summary>
    public partial class LayerBoxFgItem
        : UserControl
    {

        public static readonly DependencyProperty LayerEditorProperty = DependencyProperty.Register("LayerEditor", typeof(LayerEditor), typeof(LayerBoxFgItem)
            );
        public LayerEditor LayerEditor
        {
            get { return (LayerEditor)GetValue(LayerEditorProperty); }
            set { SetValue(LayerEditorProperty, value); }
        }


        public LayerBoxFgItem()
        {
            InitializeComponent();
        }

    }
}
