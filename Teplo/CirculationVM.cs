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
        public static bool StateCircFull { get; private set; } = true;

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

            if (StateCircFull == true && GetButtons.ButtonsVC[4].IsState == true && GetButtons.ButtonsVC[5].IsState == true && WaterVM.LinesA[37].Opacity == 1 && Parameters.ChckFPmpL == true && GetButtons.ButtonsPmpLC[0].IsState == true && WaterVM.LinesA[2].Opacity == 1 && GetButtons.ButtonsC[4].IsState == true && GetButtons.ButtonsC[1].IsState == true)
            {
                StartAnim();
            }
            if (GetButtons.ButtonsVC[4].IsState == false || GetButtons.ButtonsVC[5].IsState == false || GetButtons.ButtonsPmpLC[0].IsState == false || GetButtons.ButtonsC[4].IsState == false || GetButtons.ButtonsC[1].IsState == false)
            {
                StopAnim();
            }
        }
        private static void FlushingFst()
        {
            for (int i = 0; i < 10; i++)
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
            for (int i = 0; i < 10; i++)
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
        private static void StartAnim()
        {
            for (int i = 10; i < 15; i++)
            {
                CircLines[i].Opacity = 1;
            }
            CircLines[10].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[10]);
            CircLines[11].BeginAnimation(System.Windows.Shapes.Line.Y2Property, CircAnLines[11]);
            CircLines[12].BeginAnimation(System.Windows.Shapes.Line.Y2Property, CircAnLines[12]);
            CircLines[13].BeginAnimation(System.Windows.Shapes.Line.X2Property, CircAnLines[13]);
            CircLines[14].BeginAnimation(System.Windows.Shapes.Line.Y2Property, CircAnLines[14]);
            StateCircFull = false;
        }
        private static void StopAnim()
        {
            for (int i = 10; i < 15; i++)
            {
                CircLines[i].Opacity = 0;
            }
            CircLines[10].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[11].BeginAnimation(System.Windows.Shapes.Line.Y2Property, null);
            CircLines[12].BeginAnimation(System.Windows.Shapes.Line.Y2Property, null);
            CircLines[13].BeginAnimation(System.Windows.Shapes.Line.X2Property, null);
            CircLines[14].BeginAnimation(System.Windows.Shapes.Line.Y2Property, null);
            StateCircFull = true;
        }
    }
}
