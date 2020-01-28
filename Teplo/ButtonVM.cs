using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;

namespace Teplo
{
    class ButtonVM : INotifyPropertyChanged
    {
        readonly ButtonTest butt = new ButtonTest();
        private bool isFirstImage;
        public bool IsFirstImage
        {
            get { return isFirstImage; }
            set { isFirstImage = value; OnPropertyChanged("IsFirstImage"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private RelayCommand toggleCommand;
        public RelayCommand ToggleCommand
        {
            get
            {
                return toggleCommand ??
                  (toggleCommand = new RelayCommand(obj =>
                  {
                      IsFirstImage = butt.ChangeImage();
                  }));
            }
        }
    }
}
