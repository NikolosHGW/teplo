using System;
using Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Teplo
{
    class CirculationVM
    {
        public static ObservableCollection<Line> CircLines { get; set; } = new ObservableCollection<Line>();
        public static ObservableCollection<DoubleAnimationUsingKeyFrames> CircAnLines { get; set; } = new ObservableCollection<DoubleAnimationUsingKeyFrames>();

        public static bool StateCirc { get; set; } = true;
        

    }
}
