﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Threading;
using Core;

namespace Teplo
{
    class ButtonsVM : INotifyPropertyChanged
    {
        public ButtonsVM()
        {
            foreach (var item in Buttons)
            {
                GetButtons.ButtonsC.Add(item);
            }
            foreach (var item in ButtonsV)
            {
                GetButtons.ButtonsVC.Add(item);
            }
            foreach (var item in ButtonsSml)
            {
                GetButtons.ButtonsSmlC.Add(item);
            }
            foreach (var item in ButtonsPmpR)
            {
                GetButtons.ButtonsPmpRC.Add(item);
            }
            foreach (var item in ButtonsPmpL)
            {
                GetButtons.ButtonsPmpLC.Add(item);
            }
        }
        public ObservableCollection<Button> Buttons { get; } = new ObservableCollection<Button>
        {
            new Button(437, 153), // valve 1 // Button[0]
            new Button(396, 248), // valve 2 // Button[1]
            new Button(553, 250), // valve 3 // Button[2]
            new Button(661, 253), // valve 4 // Button[3]
            new Button(267, 246), // valve 5 // Button[4]
            new Button(873, 252), // valve 6 // Button[5]
            new Button(667, 505), // valve 7 // Button[6]
            new Button(875, 506), // valve 8 // Button[7]
            new Button(396, 312), // Button[8]
            new Button(396, 376), // Button[9]
            new Button(267, 310), // Button[10]
            new Button(267, 374), // Button[11]
            new Button(553, 508), // Button[12]
        };
        public ObservableCollection<Button> ButtonsV { get; } = new ObservableCollection<Button>
        {
            new Button(856, 444), // valve 9 // ButtonV[0]
            new Button(913, 444), // valve 10 // ButtonV[1]
            new Button(855, 322), // valve 14 // ButtonV[2]
            new Button(912, 321), // valve 15 // ButtonV[3]
            new Button(165, 292), // valve 16 // ButtonV[4]
            new Button(165, 365), // valve 17 // ButtonV[5]
            new Button(634, 442), // valve 19 // ButtonV[6]
            new Button(633, 319), // valve 20 // ButtonV[7]
            new Button(709, 319), // valve 21 // ButtonV[8]
            new Button(709, 442), // valve 22 // ButtonV[9]
            new Button(1220, 228), // valve 26 // ButtonV[10]
            new Button(1135, 326), // valve 27 // ButtonV[11]
            new Button(1135, 446), // valve 28 // ButtonV[12]
            new Button(1220, 528), // valve 29 // ButtonV[13]
            new Button(514, 379), // valve 20 // ButtonV[14]
        };
        public ObservableCollection<Button> ButtonsSml { get; } = new ObservableCollection<Button>
        {
            new Button(118, 330), // valve 18 // ButtonSml[0]
            new Button(277, 277), // valve 13 // ButtonSml[1]
            new Button(672, 379), // valve 11 // ButtonSml[2]
            new Button(887, 378), // valve 12 // ButtonSml[3]
            new Button(1094, 381), // valve 23 // ButtonSml[4]
            new Button(1182, 510), // valve 24 // ButtonSml[5]
            new Button(1182, 260), // valve 25 // ButtonSml[6]
            new Button(277, 339), // ButtonSml[7]
            new Button(277, 403), // ButtonSml[8]
            new Button(564, 220), // valve 11 // ButtonSml[9]
            new Button(564, 550), // valve 11 // ButtonSml[10]
            new Button(588, 401), // valve 11 // ButtonSml[11]
            new Button(754, 400), // valve 11 // ButtonSml[12]
            new Button(815, 351), // valve 11 // ButtonSml[13]
            new Button(952, 349), // valve 11 // ButtonSml[14]
            new Button(1236, 260), // valve 11 // ButtonSml[15]
        };
        public ObservableCollection<Button> ButtonsPmpR { get; } = new ObservableCollection<Button>
        {
            new Button(380, 146) // pump 1 // ButtonPmpR[0]
        };
        public ObservableCollection<Button> ButtonsPmpL { get; } = new ObservableCollection<Button>
        {
            new Button(349, 246), // pump 2 // ButtonPmpL[0]
            new Button(349, 310), // ButtonPmpL[1]
            new Button(349, 374) // ButtonPmpL[2]
        };
        private RelayCommand stateCommand;
        public RelayCommand StateCommand
        {
            get
            {
                return stateCommand ??
                  (stateCommand = new RelayCommand(obj =>
                  {
                      ChangeState((Button)obj);
                  }));
            }
        }
        void ChangeState(Button button)
        {
            button.IsState = !button.IsState;
            WaterVM.Start();
            ChangeParam();
            CirculationVM.StartCirc();
            PumpAnimVM.StartPmpR(button.Left, button.Top);
            PumpAnimVM.StartPmpL(button.Left, button.Top);
            //Game.StartGame();
            //for(int i = 0; i < 5; i++)
            //{
            //    LineVM.Push();
            //}
        }

        //ПАРАМЕТРЫ
        private double p1;
        public double P1
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

        private double p2;
        public double P2
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

        private int gp;
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
        private bool forTimer = true;
        void ChangeParam()
        {
            Parameters.Calc();
            Gp = Parameters.Gp;
            if (forTimer == true)
                StartTimerTick();
        }
        private void StartTimerTick()
        {
            forTimer = false;
            DispatcherTimer timer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Start();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            Parameters.Calc();
            P1 = Parameters.P1;
            P2 = Parameters.P2;
            T1 = Parameters.T1;
            T2 = Parameters.T2;
            G1 = Parameters.G1;
            G2 = Parameters.G2;
            Gp = Parameters.Gp;
        }

        //                                            ВРЕМЕННЫЙ КОД ДЛЯ ИНФО
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
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        private RelayCommand infoCommand;
        public RelayCommand InfoCommand
        {
            get
            {
                return infoCommand ??
                  (infoCommand = new RelayCommand(obj =>
                  {
                      if (Opa == 1)
                          Opa = 0;
                      else
                          Opa = 1;
                  }));
            }
        }
        //Кнопка сброса
        //private RelayCommand resetCommand;
        //public RelayCommand ResetCommand
        //{
        //    get
        //    {
        //        return resetCommand ??
        //          (resetCommand = new RelayCommand(obj =>
        //          {
        //              WaterVM.ResetAnim();
        //              WaterVM.ElementsNull();
        //          }));
        //    }
        //}
    }
}
