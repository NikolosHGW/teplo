using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Teplo
{
    class ViewModelINFO : INotifyPropertyChanged
    {
        private int opa;
        public int Opa
        {
            get
            {
                return opa;
            }
            set
            {
                opa = value;
                OnPropertyChanged("Opa");
            }
        }

        public void ChngOpa ()
        {
            Opa = ModelINFO.SwapOpa(Opa);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
