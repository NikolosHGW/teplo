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

        //public static ObservableCollection<Line> CircLinesA { get; set; } = new ObservableCollection<Line>();
        //public static ObservableCollection<DoubleAnimationUsingKeyFrames> CircAnLinesA { get; set; } = new ObservableCollection<DoubleAnimationUsingKeyFrames>();
        public static bool StateCirc { get; set; } = true;

        public static void StartCirc()
        {
            if (GetButtons.ButtonsPmpLC[0].IsState == true && GetButtons.ButtonsC[1].IsState == true && WaterVM.LinesA[3].Opacity == 1 && WaterVM.LinesA[37].Opacity == 1 && GetButtons.ButtonsC[4].IsState == true || GetButtons.ButtonsSmlC[1].IsState == true)
            {
                if (StateCirc == true)
                {
                    for (int i = 0; i < CircLines.Count; i++)
                    {
                        if (i != 3 && i != 4 && i != 5)
                        {
                            CircLines[i].Opacity = 1;
                        }
                    }
                    StartAnimation();
                }
            }
            if (GetButtons.ButtonsPmpLC[0].IsState == false)
            {
                for (int i = 0; i < CircLines.Count; i++)
                {
                    CircLines[i].Opacity = 0;
                }
                StopAnimation();
            }
        }

        public static void StartAnimation()
        {
            for (int i = 0; i < CircAnLines.Count; i++)
            {
                CircAnLines[i].RepeatBehavior = RepeatBehavior.Forever;
            }
            CircLines[0].BeginAnimation(Line.X2Property, CircAnLines[0]);
            CircLines[1].BeginAnimation(Line.X2Property, CircAnLines[1]);
            CircLines[2].BeginAnimation(Line.X2Property, CircAnLines[2]);
            //CircLines[3].BeginAnimation(Line.Y2Property, CircAnLines[3]);
            //CircLines[4].BeginAnimation(Line.Y2Property, CircAnLines[4]);
            //CircLines[5].BeginAnimation(Line.Y2Property, CircAnLines[5]);
            CircLines[6].BeginAnimation(Line.X2Property, CircAnLines[6]);
            CircLines[7].BeginAnimation(Line.X2Property, CircAnLines[7]);
            CircLines[8].BeginAnimation(Line.Y2Property, CircAnLines[8]);
            CircLines[9].BeginAnimation(Line.Y2Property, CircAnLines[9]);
            CircLines[10].BeginAnimation(Line.X2Property, CircAnLines[10]);
            CircLines[11].BeginAnimation(Line.X2Property, CircAnLines[11]);
            CircLines[12].BeginAnimation(Line.Y2Property, CircAnLines[12]);
            CircLines[13].BeginAnimation(Line.X2Property, CircAnLines[13]);
            CircLines[14].BeginAnimation(Line.X2Property, CircAnLines[14]);
            CircLines[15].BeginAnimation(Line.Y2Property, CircAnLines[15]);
            CircLines[16].BeginAnimation(Line.X2Property, CircAnLines[16]);
            StateCirc = false;
        }

        public static void StopAnimation()
        {
            CircLines[0].BeginAnimation(Line.X2Property, null);
            CircLines[1].BeginAnimation(Line.X2Property, null);
            CircLines[2].BeginAnimation(Line.X2Property, null);
            CircLines[3].BeginAnimation(Line.Y2Property, null);
            CircLines[4].BeginAnimation(Line.Y2Property, null);
            CircLines[5].BeginAnimation(Line.Y2Property, null);
            CircLines[6].BeginAnimation(Line.X2Property, null);
            CircLines[7].BeginAnimation(Line.X2Property, null);
            CircLines[8].BeginAnimation(Line.Y2Property, null);
            CircLines[9].BeginAnimation(Line.Y2Property, null);
            CircLines[10].BeginAnimation(Line.X2Property, null);
            StateCirc = true;
        }

    }
}
