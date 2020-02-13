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
        //
        public static DoubleAnimationUsingKeyFrames Lin4 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line4 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin5 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line5 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin6 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line6 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin7 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line7 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin8 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line8 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin9 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line9 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin10 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line10 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static DoubleAnimationUsingKeyFrames Lin11 { get; set; } = new DoubleAnimationUsingKeyFrames();
        public static System.Windows.Shapes.Line Line11 { get; set; } = new System.Windows.Shapes.Line();
        //
        public static void Push()
        {
            if (GetLines.LinesC[0].State == true)
            {
                if (Lin0 != null)
                {
                    Lin0.Completed += new EventHandler(Lin0_Completed);
                }
                Line0.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin0);
                Lin0 = null;
            }
            if (GetButtons.ButtonsC[2].IsState == true && GetLines.LinesC[3].State == true)
            {
                Game.ChangeForAnim(4);
                if (Lin4 != null)
                {
                    Lin4.Completed += new EventHandler(Lin4a1_Completed);
                }
                Line4.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin4);
                Lin4 = null;
            }
        }
        private static void Lin0_Completed(object sender, EventArgs e)
        {
            Game.ChangeForAnim(1);
            if (Lin1 != null)
            {
                Lin1.Completed += new EventHandler(Lin1_Completed);
            }
            Line1.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin1);
            Lin1 = null;
        }
        private static void Lin1_Completed(object sender, EventArgs e)
        {
            Game.ChangeForAnim(2);
            //Lin2.Completed += new EventHandler(Lin2_Completed);
            Line2.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin2);
            Lin2 = null;
            Game.ChangeForAnim(3);
            if (Lin3 != null)
            {
                Lin3.Completed += new EventHandler(Lin3_Completed);
            }
            Line3.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin3);
            Lin3 = null;
        }
        private static void Lin3_Completed(object sender, EventArgs e)
        {
            if (GetButtons.ButtonsC[2].IsState == true)
            {
                Game.ChangeForAnim(4);
                if (Lin4 != null)
                {
                    Lin4.Completed += new EventHandler(Lin4_Completed);
                }
                Line4.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin4);
                Lin4 = null;
            }
        }
        private static void Lin4_Completed(object sender, EventArgs e)/*При заранее открытой задвижки Button[2]*/
        {
            Game.ChangeForAnim(5);
            //Lin5.Completed += new EventHandler(Lin5_Completed);
            Line5.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin5);
            Lin5 = null;
            Game.ChangeForAnim(6);
            //Lin6.Completed += new EventHandler(Lin6_Completed);
            Line6.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin6);
            Lin6 = null;
        }
        private static void Lin4a1_Completed(object sender, EventArgs e)/*Если закрыта задвижка Button[2]*/
        {
            Game.ChangeForAnim(5);
            //Lin5.Completed += new EventHandler(Lin5_Completed);
            Line5.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin5);
            Lin5 = null;
            Game.ChangeForAnim(6);
            //Lin6.Completed += new EventHandler(Lin6_Completed);
            Line6.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin6);
            Lin6 = null;
        }
    }
}
