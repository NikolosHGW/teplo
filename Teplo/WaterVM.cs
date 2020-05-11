using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Core;

namespace Teplo
{
    class WaterVM
    {
        public static ObservableCollection<Line> Lines { get; set; } = new ObservableCollection<Line>();
        public static ObservableCollection<DoubleAnimationUsingKeyFrames> AnLines { get; set; } = new ObservableCollection<DoubleAnimationUsingKeyFrames>();

        public static ObservableCollection<Line> LinesA { get; set; } = new ObservableCollection<Line>();
        public static ObservableCollection<DoubleAnimationUsingKeyFrames> AnLinesA { get; set; } = new ObservableCollection<DoubleAnimationUsingKeyFrames>();

        public static void FillUp()
        {
            foreach (var item in Lines)
            {
                LinesA.Add(item);
            }
            foreach (var item in AnLines)
            {
                AnLinesA.Add(item);
            }
        }

        public static void Start()
        {
            if (GetButtons.ButtonsC[0].IsState == true && GetButtons.ButtonsPmpRC[0].IsState == false)
            {
                Parameters.Chck = false;
            }
            if (GetButtons.ButtonsPmpRC[0].IsState == false && GetButtons.ButtonsC[0].IsState == false)
            {
                Parameters.Chck = true;
            }

            if (GetButtons.ButtonsPmpRC[0].IsState == true && GetButtons.ButtonsC[0].IsState == true && Parameters.Chck == true && PumpAnimVM.RotationPmpR == true && GetButtons.ButtonsVC[14].IsState == true)
            {
                LinesA[0].Opacity = 1;
                if (AnLinesA[0].Name == null)
                {
                    LinesA[0].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[0]);
                }
                AnLinesA[0].Name = "off";
                if (Parameters.NumberGp == 0)
                    Parameters.NumberGp = 1;
            }
            if (GetButtons.ButtonsPmpRC[0].IsState == true && GetButtons.ButtonsC[0].IsState == true && Parameters.Chck == true && PumpAnimVM.RotationPmpR == true)
                Filling();
        }

