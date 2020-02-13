using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Core
{
    public class Line : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        private bool state;
        public bool State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged("state");
            }
        }
    }
}
