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



namespace PergleLabs.Fontogrammer
{

    partial class MainWndDataContext
        : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private readonly Fontogram _FgPreview;
        public MainWndDataContext(Fontogram fgPreview)
        {
            _FgPreview = fgPreview;

            _CodegenXaml = new CodegenXaml(fgPreview);

            _CodegenCsharp = new CodegenCsharp(fgPreview);


            foreach (var readyMadeID in (ReadyMadeFontogram[])Enum.GetValues(typeof(ReadyMadeFontogram)))
            {
                ReadyMadeFontogramChoices.Add(readyMadeID);
            }

            this.ReadyMadeFontogramSelection = 0;   // default is "none" - an item separate from ReadyMadeFontogramChoices
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


        public ObservableCollection<XamlLayerItem> XamlReversedLayers { get; } = new ObservableCollection<XamlLayerItem>();


        private XamlLayerItem _currentXamlLayer;
        public XamlLayerItem CurrentXamlLayer {
            get { return _currentXamlLayer; }
            set
            {
                _currentXamlLayer = value;
                NotifyPropertyChanged();
            }
        }


        private int _currentXamlLayerIndex;
        public int CurrentXamlLayerIndex
        {
            get { return _currentXamlLayerIndex; }
            set
            {
                _currentXamlLayerIndex = value;
                NotifyPropertyChanged();
            }
        }


        public void AddLayer()
        {
            int pos = XamlReversedLayers.Count;

            var newLayer = new XamlLayerItem(_FgPreview, pos);

            SetPropertyEventHandlers(newLayer);

            XamlReversedLayers.Insert(0, newLayer);
        }

        public void RemoveCurrentLayer()
        {
        }


        public void MoveUpSelectedLayer()
        {
            // since layers are shown reversed, we need to decrease the index

            RepositionLayer(CurrentXamlLayerIndex, CurrentXamlLayerIndex - 1);
        }

        public void MoveDownSelectedLayer()
        {
            // since layers are shown reversed, we need to increase the index

            RepositionLayer(CurrentXamlLayerIndex, CurrentXamlLayerIndex + 1);
        }

        private void RepositionLayer(int originalLayerIndex, int newLayerIndex)
        {
            int layerCount = XamlReversedLayers.Count;
            if (originalLayerIndex < 0 || originalLayerIndex >= layerCount)
                return;

            if (newLayerIndex < 0 || newLayerIndex >= layerCount)
                return;


            // Remove from old position.
            XamlLayerItem layerItem = XamlReversedLayers[originalLayerIndex];
            XamlReversedLayers.RemoveAt(originalLayerIndex);

            // Layers above (meaning: at lower indexes in the ListBox) will have their position in the Fontogram decremented.
            for (int i=0; i<originalLayerIndex; i++)
                XamlReversedLayers[i].PositionInFontogram--;


            // Add into new position.
            XamlReversedLayers.Insert(newLayerIndex, layerItem);

            // Layers starting from the new position and up (lower indexes in the ListBox) must have their position in the Fontogram updated.
            // ('layerCount' is now again accurate.)
            for (int i = 0; i <= newLayerIndex; i++)
                XamlReversedLayers[i].PositionInFontogram = layerCount - i - 1;

            CurrentXamlLayerIndex = newLayerIndex;


            ReapplyProperties();
        }

        private readonly CodegenXaml _CodegenXaml;

        private readonly CodegenCsharp _CodegenCsharp;

        private void UpdateGeneratedCode()
        {

            this.CodeTextCsharp = _CodegenCsharp.GetCode();

            this.CodeTextXaml = _CodegenXaml.GetCode();

        }

    }

}
