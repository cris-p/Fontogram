using PergleLabs.UI;
using System;
using System.Collections.Generic;
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

    public static class DependencyObjectEx
    {

        public static _T FindAncestor<_T>(this DependencyObject dependencyObject)
            where _T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(dependencyObject);

            if (parent == null) return null;

            var typedParent = parent as _T;

            return typedParent ?? FindAncestor<_T>(parent);
        }

    }


    /// <summary>
    /// Interaction logic for LayerBoxFgItem.xaml
    /// </summary>
    public partial class LayerBoxFgItem
        : UserControl
        , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public static readonly DependencyProperty LayerEditorProperty = DependencyProperty.Register("LayerEditor", typeof(LayerEditor), typeof(LayerBoxFgItem)
            );
        public LayerEditor LayerEditor
        {
            get { return (LayerEditor)GetValue(LayerEditorProperty); }
            set { SetValue(LayerEditorProperty, value); }
        }


        private Brush _itemBrush = SystemColors.InactiveSelectionHighlightBrush;
        public Brush ItemBrush
        {
            get { return _itemBrush; }
            private set
            {
                _itemBrush = value;
                NotifyPropertyChanged();
            }
        }


        private bool _isShown = true;
        public bool IsShown
        {
            get { return _isShown; }
            set
            {
                _isShown = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("LabelColor");
            }
        }

        public string LabelColor => _isShown ? "Black" : "Red";


        public ListBoxItem ListBoxItem { get; private set; }


        public LayerBoxFgItem()
        {
            InitializeComponent();
        }

        protected override void OnVisualParentChanged(DependencyObject oldParent)
        {
            base.OnVisualParentChanged(oldParent);

            ListBoxItem = this.FindAncestor<ListBoxItem>();

            ListBoxItem.Selected += ListBoxItem_Selected;
            ListBoxItem.Unselected += ListBoxItem_Unselected;
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            ItemBrush = SystemColors.HighlightBrush;
        }

        private void ListBoxItem_Unselected(object sender, RoutedEventArgs e)
        {
            ItemBrush = SystemColors.InactiveSelectionHighlightBrush;
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            //_ListBoxItem.IsSelected = true;

            btnMoveDown.Visibility = Visibility.Visible;
            btnMoveUp.Visibility = Visibility.Visible;

            // Having some trouble with refreshing command's CanExecute - this is the workaround.
            btnMoveDown.IsEnabled = (DataContext as FgLayerItem).Position > 0;
            btnMoveUp.IsEnabled = (DataContext as FgLayerItem).Position < LayerEditor.LiveTopToBottomLayers.Count - 1;
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            btnMoveDown.Visibility = Visibility.Hidden;
            btnMoveUp.Visibility = Visibility.Hidden;
        }
    }

}
