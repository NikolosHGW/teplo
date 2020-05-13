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

        public static bool StateCirc { get; private set; } = true;
        
        public static void StartCirc()
        {
            if (GetButtons.ButtonsPmpRC[0].IsState == true && StateCirc == true && GetButtons.ButtonsSmlC[11].IsState == true && WaterVM.LinesA[49].Opacity == 1)
            {
                FlushingFst();
            }
            if (GetButtons.ButtonsPmpRC[0].IsState == false || GetButtons.ButtonsSmlC[11].IsState == false)
            {
                StopFlushingFst();
            }
        }
        private static void FlushingFst()
        {
            for (int i = 0; i < CircLines.Count; i++)
            {
                CircLines[i].Opacity = 1;
            }
            CircLines[0].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[0]);
            CircLines[1].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[1]);
            CircLines[2].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[2]);
            CircLines[3].BeginAnimation(System.Windows.Shapes.Line.Y2Property, CircAnLines[3]);
            CircLines[4].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[4]);
            CircLines[5].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[5]);
            CircLines[6].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[6]);
            CircLines[7].BeginAnimation(System.Windows.Shapes.Line.Y2Property, CircAnLines[7]);
            CircLines[8].BeginAnimation(System.Windows.Shapes.Line.Y2Property, CircAnLines[8]);
            CircLines[9].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[9]);
            StateCirc = false;
        }
        private static void StopFlushingFst()
        {
            for (int i = 0; i < CircLines.Count; i++)
            {
                CircLines[i].Opacity = 0;
            }
            CircLines[0].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[1].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[2].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[3].BeginAnimation(System.Windows.Shapes.Line.Y2Property, null);
            CircLines[4].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[5].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[6].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[7].BeginAnimation(System.Windows.Shapes.Line.Y2Property, null);
            CircLines[8].BeginAnimation(System.Windows.Shapes.Line.Y2Property, null);
            CircLines[9].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            StateCirc = true;
        }

    }
}
