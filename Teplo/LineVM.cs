using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Core;

namespace Teplo
{
    class LineVM
    {
        public static ObservableCollection<Line> Lines { get; set; } = new ObservableCollection<Line>();
        public static ObservableCollection<DoubleAnimationUsingKeyFrames> AnLines { get; set; } = new ObservableCollection<DoubleAnimationUsingKeyFrames>();
        public static void Push()
        {
            //                                         Начало первого этапа заполнения
            if (GetButtons.ButtonsPmpRC[0].IsState == true && GetButtons.ButtonsC[0].IsState == true)
            {
                if (AnLines[0] != null)
                {
                    AnLines[0].Completed += new EventHandler(AnLines0_Completed);
                }
                Lines[0].Opacity = 1;
                Lines[0].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[0]);
                AnLines[0] = null;
            }
            //                                         Конец первого этапа заполнения
        }
        //                                         Начало первого этапа заполнения
        private static void AnLines0_Completed(object sender, EventArgs e)
        {
            if (AnLines[1] != null)
            {
                AnLines[1].Completed += new EventHandler(AnLines1_Completed);
            }
            Lines[1].Opacity = 1;
            Lines[1].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[1]);
            AnLines[0] = null;
        }
        private static void AnLines1_Completed(object sender, EventArgs e)
        {
            Lines[2].Opacity = 1;
            Lines[2].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[2]);
            AnLines[2] = null;
            if (AnLines[3] != null)
            {
                AnLines[3].Completed += new EventHandler(AnLines3_Completed);
            }
            Lines[3].Opacity = 1;
            Lines[3].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[3]);
            AnLines[3] = null;
        }
        private static void AnLines3_Completed(object sender, EventArgs e)
        {
            if (AnLines[4] != null)
            {
                AnLines[4].Completed += new EventHandler(AnLines4_Completed);
            }
            Lines[4].Opacity = 1;
            Lines[4].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[4]);
            AnLines[4] = null;
        }
        private static void AnLines4_Completed(object sender, EventArgs e)
        {
            Lines[5].Opacity = 1;
            Lines[5].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[5]);
            AnLines[5] = null;
            if (AnLines[6] != null)
            {
                AnLines[6].Completed += new EventHandler(AnLines6_Completed);
            }
            Lines[6].Opacity = 1;
            Lines[6].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[6]);
            AnLines[6] = null;
        }
        private static void AnLines6_Completed(object sender, EventArgs e)
        {
            if (AnLines[12] != null)
            {
                AnLines[12].Completed += new EventHandler(AnLines12_Completed);
            }
            Lines[12].Opacity = 1;
            Lines[12].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[12]);
            AnLines[12] = null;
        }
        private static void AnLines12_Completed(object sender, EventArgs e)
        {
            if (AnLines[13] != null)
            {
                AnLines[13].Completed += new EventHandler(AnLines13_Completed);
            }
            Lines[13].Opacity = 1;
            Lines[13].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[13]);
            AnLines[13] = null;
            Lines[14].Opacity = 1;
            Lines[14].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[14]);
            AnLines[14] = null;
        }
        private static void AnLines13_Completed(object sender, EventArgs e)
        {
            if (AnLines[15] != null)
            {
                AnLines[15].Completed += new EventHandler(AnLines15_Completed);
            }
            Lines[15].Opacity = 1;
            Lines[15].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[15]);
            AnLines[15] = null;
        }
        private static void AnLines15_Completed(object sender, EventArgs e)
        {
            Lines[16].Opacity = 1;
            Lines[16].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[16]);
            AnLines[16] = null;
            if (AnLines[17] != null)
            {
                AnLines[17].Completed += new EventHandler(AnLines17_Completed);
            }
            Lines[17].Opacity = 1;
            Lines[17].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[17]);
            AnLines[17] = null;
        }
        private static void AnLines17_Completed(object sender, EventArgs e)
        {
            if (AnLines[9] != null)
            {
                AnLines[9].Completed += new EventHandler(AnLines9_Completed);
            }
            Lines[9].Opacity = 1;
            Lines[9].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[9]);
            AnLines[9] = null;
        }
        private static void AnLines9_Completed(object sender, EventArgs e)
        {
            Lines[7].Opacity = 1;
            Lines[7].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[7]);
            AnLines[7] = null;
            if (AnLines[8] != null)
            {
                AnLines[8].Completed += new EventHandler(AnLines8_Completed);
            }
            Lines[8].Opacity = 1;
            Lines[8].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[8]);
            AnLines[8] = null;
        }
        private static void AnLines8_Completed(object sender, EventArgs e)
        {
            Lines[10].Opacity = 1;
            Lines[10].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[10]);
            AnLines[10] = null;
            if (AnLines[11] != null)
            {
                //AnLines[11].Completed += new EventHandler(AnLines11_Completed);
            }
            Lines[11].Opacity = 1;
            Lines[11].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[11]);
            AnLines[11] = null;
        }
        //                                         Конец первого этапа заполнения
    }
}
