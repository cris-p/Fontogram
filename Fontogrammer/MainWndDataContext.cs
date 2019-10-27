using PergleLabs.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PergleLabs.Fontogrammer
{

    partial class MainWndDataContext
        : INotifyPropertyChanged
        , LayerObjectCreator
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private readonly Fontogram _FgPreview;
        public MainWndDataContext(Fontogram fgPreview, LayerEditor layerEditor)
        {
            _FgPreview = fgPreview;

            _LayerEditor = layerEditor;
            _LayerEditor.SetLayerCreator(this);
            _LayerEditor.LayersChanged += _LayerEditor_LayersChanged;


            _CodegenXaml = new CodegenXaml(fgPreview);

            _CodegenCsharp = new CodegenCsharp(fgPreview);


            foreach (var readyMadeID in (ReadyMadeFontogram[])Enum.GetValues(typeof(ReadyMadeFontogram)))
            {
                ReadyMadeFontogramChoices.Add(readyMadeID);
            }

            this.ReadyMadeFontogramSelection = 0;   // default is "none" - an item separate from ReadyMadeFontogramChoices
        }

        private void _LayerEditor_LayersChanged()
        {
            ReapplyProperties();
        }

        public List<ReadyMadeFontogram> ReadyMadeFontogramChoices { get; private set; } = new List<ReadyMadeFontogram>();


        private ReadyMadeFontogram? _readyMadeSelectedValue = null;
        public ReadyMadeFontogram? ReadyMadeSelectedValue
        {
            get { return _readyMadeSelectedValue; }
            private set
            {
                _readyMadeSelectedValue = value;

                NotifyPropertyChanged();
            }
        }


        int _readyMadeFontogramSelection = 0;
        public int ReadyMadeFontogramSelection
        {
            get { return _readyMadeFontogramSelection; }
            set
            {
                if (value > 0)
                    ReadyMadeSelectedValue = ReadyMadeFontogramChoices[value-1];
                else
                    ReadyMadeSelectedValue = null;

                UpdateGeneratedCode();

                _readyMadeFontogramSelection = value;
            }
        }


        private string _codeTextXaml = null;
        public string CodeTextXaml
        {
            get { return _codeTextXaml; }
            private set
            {
                _codeTextXaml = value;

                NotifyPropertyChanged();
            }
        }

        private string _codeTextCsharp = null;
        public string CodeTextCsharp
        {
            get { return _codeTextCsharp; }
            private set
            {
                _codeTextCsharp = value;

                NotifyPropertyChanged();
            }
        }


        private readonly LayerEditor _LayerEditor;

        private ObservableCollection<LayerBoxItem> _LiveTopToBottomLayers
        {
            get { return _LayerEditor.LiveTopToBottomLayers; }
        }

        private IEnumerable<LayerBoxItem> _BottomToTopLayers
        {
            get { return _LiveTopToBottomLayers.Reverse(); }
        }


        private FgLayerItem _currentXamlLayer;
        public FgLayerItem CurrentXamlLayer {
            get { return _currentXamlLayer; }
            set
            {
                _currentXamlLayer = value;
                NotifyPropertyChanged();
            }
        }



        private readonly CodegenXaml _CodegenXaml;

        private readonly CodegenCsharp _CodegenCsharp;

        private void UpdateGeneratedCode()
        {

            this.CodeTextCsharp = _CodegenCsharp.GetCode();

            this.CodeTextXaml = _CodegenXaml.GetCode();

        }

        public LayerBoxItem CreateLayer(int position)
        {
            var newLayerItem = new FgLayerItem(_FgPreview, position);    // in case we just add new
            SetPropertyEventHandlers(newLayerItem);

            return newLayerItem;
        }
    }

}
