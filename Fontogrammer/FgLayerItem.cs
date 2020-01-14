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

    public interface LayerBoxItem
    {
        int Position { get; set; }
        void Show(bool doShow);
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

        public void Show(bool doShow)
        {
            PreviewFontogram.ShowLayer(PositionInFontogram, doShow);
        }


        private bool _isTextApplied = true;
        public bool IsTextApplied
        {
            get { return _isTextApplied; }
            set
            {
                _isTextApplied = value;
                UpdateTextApplication();
            }
        }

        private bool _isBackdropApplied = true;
        public bool IsBackdropApplied
        {
            get { return _isBackdropApplied; }
            set
            {
                _isBackdropApplied = value;
                UpdateBackdropApplication();
            }
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


            UpdateTextApplication();

            UpdateBackdropApplication();
        }


        private void UpdateTextApplication()
        {
            if (IsTextApplied)
            {
                UpdateText();
                UpdateTextAttr();
                UpdateTextPosRel();
                UpdateTextTransform();
            }
            else
            {
                Text = "";
                TextAttr = "";
                TextPosRel = "";
                TextTransform = "";
            }
        }

        private void UpdateBackdropApplication()
        {
            if (IsBackdropApplied)
            {
                UpdateBackAttr();
                UpdateBackPosRel();
                UpdateBackBorderNumbersRel();
                UpdateBackTransform();
            }
            else
            {
                BackAttr = "";
                BackPosRel = "";
                BackBorderNumbersRel = "";
                BackTransform = "";
            }
        }

    }

}
