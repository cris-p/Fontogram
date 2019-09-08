using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace PergleLabs.UI
{

    class XamlProps
        : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private double _fontSize;
        public double FontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                NotifyPropertyChanged();
            }
        }



        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}
