using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Core;

namespace Teplo
{
    class ButtonsVM : INotifyPropertyChanged
    {
        public Game Game { get; set; } = new Game();
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
            new Button(558, 250), // valve 3 // Button[2]
            new Button(661, 253), // valve 4 // Button[3]
            new Button(267, 246), // valve 5 // Button[4]
            new Button(873, 252), // valve 6 // Button[5]
            new Button(667, 505), // valve 7 // Button[6]
            new Button(875, 506), // valve 8 // Button[7]
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
            new Button(745, 607), // valve 26 // ButtonV[10]
            new Button(790, 607), // valve 27 // ButtonV[11]
            new Button(790, 636), // valve 28 // ButtonV[12]
            new Button(745, 636)  // valve 29 // ButtonV[13]
        };
        public ObservableCollection<Button> ButtonsSml { get; } = new ObservableCollection<Button>
        {
            new Button(118, 330), // valve 18 // ButtonSml[0]
            new Button(277, 277), // valve 13 // ButtonSml[1]
            new Button(672, 379), // valve 11 // ButtonSml[2]
            new Button(887, 378), // valve 12 // ButtonSml[3]
            new Button(767, 585), // valve 23 // ButtonSml[4]
            new Button(767, 665), // valve 24 // ButtonSml[5]
            new Button(768, 625)  // valve 25 // ButtonSml[6]
        };
        public ObservableCollection<Button> ButtonsPmpR { get; } = new ObservableCollection<Button>
        {
            new Button(380, 146) // pump 1 // ButtonPmpR[0]
        };
        public ObservableCollection<Button> ButtonsPmpL { get; } = new ObservableCollection<Button>
        {
            new Button(349, 246) // pump 2 // ButtonPmpL[0]
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
            PumpAnimVM.Start();
            //Game.StartGame();
            //for(int i = 0; i < 5; i++)
            //{
            //    LineVM.Push();
            //}
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
    }
}
