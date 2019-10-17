using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace PergleLabs.UI
{

    class MainWindowContext
        : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public MainWindowContext()
        {
            foreach (var readyMadeID in (ReadyMadeFontogram[])Enum.GetValues(typeof(ReadyMadeFontogram)))
            {
                ReadyMadeFontogramChoices.Add(readyMadeID);
            }


            this.ReadyMadeFontogramSelection = 0;
        }




        public List<ReadyMadeFontogram> ReadyMadeFontogramChoices { get; private set; } = new List<ReadyMadeFontogram>();


        private ReadyMadeFontogram? _readyMadeSelection = null;
        public ReadyMadeFontogram? ReadyMadeSelection
        {
            get { return _readyMadeSelection; }
            private set
            {
                _readyMadeSelection = value;

                NotifyPropertyChanged();
            }
        }


        int _selectedReadyMadeFontogram = 0;
        public int ReadyMadeFontogramSelection
        {
            get { return _selectedReadyMadeFontogram; }
            set
            {
                if (value > 0)
                    ReadyMadeSelection = ReadyMadeFontogramChoices[value];
                else
                    ReadyMadeSelection = null;

                _selectedReadyMadeFontogram = value;
            }
        }



    }

}
