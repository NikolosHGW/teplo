using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Teplo
{
    class Button : INotifyPropertyChanged
    {
        public int Left { get; }
        public int Top { get; }
        public Button(int left, int top)
        {
            Left = left;
            Top = top;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        private bool isState;
        public bool IsState
        {
            get
            {
                return isState;
            }
            set
            {
                isState = value;
                OnPropertyChanged("IsState");
            }
        }
    }
}
