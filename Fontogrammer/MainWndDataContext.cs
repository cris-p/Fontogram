using PergleLabs.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace PergleLabs.Fontogrammer
{

    class MainWndDataContext
        : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public FontogramData FgData { get; } = new FontogramData();


        private readonly Fontogram _FgPreview;
        public MainWndDataContext(Fontogram fgPreview)
        {
            _FgPreview = fgPreview;

            foreach (var readyMadeID in (ReadyMadeFontogram[])Enum.GetValues(typeof(ReadyMadeFontogram)))
            {
                ReadyMadeFontogramChoices.Add(readyMadeID);
            }


            this.ReadyMadeFontogramSelection = 0;
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
                    ReadyMadeSelectedValue = ReadyMadeFontogramChoices[value];
                else
                    ReadyMadeSelectedValue = null;

                _readyMadeFontogramSelection = value;
            }
        }


        public ObservableCollection<XamlLayerItem> XamlLayers { get; private set; } = new ObservableCollection<XamlLayerItem>();

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
            int pos = XamlLayers.Count;

            var newLayer = new XamlLayerItem(_FgPreview, pos);

            XamlLayers.Add(newLayer);

        }

        internal void RemoveCurrentLayer()
        {
        }
    }

}