        public static async Task ForParamDelayAsync(int ms, int i)
        {
            await Task.Delay(ms);
            if (Parameters.NumberGp == (i - 1))
                Parameters.NumberGp = i;
        }
        public static async Task ForOpacityDelayAsync(int ms, int i)
        {
            await Task.Delay(ms);
            LinesA[i].Opacity = 1;
        }
        private static void Filling()
        {
            if (LinesA[0].Opacity == 1)
            {
                ForOpacityDelayAsync(300, 1);
                if (AnLinesA[1].Name == null)
                {
                    LinesA[1].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[1]);
                }
                AnLinesA[1].Name = "off";
                ForOpacityDelayAsync(600, 2);
                if (AnLinesA[2].Name == null)
                {
                    LinesA[2].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[2]);
                }
                AnLinesA[2].Name = "off";
                ForOpacityDelayAsync(600, 3);
                if (AnLinesA[3].Name == null)
                {
                    LinesA[3].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[3]);
                }
                AnLinesA[3].Name = "off";
                ForOpacityDelayAsync(900, 43);
                if (AnLinesA[43].Name == null)
                {
                    LinesA[43].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[43]);
                }
                AnLinesA[43].Name = "off";
                ForOpacityDelayAsync(1200, 33);
                if (AnLinesA[33].Name == null)
                {
                    LinesA[33].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[33]);
                }
                AnLinesA[33].Name = "off";
                ForOpacityDelayAsync(1500, 35);
                ForParamDelayAsync(1800, 2);
                if (AnLinesA[35].Name == null)
                {
                    LinesA[35].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[35]);
                }
                AnLinesA[35].Name = "off";
            }
            if (LinesA[35].Opacity == 1 && GetButtons.ButtonsC[6].IsState == true && GetButtons.ButtonsC[7].IsState == true && GetButtons.ButtonsVC[12].IsState == true && GetButtons.ButtonsVC[11].IsState == true && GetButtons.ButtonsC[5].IsState == true && GetButtons.ButtonsC[3].IsState == true && GetButtons.ButtonsC[12].IsState == true)
            {
                if (Parameters.NumberGp == 2)
                    Parameters.NumberGp = 3;
                LinesA[34].Opacity = 1;
                if (AnLinesA[34].Name == null)
                {
                    LinesA[34].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[34]);
                }
                AnLinesA[34].Name = "off";
                ForOpacityDelayAsync(300, 32);
                if (AnLinesA[32].Name == null)
                {
                    LinesA[32].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[32]);
                }
                AnLinesA[32].Name = "off";
                ForOpacityDelayAsync(600, 22);
                if (AnLinesA[22].Name == null)
                {
                    LinesA[22].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[22]);
                }
                AnLinesA[22].Name = "off";
                ForOpacityDelayAsync(600, 25);
                if (AnLinesA[25].Name == null)
                {
                    LinesA[25].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[25]);
                }
                AnLinesA[25].Name = "off";
                ForOpacityDelayAsync(900, 21);
                if (AnLinesA[21].Name == null)
                {
                    LinesA[21].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[21]);
                }
                AnLinesA[21].Name = "off";
                ForOpacityDelayAsync(1200, 48);
                if (AnLinesA[48].Name == null)
                {
                    LinesA[48].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[48]);
                }
                AnLinesA[48].Name = "off";
                ForOpacityDelayAsync(1200, 47);
                if (AnLinesA[47].Name == null)
                {
                    LinesA[47].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[47]);
                }
                AnLinesA[47].Name = "off";
                ForOpacityDelayAsync(1500, 46);
                if (AnLinesA[46].Name == null)
                {
                    LinesA[46].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[46]);
                }
                AnLinesA[46].Name = "off";
                ForOpacityDelayAsync(1800, 42);
                if (AnLinesA[42].Name == null)
                {
                    LinesA[42].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[42]);
                }
                AnLinesA[42].Name = "off";
                ForOpacityDelayAsync(2100, 41);
                if (AnLinesA[41].Name == null)
                {
                    LinesA[41].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[41]);
                }
                AnLinesA[41].Name = "off";
                ForOpacityDelayAsync(2400, 11);
                if (AnLinesA[11].Name == null)
                {
                    LinesA[11].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[11]);
                }
                AnLinesA[11].Name = "off";
                ForOpacityDelayAsync(2400, 8);
                if (AnLinesA[8].Name == null)
                {
                    LinesA[8].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[8]);
                }
                AnLinesA[8].Name = "off";
                ForOpacityDelayAsync(2700, 7);
                if (AnLinesA[7].Name == null)
                {
                    LinesA[7].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[7]);
                }
                AnLinesA[7].Name = "off";
                ForOpacityDelayAsync(2700, 9);
                if (AnLinesA[9].Name == null)
                {
                    LinesA[9].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[9]);
                }
                AnLinesA[9].Name = "off";
                ForOpacityDelayAsync(3000, 5);
                if (AnLinesA[5].Name == null)
                {
                    LinesA[5].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[5]);
                }
                AnLinesA[5].Name = "off";
                ForOpacityDelayAsync(3300, 6);
                if (AnLinesA[6].Name == null)
                {
                    LinesA[6].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[6]);
                }
                AnLinesA[6].Name = "off";
                ForOpacityDelayAsync(3300, 4);
                ForParamDelayAsync(3500, 4);
                if (AnLinesA[4].Name == null)
                {
                    LinesA[4].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[4]);
                }
                AnLinesA[4].Name = "off";
            }
            if (GetButtons.ButtonsVC[7].IsState == true && GetButtons.ButtonsSmlC[11].IsState == true && LinesA[4].Opacity == 1)
            {
                if (Parameters.NumberGp == 4)
                    Parameters.NumberGp = 5;
                LinesA[30].Opacity = 1;
                if (AnLinesA[30].Name == null)
                {
                    LinesA[30].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[30]);
                }
                AnLinesA[30].Name = "off";
                ForOpacityDelayAsync(300, 29);
                if (AnLinesA[29].Name == null)
                {
                    LinesA[29].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[29]);
                }
                AnLinesA[29].Name = "off";
                ForOpacityDelayAsync(300, 31);
                if (AnLinesA[31].Name == null)
                {
                    LinesA[31].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[31]);
                }
                AnLinesA[31].Name = "off";
                ForOpacityDelayAsync(600, 49);
                if (AnLinesA[49].Name == null)
                {
                    LinesA[49].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[49]);
                }
                AnLinesA[49].Name = "off";
            }
        }
    }
}
