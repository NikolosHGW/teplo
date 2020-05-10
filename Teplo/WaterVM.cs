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
    }
}
