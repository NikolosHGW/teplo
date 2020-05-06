using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Core;

namespace Teplo
{
    class ParametersVM : INotifyPropertyChanged
    {
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
                OnPropertyChanged("P1");
            }
        }

        private int p2;
        public int P2
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
                OnPropertyChanged("P2");
            }
        }

        private int t1;
        public int T1
        {
            get
            {
                return t1;
            }
            set
            {
                t1 = value;
                OnPropertyChanged("T1");
            }
        }

        private int t2;
        public int T2
        {
            get
            {
                return t2;
            }
            set
            {
                t2 = value;
                OnPropertyChanged("T2");
            }
        }

        private int g1;
        public int G1
        {
            get
            {
                return g1;
            }
            set
            {
                g1 = value;
                OnPropertyChanged("G1");
            }
        }

        private int g2;
        public int G2
        {
            get
            {
                return g2;
            }
            set
            {
                g2 = value;
                OnPropertyChanged("G2");
            }
        }

        private int gp = 0;
        public int Gp
        {
            get
            {
                return gp;
            }
            set
            {
                gp = value;
                OnPropertyChanged("Gp");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
