using PergleLabs.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PergleLabs.Fontogrammer
{

    partial class XamlLayerItem
        : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Fontogram PreviewFontogram { get; }

        int _positionInFontogram;
        public int PositionInFontogram
        { 
            get { return _positionInFontogram; }
            set
            {
                _positionInFontogram = value;
                NotifyPropertyChanged();
            }
        }



        public XamlLayerItem(Fontogram fg, int pos)
        {
            PreviewFontogram = fg;

            PositionInFontogram = pos;
        }

    }

}
