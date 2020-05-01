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

        public static ObservableCollection<Line> LinesA { get; set; } = new ObservableCollection<Line>();
        public static ObservableCollection<DoubleAnimationUsingKeyFrames> AnLinesA { get; set; } = new ObservableCollection<DoubleAnimationUsingKeyFrames>();

        public static void ResetAnim()
        {
            for (int i = 0; i < AnLines.Count; i++)
            {
                AnLinesA[i].Name = null;
            }
        }

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

        public static void ElementsNull()
        {
            for (int i = 0; i < LinesA.Count; i++)
            {
                LinesA[i].Opacity = 0;
            }
            for (int i = 0; i < GetButtons.ButtonsC.Count; i++)
            {
                GetButtons.ButtonsC[i].IsState = false;
            }
            for (int i = 0; i < GetButtons.ButtonsVC.Count; i++)
            {
                GetButtons.ButtonsVC[i].IsState = false;
            }
            for (int i = 0; i < GetButtons.ButtonsSmlC.Count; i++)
            {
                GetButtons.ButtonsSmlC[i].IsState = false;
            }
        }

        public static void Start()
        {
            //                                         Начало заполнения обратного т\м трубопровода
            if (GetButtons.ButtonsPmpRC[0].IsState == true && GetButtons.ButtonsC[0].IsState == true && PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[0] != null)
                {
                    AnLinesA[0].Completed += new EventHandler(AnLines0_Completed);
                }
                LinesA[0].Opacity = 1;
                if (AnLinesA[0].Name == null)
                {
                    LinesA[0].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[0]);
                }
                AnLinesA[0].Name = "off";
            }
            //                                         Конец заполнения обратного т\м трубопровода

            //                                         Начало заполнения подаюшего т\м трубопровода
            if (GetButtons.ButtonsVC[9].IsState == true && GetButtons.ButtonsVC[7].IsState == false && GetButtons.ButtonsVC[8].IsState == false && GetButtons.ButtonsC[3].IsState == true && LinesA[11].Opacity == 1 && PumpAnimVM.RotationPmpR == true)
            {
                LinesA[17].Opacity = 0;
                LinesA[16].Opacity = 0;
                LinesA[15].Opacity = 0;
            }
            if (GetButtons.ButtonsVC[6].IsState == true && GetButtons.ButtonsVC[7].IsState == false && GetButtons.ButtonsVC[8].IsState == false && GetButtons.ButtonsC[3].IsState == true && LinesA[11].Opacity == 1 && PumpAnimVM.RotationPmpR == true)
            {
                LinesA[12].Opacity = 0;
                LinesA[13].Opacity = 0;
                LinesA[14].Opacity = 0;
            }
            if (GetButtons.ButtonsVC[2].IsState == true && GetButtons.ButtonsVC[0].IsState == true && GetButtons.ButtonsVC[9].IsState == true && GetButtons.ButtonsVC[6].IsState == true && GetButtons.ButtonsSmlC[2].IsState == true && LinesA[11].Opacity == 1 && PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[18] != null)
                {
                    AnLinesA[18].Completed += new EventHandler(AnLines18_Completed);
                }
                LinesA[18].Opacity = 1;
                if (AnLinesA[18].Name == null)
                {
                    LinesA[18].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[18]);
                }
                AnLinesA[18].Name = "off";
            }
            //                                         Конец заполнения подающего т\м трубопровода
            if (GetButtons.ButtonsVC[4].IsState == false)
            {
                GetButtons.ButtonsVC[5].IsState = false;
            }
            if (GetButtons.ButtonsVC[4].IsState == true && GetButtons.ButtonsVC[5].IsState == true && LinesA[35].Opacity == 1)
            {
                AnLinesA[36].Completed += new EventHandler(AnLines36_Completed);
                LinesA[36].Opacity = 1;
                if (AnLinesA[36].Name == null)
                {
                    LinesA[36].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[36]);
                }
                AnLinesA[36].Name = "off";
            }

            //Заполнение обратного р\с трубопровода 
            if (GetButtons.ButtonsVC[3].IsState == true && GetButtons.ButtonsSmlC[3].IsState == true && LinesA[37].Opacity == 1 && GetButtons.ButtonsVC[4].IsState == true && GetButtons.ButtonsVC[5].IsState == true && LinesA[35].Opacity == 1 && LinesA[19].Opacity == 1)
            {
                AnLinesA[38].Completed += new EventHandler(AnLines38_Completed);
                LinesA[38].Opacity = 1;
                if (AnLinesA[38].Name == null)
                {
                    LinesA[38].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[38]);
                }
                AnLinesA[38].Name = "off";
            }
            
            //Заполнение подающего р\с трубопровода
            if (LinesA[44].Opacity == 1 && GetButtons.ButtonsVC[11].IsState == true && GetButtons.ButtonsVC[12].IsState == true)
            {
                AnLinesA[45].Completed += new EventHandler(AnLines45_Completed);
                LinesA[45].Opacity = 1;
                if (AnLinesA[45].Name == null)
                {
                    LinesA[45].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[45]);
                }
                AnLinesA[45].Name = "off";
            }

            if (GetButtons.ButtonsVC[4].IsState == true && GetButtons.ButtonsVC[5].IsState == true && CirculationVM.CircLines[9].Opacity == 1 && CirculationVM.CircLines[8].Opacity == 1 && GetButtons.ButtonsSmlC[0].IsState == true)
            {
                CirculationVM.CircLines[8].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[35].Stroke = System.Windows.Media.Brushes.Red;
                CirculationVM.CircLines[7].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[33].Stroke = System.Windows.Media.Brushes.Red;
                CirculationVM.CircLines[6].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[22].Stroke = System.Windows.Media.Brushes.Red;
                CirculationVM.CircLines[11].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[47].Stroke = System.Windows.Media.Brushes.Red;
                CirculationVM.CircLines[12].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[46].Stroke = System.Windows.Media.Brushes.Red;
                CirculationVM.CircLines[13].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[45].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[34].Stroke = System.Windows.Media.Brushes.Red;
                LinesA[23].Stroke = System.Windows.Media.Brushes.Red;
            }
            else
            {
                CirculationVM.CircLines[8].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[35].Stroke = System.Windows.Media.Brushes.Blue;
                CirculationVM.CircLines[7].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[33].Stroke = System.Windows.Media.Brushes.Blue;
                CirculationVM.CircLines[6].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[22].Stroke = System.Windows.Media.Brushes.Blue;
                CirculationVM.CircLines[11].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[47].Stroke = System.Windows.Media.Brushes.Blue;
                CirculationVM.CircLines[12].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[46].Stroke = System.Windows.Media.Brushes.Blue;
                CirculationVM.CircLines[13].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[45].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[34].Stroke = System.Windows.Media.Brushes.Blue;
                LinesA[23].Stroke = System.Windows.Media.Brushes.Blue;
            }

        }

        //Заполнение обртаного р\с трубопровода
        private static void AnLines38_Completed(object sender, EventArgs e)
        {
            AnLinesA[39].Completed += new EventHandler(AnLines39_Completed);
            LinesA[39].Opacity = 1;
            if (AnLinesA[39].Name == null)
            {
                LinesA[39].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[39]);
            }
            AnLinesA[39].Name = "off";
            LinesA[40].Opacity = 1;
            if (AnLinesA[40].Name == null)
            {
                LinesA[40].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[40]);
            }
            AnLinesA[40].Name = "off";
        }
        private static void AnLines39_Completed(object sender, EventArgs e)
        {
            AnLinesA[41].Completed += new EventHandler(AnLines41_Completed);
            LinesA[41].Opacity = 1;
            if (AnLinesA[41].Name == null)
            {
                LinesA[41].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[41]);
            }
            AnLinesA[41].Name = "off";
        }
        private static void AnLines41_Completed(object sender, EventArgs e)
        {
            AnLinesA[42].Completed += new EventHandler(AnLines42_Completed);
            LinesA[42].Opacity = 1;
            if (AnLinesA[42].Name == null)
            {
                LinesA[42].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[42]);
            }
            AnLinesA[42].Name = "off";
        }
        private static void AnLines42_Completed(object sender, EventArgs e)
        {
            AnLinesA[43].Completed += new EventHandler(AnLines43_Completed);
            LinesA[43].Opacity = 1;
            if (AnLinesA[43].Name == null)
            {
                LinesA[43].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[43]);
            }
            AnLinesA[43].Name = "off";
        }
        private static void AnLines43_Completed(object sender, EventArgs e)
        {
            //AnLinesA[44].Completed += new EventHandler(AnLines44_Completed);
            LinesA[44].Opacity = 1;
            if (AnLinesA[44].Name == null)
            {
                LinesA[44].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[44]);
            }
            AnLinesA[44].Name = "off";
        }
        //Конец заполнения обратного р\с трубопровода

        //private static void AnLines44_Completed(object sender, EventArgs e)
        //{
        //    AnLinesA[45].Completed += new EventHandler(AnLines45_Completed);
        //    LinesA[45].Opacity = 1;
        //    if (AnLinesA[45].Name == null)
        //    {
        //        LinesA[45].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[45]);
        //    }
        //    AnLinesA[45].Name = "off";
        //}
        private static void AnLines45_Completed(object sender, EventArgs e)
        {
            AnLinesA[46].Completed += new EventHandler(AnLines46_Completed);
            LinesA[46].Opacity = 1;
            if (AnLinesA[46].Name == null)
            {
                LinesA[46].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[46]);
            }
            AnLinesA[46].Name = "off";
        }
        private static void AnLines46_Completed(object sender, EventArgs e)
        {
            AnLinesA[47].Completed += new EventHandler(AnLines47_Completed);
            LinesA[47].Opacity = 1;
            if (AnLinesA[47].Name == null)
            {
                LinesA[47].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[47]);
            }
            AnLinesA[47].Name = "off";
        }
        private static void AnLines47_Completed(object sender, EventArgs e)
        {
            //AnLinesA[48].Completed += new EventHandler(AnLines48_Completed);
            LinesA[48].Opacity = 1;
            if (AnLinesA[48].Name == null)
            {
                LinesA[48].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[48]);
            }
            AnLinesA[48].Name = "off";
        }

        private static void AnLines36_Completed(object sender, EventArgs e)
        {
            //AnLinesA[37].Completed += new EventHandler(AnLines37_Completed);
            LinesA[37].Opacity = 1;
            if (AnLinesA[37].Name == null)
            {
                LinesA[37].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[37]);
            }
            AnLinesA[37].Name = "off";
        }

        //                                         Начало заполнения обратного т\м трубопровода
        private static void AnLines0_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[1] != null)
                {
                    AnLinesA[1].Completed += new EventHandler(AnLines1_Completed);
                }
                LinesA[1].Opacity = 1;
                if (AnLinesA[1].Name == null)
                {
                    LinesA[1].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[1]);
                }
                AnLinesA[1].Name = "off";
            }
        }
        private static void AnLines1_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[2].Opacity = 1;
                if (AnLinesA[2].Name == null)
                {
                    LinesA[2].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[2]);
                }
                AnLinesA[2].Name = "off";
                if (AnLinesA[3] != null)
                {
                    AnLinesA[3].Completed += new EventHandler(AnLines3_Completed);
                }
                LinesA[3].Opacity = 1;
                if (AnLinesA[3].Name == null)
                {
                    LinesA[3].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[3]);
                }
                AnLinesA[3].Name = "off";
            }
        }
        private static void AnLines3_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[4] != null)
                {
                    AnLinesA[4].Completed += new EventHandler(AnLines4_Completed);
                }
                LinesA[4].Opacity = 1;
                if (AnLinesA[4].Name == null)
                {
                    LinesA[4].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[4]);
                }
                AnLinesA[4].Name = "off";
            }
        }
        private static void AnLines4_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[5].Opacity = 1;
                if (AnLinesA[5].Name == null)
                {
                    LinesA[5].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[5]);
                }
                AnLinesA[5].Name = "off";
                if (AnLinesA[6] != null)
                {
                    AnLinesA[6].Completed += new EventHandler(AnLines6_Completed);
                }
                LinesA[6].Opacity = 1;
                if (AnLinesA[6].Name == null)
                {
                    LinesA[6].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[6]);
                }
                AnLinesA[6].Name = "off";
            }
        }
        private static void AnLines6_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[12] != null)
                {
                    AnLinesA[12].Completed += new EventHandler(AnLines12_Completed);
                }
                LinesA[12].Opacity = 1;
                if (AnLinesA[12].Name == null)
                {
                    LinesA[12].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[12]);
                }
                AnLinesA[12].Name = "off";
            }
        }
        private static void AnLines12_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[13] != null)
                {
                    AnLinesA[13].Completed += new EventHandler(AnLines13_Completed);
                }
                LinesA[13].Opacity = 1;
                if (AnLinesA[13].Name == null)
                {
                    LinesA[13].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[13]);
                }
                AnLinesA[13].Name = "off";
                LinesA[14].Opacity = 1;
                if (AnLinesA[14].Name == null)
                {
                    LinesA[14].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[14]);
                }
                AnLinesA[14].Name = "off";
            }
        }
        private static void AnLines13_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[15] != null)
                {
                    AnLinesA[15].Completed += new EventHandler(AnLines15_Completed);
                }
                LinesA[15].Opacity = 1;
                if (AnLinesA[15].Name == null)
                {
                    LinesA[15].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[15]);
                }
                AnLinesA[15].Name = "off";
            }
        }
        private static void AnLines15_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[16].Opacity = 1;
                if (AnLinesA[16].Name == null)
                {
                    LinesA[16].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[16]);
                }
                AnLinesA[16].Name = "off";
                if (AnLinesA[17] != null)
                {
                    AnLinesA[17].Completed += new EventHandler(AnLines17_Completed);
                }
                LinesA[17].Opacity = 1;
                if (AnLinesA[17].Name == null)
                {
                    LinesA[17].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[17]);
                }
                AnLinesA[17].Name = "off";
            }
        }
        private static void AnLines17_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[9] != null)
                {
                    AnLinesA[9].Completed += new EventHandler(AnLines9_Completed);
                }
                LinesA[9].Opacity = 1;
                if (AnLinesA[9].Name == null)
                {
                    LinesA[9].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[9]);
                }
                AnLinesA[9].Name = "off";
            }
        }
        private static void AnLines9_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[7].Opacity = 1;
                if (AnLinesA[7].Name == null)
                {
                    LinesA[7].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[7]);
                }
                AnLinesA[7].Name = "off";
                if (AnLinesA[8] != null)
                {
                    AnLinesA[8].Completed += new EventHandler(AnLines8_Completed);
                }
                LinesA[8].Opacity = 1;
                if (AnLinesA[8].Name == null)
                {
                    LinesA[8].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[8]);
                }
                AnLinesA[8].Name = "off";
            }
        }
        private static void AnLines8_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[10].Opacity = 1;
                if (AnLinesA[10].Name == null)
                {
                    LinesA[10].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[10]);
                }
                AnLinesA[10].Name = "off";
                if (AnLinesA[11] != null)
                {
                    //AnLinesA[11].Completed += new EventHandler(AnLines11_Completed);
                }
                LinesA[11].Opacity = 1;
                if (AnLinesA[11].Name == null)
                {
                    LinesA[11].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[11]);
                }
                AnLinesA[11].Name = "off";
            }
        }
        //                                         Конец заполнения обратного т\м трубопровода

        //                                         Начало заполнения подаюшего т\м трубопровода
        private static void AnLines18_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[19].Opacity = 1;
                if (AnLinesA[19].Name == null)
                {
                    LinesA[19].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[19]);
                }
                AnLinesA[19].Name = "off";
                if (AnLinesA[20] != null)
                {
                    AnLinesA[20].Completed += new EventHandler(AnLines20_Completed);
                }
                LinesA[20].Opacity = 1;
                if (AnLinesA[20].Name == null)
                {
                    LinesA[20].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[20]);
                }
                AnLinesA[20].Name = "off";
            }
        }
        private static void AnLines20_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[21] != null)
                {
                    AnLinesA[21].Completed += new EventHandler(AnLines21_Completed);
                }
                LinesA[21].Opacity = 1;
                if (AnLinesA[21].Name == null)
                {
                    LinesA[21].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[21]);
                }
                AnLinesA[21].Name = "off";
            }
        }
        private static void AnLines21_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[23].Opacity = 1;
                if (AnLinesA[23].Name == null)
                {
                    LinesA[23].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[23]);
                }
                AnLinesA[23].Name = "off";
                if (AnLinesA[22] != null)
                {
                    AnLinesA[22].Completed += new EventHandler(AnLines22_Completed);
                }
                LinesA[22].Opacity = 1;
                if (AnLinesA[22].Name == null)
                {
                    LinesA[22].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[22]);
                }
                AnLinesA[22].Name = "off";
            }
        }
        private static void AnLines22_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[24].Opacity = 1;
                if (AnLinesA[24].Name == null)
                {
                    LinesA[24].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[24]);
                }
                AnLinesA[24].Name = "off";
                if (AnLinesA[25] != null)
                {
                    AnLinesA[25].Completed += new EventHandler(AnLines25_Completed);
                }
                LinesA[25].Opacity = 1;
                if (AnLinesA[25].Name == null)
                {
                    LinesA[25].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[25]);
                }
                AnLinesA[25].Name = "off";
            }
        }
        private static void AnLines25_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[26] != null)
                {
                    AnLinesA[26].Completed += new EventHandler(AnLines26_Completed);
                }
                LinesA[26].Opacity = 1;
                if (AnLinesA[26].Name == null)
                {
                    LinesA[26].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[26]);
                }
                AnLinesA[26].Name = "off";
            }
        }
        private static void AnLines26_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[27].Opacity = 1;
                if (AnLinesA[27].Name == null)
                {
                    LinesA[27].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[27]);
                }
                AnLinesA[27].Name = "off";
                if (AnLinesA[28] != null)
                {
                    AnLinesA[28].Completed += new EventHandler(AnLines28_Completed);
                }
                LinesA[28].Opacity = 1;
                if (AnLinesA[28].Name == null)
                {
                    LinesA[28].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[28]);
                }
                AnLinesA[28].Name = "off";
            }
        }
        private static void AnLines28_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[29] != null)
                {
                    AnLinesA[29].Completed += new EventHandler(AnLines29_Completed);
                }
                LinesA[29].Opacity = 1;
                if (AnLinesA[29].Name == null)
                {
                    LinesA[29].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[29]);
                }
                AnLinesA[29].Name = "off";
            }
        }
        private static void AnLines29_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[30].Opacity = 1;
                if (AnLinesA[30].Name == null)
                {
                    LinesA[30].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[30]);
                }
                AnLinesA[30].Name = "off";
                if (AnLinesA[31] != null)
                {
                    AnLinesA[31].Completed += new EventHandler(AnLines31_Completed);
                }
                LinesA[31].Opacity = 1;
                if (AnLinesA[31].Name == null)
                {
                    LinesA[31].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[31]);
                }
                AnLinesA[31].Name = "off";
            }
        }
        private static void AnLines31_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[32] != null)
                {
                    AnLinesA[32].Completed += new EventHandler(AnLines32_Completed);
                }
                LinesA[32].Opacity = 1;
                if (AnLinesA[32].Name == null)
                {
                    LinesA[32].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[32]);
                }
                AnLinesA[32].Name = "off";
            }
        }
        private static void AnLines32_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                LinesA[34].Opacity = 1;
                if (AnLinesA[34].Name == null)
                {
                    LinesA[34].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[34]);
                }
                AnLinesA[34].Name = "off";
                if (AnLinesA[33] != null)
                {
                    AnLinesA[33].Completed += new EventHandler(AnLines33_Completed);
                }
                LinesA[33].Opacity = 1;
                if (AnLinesA[33].Name == null)
                {
                    LinesA[33].BeginAnimation(System.Windows.Shapes.Line.X2Property, AnLinesA[33]);
                }
                AnLinesA[33].Name = "off";
            }
        }
        private static void AnLines33_Completed(object sender, EventArgs e)
        {
            if (PumpAnimVM.RotationPmpR == true)
            {
                if (AnLinesA[35] != null)
                {
                    //AnLines[35].Completed += new EventHandler(AnLines32_Completed);
                }
                LinesA[35].Opacity = 1;
                if (AnLinesA[35].Name == null)
                {
                    LinesA[35].BeginAnimation(System.Windows.Shapes.Line.Y2Property, AnLinesA[35]);
                }
                AnLinesA[35].Name = "off";
            }
        }
        //                                         Конец заполнения подающего т\м трубопровода
    }
}
