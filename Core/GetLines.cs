using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Core
{
    public class GetLines
    {
        static public ObservableCollection<Line> LinesC { get; set; } = new ObservableCollection<Line>();
    }
}
