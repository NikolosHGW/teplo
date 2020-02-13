using Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Teplo
{
    public class AnimationVM
    {
        public static DoubleAnimationUsingKeyFrames Lin0 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line0 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin1 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line1 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin2 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line2 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin3 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line3 { get; set; } = new System.Windows.Shapes.Line();
        public static void Push()
        {
            if (GetLines.LinesC[0].State == true && Game.l0)
            {
                Lin0.Completed += new EventHandler(Lin0_Completed);
                Line0.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin0);
                Game.l0 = false;
            }
        }
        private static void Lin0_Completed(object sender, EventArgs e)
        {
            GetLines.LinesC[1].State = true;
            Lin1.Completed += new EventHandler(Lin1_Completed);
            Line1.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin1);
        }
        private static void Lin1_Completed(object sender, EventArgs e)
        {
            GetLines.LinesC[2].State = true;
            //Lin2.Completed += new EventHandler(Lin2_Completed);
            Line2.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin2);
            GetLines.LinesC[3].State = true;
            Line3.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin3);
        }
    }
}
