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

            foreach (var readyMadeID in (ReadyMadeFontogram[])Enum.GetValues(typeof(ReadyMadeFontogram)))
            {
                ReadyMadeFontogramChoices.Add(readyMadeID);
            }

            this.ReadyMadeFontogramSelection = 0;   // default is "none" - an item separate from ReadyMadeFontogramChoices


            _CodegenCsharp = new CodegenCsharp(fgPreview);
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

                _readyMadeFontogramSelection = value;
            }
        }


        private string _CodeTextCsharp = null;
        public string CodeTextCsharp
        {
            get { return _CodeTextCsharp; }
            private set
            {
                _CodeTextCsharp = value;

                NotifyPropertyChanged();
            }
        }

        private string _genCodeXaml = null;
        public string GenCodeXaml
        {
            get { return _genCodeXaml; }
            private set
            {
                _genCodeXaml = value;

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


        private readonly CodegenCsharp _CodegenCsharp;

        private void UpdateGeneratedCode()
        {

            this.CodeTextCsharp = _CodegenCsharp.GetCode();

        }

    }

}
