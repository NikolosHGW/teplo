using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core
{
    public class GetButtons
    {
        public ObservableCollection<Button> ButtonsC { get; set; }
        public ObservableCollection<Button> ButtonsVC { get; set; }
        public ObservableCollection<Button> ButtonsSmlC { get; set; }
        public ObservableCollection<Button> ButtonsPmpRC { get; set; }
        public ObservableCollection<Button> ButtonsPmpLC { get; set; }
    }
}
