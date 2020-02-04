using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Teplo
{
    class ButtonsVM : INotifyPropertyChanged
    {
        public ObservableCollection<Button> Buttons { get; } = new ObservableCollection<Button>
        {
            new Button(437, 153), // valve 1
            new Button(396, 248), // valve 2
            new Button(558, 250), // valve 3
            new Button(661, 253), // valve 4
            new Button(267, 246), // valve 5
            new Button(873, 252), // valve 6
            new Button(667, 505), // valve 7
            new Button(875, 506), // valve 8
        };
        public ObservableCollection<Button> ButtonsV { get; } = new ObservableCollection<Button>
        {
            new Button(856, 444), // valve 9
            new Button(913, 444), // valve 10
            new Button(855, 322), // valve 14
            new Button(912, 321), // valve 15
            new Button(165, 292), // valve 16
            new Button(165, 365), // valve 17
            new Button(634, 442), // valve 19
            new Button(633, 319), // valve 20
            new Button(709, 319), // valve 21
            new Button(709, 442), // valve 22
            new Button(745, 607), // valve 26
            new Button(790, 607), // valve 27
            new Button(790, 636), // valve 28
            new Button(745, 636)  // valve 29
        };
        public ObservableCollection<Button> ButtonsSml { get; } = new ObservableCollection<Button>
        {
            new Button(118, 330), // valve 18
            new Button(277, 277), // valve 13
            new Button(672, 379), // valve 11
            new Button(887, 378), // valve 12
            new Button(767, 585), // valve 23
            new Button(767, 665), // valve 24
            new Button(768, 625)  // valve 25
        };
        public ObservableCollection<Button> ButtonsPmpR { get; } = new ObservableCollection<Button>
        {
            new Button(380, 146) // pump 1
        };
        public ObservableCollection<Button> ButtonsPmpL { get; } = new ObservableCollection<Button>
        {
            new Button(349, 246) // pump 2
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
