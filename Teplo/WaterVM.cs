using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Core;

namespace Teplo
{
    class WaterVM
    {
        public static ObservableCollection<Line> Lines { get; set; } = new ObservableCollection<Line>();
        public static ObservableCollection<DoubleAnimationUsingKeyFrames> AnLines { get; set; } = new ObservableCollection<DoubleAnimationUsingKeyFrames>();
        public static void Start()
        {
            //                                         Начало заполнения обратного трубопровода
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
            //                                         Конец заполнения обратного трубопровода

            //                                         Начало заполнения подаюшего трубопровода
            if (GetButtons.ButtonsVC[9].IsState == true && GetButtons.ButtonsVC[7].IsState == false && GetButtons.ButtonsVC[8].IsState == false && GetButtons.ButtonsC[3].IsState == true && Lines[11].Opacity == 1)
            {
                Lines[17].Opacity = 0;
                Lines[16].Opacity = 0;
                Lines[15].Opacity = 0;
            }
            if (GetButtons.ButtonsVC[6].IsState == true && GetButtons.ButtonsVC[7].IsState == false && GetButtons.ButtonsVC[8].IsState == false && GetButtons.ButtonsC[3].IsState == true && Lines[11].Opacity == 1)
            {
                Lines[12].Opacity = 0;
                Lines[13].Opacity = 0;
                Lines[14].Opacity = 0;
            }
            if (GetButtons.ButtonsVC[2].IsState == true && GetButtons.ButtonsVC[0].IsState == true && GetButtons.ButtonsVC[9].IsState == true && GetButtons.ButtonsVC[6].IsState == true && GetButtons.ButtonsSmlC[2].IsState == true && Lines[11].Opacity == 1)
            {
                if (AnLines[18] != null)
                {
                    AnLines[18].Completed += new EventHandler(AnLines18_Completed);
                }
                Lines[18].Opacity = 1;
                Lines[18].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[18]);
                AnLines[18] = null;
            }
            //                                         Конец заполнения подающего трубопровода

        }
        //                                         Начало заполнения обратного трубопровода
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
        //                                         Конец заполнения обратного трубопровода

        //                                         Начало заполнения подаюшего трубопровода
        private static void AnLines18_Completed(object sender, EventArgs e)
        {
            Lines[19].Opacity = 1;
            Lines[19].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[19]);
            AnLines[19] = null;
            if (AnLines[20] != null)
            {
                AnLines[20].Completed += new EventHandler(AnLines20_Completed);
            }
            Lines[20].Opacity = 1;
            Lines[20].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[20]);
            AnLines[20] = null;
        }
        private static void AnLines20_Completed(object sender, EventArgs e)
        {
            if (AnLines[21] != null)
            {
                AnLines[21].Completed += new EventHandler(AnLines21_Completed);
            }
            Lines[21].Opacity = 1;
            Lines[21].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[21]);
            AnLines[21] = null;
        }
        private static void AnLines21_Completed(object sender, EventArgs e)
        {
            Lines[23].Opacity = 1;
            Lines[23].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[23]);
            AnLines[23] = null;
            if (AnLines[22] != null)
            {
                AnLines[22].Completed += new EventHandler(AnLines22_Completed);
            }
            Lines[22].Opacity = 1;
            Lines[22].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[22]);
            AnLines[22] = null;
        }
        private static void AnLines22_Completed(object sender, EventArgs e)
        {
            Lines[24].Opacity = 1;
            Lines[24].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[24]);
            AnLines[24] = null;
            if (AnLines[25] != null)
            {
                AnLines[25].Completed += new EventHandler(AnLines25_Completed);
            }
            Lines[25].Opacity = 1;
            Lines[25].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[25]);
            AnLines[25] = null;
        }
        private static void AnLines25_Completed(object sender, EventArgs e)
        {
            if (AnLines[26] != null)
            {
                AnLines[26].Completed += new EventHandler(AnLines26_Completed);
            }
            Lines[26].Opacity = 1;
            Lines[26].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[26]);
            AnLines[26] = null;
        }
        private static void AnLines26_Completed(object sender, EventArgs e)
        {
            Lines[27].Opacity = 1;
            Lines[27].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[27]);
            AnLines[27] = null;
            if (AnLines[28] != null)
            {
                AnLines[28].Completed += new EventHandler(AnLines28_Completed);
            }
            Lines[28].Opacity = 1;
            Lines[28].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[28]);
            AnLines[28] = null;
        }
        private static void AnLines28_Completed(object sender, EventArgs e)
        {
            if (AnLines[29] != null)
            {
                AnLines[29].Completed += new EventHandler(AnLines29_Completed);
            }
            Lines[29].Opacity = 1;
            Lines[29].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[29]);
            AnLines[29] = null;
        }
        private static void AnLines29_Completed(object sender, EventArgs e)
        {
            Lines[30].Opacity = 1;
            Lines[30].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[30]);
            AnLines[30] = null;
            if (AnLines[31] != null)
            {
                AnLines[31].Completed += new EventHandler(AnLines31_Completed);
            }
            Lines[31].Opacity = 1;
            Lines[31].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[31]);
            AnLines[31] = null;
        }
        private static void AnLines31_Completed(object sender, EventArgs e)
        {
            if (AnLines[32] != null)
            {
                AnLines[32].Completed += new EventHandler(AnLines32_Completed);
            }
            Lines[32].Opacity = 1;
            Lines[32].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[32]);
            AnLines[32] = null;
        }
        private static void AnLines32_Completed(object sender, EventArgs e)
        {
            Lines[34].Opacity = 1;
            Lines[34].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[34]);
            AnLines[34] = null;
            if (AnLines[33] != null)
            {
                AnLines[33].Completed += new EventHandler(AnLines33_Completed);
            }
            Lines[33].Opacity = 1;
            Lines[33].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLines[33]);
            AnLines[33] = null;
        }
        private static void AnLines33_Completed(object sender, EventArgs e)
        {
            if (AnLines[35] != null)
            {
                //AnLines[35].Completed += new EventHandler(AnLines32_Completed);
            }
            Lines[35].Opacity = 1;
            Lines[35].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLines[35]);
            AnLines[35] = null;
        }
        //                                         Конец заполнения подающего трубопровода
    }
}
