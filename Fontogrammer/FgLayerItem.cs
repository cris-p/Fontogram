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

    interface LayerBoxItem
    {
        int Position { get; set; }
    }

    partial class FgLayerItem
        : INotifyPropertyChanged
        , LayerBoxItem
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Fontogram PreviewFontogram { get; }


        public int Position
        {
            get { return PositionInFontogram; }
            set { PositionInFontogram = value; }
        }

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


        public FgLayerItem(Fontogram fg, int pos)
        {
            PreviewFontogram = fg;

            PositionInFontogram = pos;
        }

    }

}
