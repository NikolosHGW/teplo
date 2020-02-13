using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core
{
    public class GetButtons
    {
        static public ObservableCollection<Button> ButtonsC { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonsVC { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonsSmlC { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonsPmpRC { get; set; } = new ObservableCollection<Button>();
        static public ObservableCollection<Button> ButtonsPmpLC { get; set; } = new ObservableCollection<Button>();
    }
}
