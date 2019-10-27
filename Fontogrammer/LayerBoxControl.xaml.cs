using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    interface LayerEditor
    {

    }


    public abstract class LayerCommand
        : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);


        internal LayerCommand(LayerEditor layerEditor)
        {
            _LayerEditor = layerEditor;
        }

        private protected readonly LayerEditor _LayerEditor;
    }

    public abstract class SelectedLayerCommand
        : LayerCommand
    {
        private protected SelectedLayerCommand(LayerEditor layerEditor)
            : base(layerEditor)
        {
        }
    }

    public class RemoveLayerCommand
        : SelectedLayerCommand
    {

        internal RemoveLayerCommand(LayerEditor layerEditor)
            : base(layerEditor)
        {
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
        }
    }


    /// <summary>
    /// Interaction logic for LayerBoxControl.xaml
    /// </summary>
    public partial class LayerBox
        : ListBox
        , LayerEditor
    {

        private ObservableCollection<LayerBoxItem> _ReversedLayerItems;

        
        public RemoveLayerCommand _RemoveCommand { get; }


        public LayerBox()
        {
            InitializeComponent();

            _RemoveCommand = new RemoveLayerCommand(this);
        }

        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            base.OnItemsSourceChanged(oldValue, newValue);

            _ReversedLayerItems = (ObservableCollection<LayerBoxItem>)ItemsSource;
        }
    }
}
