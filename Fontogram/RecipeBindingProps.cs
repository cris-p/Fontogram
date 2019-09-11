using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace PergleLabs.UI
{

    class RecipeBindingProps
        : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;



        string _symbolFont;
        public string SymbolFont
        {
            get { return _symbolFont; }
            set { _symbolFont = value; NotifyPropertyChanged(); }
        }

        private double _symbolFontSize;
        public double SymbolFontSize
        {
            get { return _symbolFontSize; }
            set { _symbolFontSize = value; NotifyPropertyChanged(); }
        }

        string _symbolFontWeight;
        public string SymbolFontWeight
        {
            get { return _symbolFontWeight; }
            set { _symbolFontWeight = value; NotifyPropertyChanged(); }
        }

        string _symbolColor;
        public string SymbolColor
        {
            get { return _symbolColor; }
            set { _symbolColor = value; NotifyPropertyChanged(); }
        }

        string _symbolMargin;
        public string SymbolMargin
        {
            get { return _symbolMargin; }
            set { _symbolMargin = value; NotifyPropertyChanged(); }
        }

        string _symbolText;
        public string SymbolText
        {
            get { return _symbolText; }
            set { _symbolText = value; NotifyPropertyChanged(); }
        }



        string _backOpacity;
        public string BackOpacity
        {
            get { return _backOpacity; }
            set { _backOpacity = value; NotifyPropertyChanged(); }
        }

        string _backFillColor;
        public string BackFillColor
        {
            get { return _backFillColor; }
            set { _backFillColor = value; NotifyPropertyChanged(); }
        }

        string _backStrokeThickness;
        public string BackStrokeThickness
        {
            get { return _backStrokeThickness; }
            set { _backStrokeThickness = value; NotifyPropertyChanged(); }
        }

        string _backStrokeColor;
        public string BackStrokeColor
        {
            get { return _backStrokeColor; }
            set { _backStrokeColor = value; NotifyPropertyChanged(); }
        }

        string _backMargin;
        public string BackMargin
        {
            get { return _backMargin; }
            set { _backMargin = value; NotifyPropertyChanged(); }
        }

        double _backHeight;
        public double BackHeight
        {
            get { return _backHeight; }
            set { _backHeight = value; NotifyPropertyChanged(); }
        }

        double _backWidth;
        public double BackWidth
        {
            get { return _backWidth; }
            set { _backWidth = value; NotifyPropertyChanged(); }
        }

        string _backCornerRadius;
        public string BackCornerRadius
        {
            get { return _backCornerRadius; }
            set { _backCornerRadius = value; NotifyPropertyChanged(); }
        }




        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
