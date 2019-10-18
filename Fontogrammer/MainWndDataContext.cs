using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace PergleLabs.UI
{

    class MainWndDataContext
        : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public FontogramData FgDoc { get; } = new FontogramData();


        public MainWndDataContext()
        {
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



    }

}
