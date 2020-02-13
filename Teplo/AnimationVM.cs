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
            if (GetButtons.ButtonsC[3].IsState == true && GetLines.LinesC[5].State == true)
            {
                Game.ChangeForAnim(7);
                if (Lin7 != null)
                {
                    Lin7.Completed += new EventHandler(Lin7a1_Completed);
                }
                Line7.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin7);
                Lin7 = null;
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
            if (Lin5 != null)
            {
                Lin5.Completed += new EventHandler(Lin5_Completed);//после пятой потечет в левую сторону вода 7 линия
            }
            Line5.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin5);
            Lin5 = null;
            Game.ChangeForAnim(6);
            //if (Lin6 != null)
            //{
            //    Lin6.Completed += new EventHandler(Lin6_Completed);//после шестой потечет в нижнюю часть вода
            //}
            Line6.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin6);
            Lin6 = null;
        }
        private static void Lin4a1_Completed(object sender, EventArgs e)/*Если закрыта задвижка Button[2], то при ее открытии запускается этот метод*/
        {
            Game.ChangeForAnim(5);
            //if (Lin5 != null)
            //{
            //    Lin5.Completed += new EventHandler(Lin5a1_Completed);
            //}
            Line5.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin5);
            Lin5 = null;
            Game.ChangeForAnim(6);
            //Lin6.Completed += new EventHandler(Lin6a1_Completed);
            Line6.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin6);
            Lin6 = null;
        }
        private static void Lin5_Completed(object sender, EventArgs e)/*При заранее открытой задвижки Button[2]*/
        {
            Game.ChangeForAnim(7);
            if (Lin7 != null)
            {
                Lin7.Completed += new EventHandler(Lin7_Completed);//после седьмой потечет 8 и 9
            }
            Line7.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin7);
            Lin7 = null;
        }
        private static void Lin7_Completed(object sender, EventArgs e)/*При заранее открытой задвижки Button[2]*/
        {
            Game.ChangeForAnim(8);
            if (Lin8 != null)
            {
                Lin8.Completed += new EventHandler(Lin8_Completed);//после восьмой потечет 10 и 11
            }
            Line8.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin8);
            Lin8 = null;
            Game.ChangeForAnim(9);
            //if (Lin9 != null)
            //{
            //    Lin9.Completed += new EventHandler(Lin9_Completed);
            //}
            Line9.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin9);
            Lin9 = null;
        }
        private static void Lin8_Completed(object sender, EventArgs e)/*При заранее открытой задвижки Button[2]*/
        {
            Game.ChangeForAnim(10);
            //if (Lin10 != null)
            //{
            //    Lin10.Completed += new EventHandler(Lin10_Completed);//после десятой потечет ? и ?
            //}
            Line10.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin10);
            Lin10 = null;
            Game.ChangeForAnim(11);
            //if (Lin11 != null)
            //{
            //    Lin11.Completed += new EventHandler(Lin11_Completed);
            //}
            Line11.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin11);
            Lin11 = null;
        }
        private static void Lin7a1_Completed(object sender, EventArgs e)/*При заранее открытой задвижки Button[2]*/
        {
            Game.ChangeForAnim(8);
            if (Lin8 != null)
            {
                Lin8.Completed += new EventHandler(Lin8a1_Completed);//после восьмой потечет 10 и 11
            }
            Line8.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin8);
            Lin8 = null;
            Game.ChangeForAnim(9);
            //if (Lin9 != null)
            //{
            //    Lin9.Completed += new EventHandler(Lin9a1_Completed);
            //}
            Line9.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin9);
            Lin9 = null;
        }
        private static void Lin8a1_Completed(object sender, EventArgs e)/*При заранее открытой задвижки Button[2]*/
        {
            Game.ChangeForAnim(10);
            Line10.BeginAnimation(System.Windows.Shapes.Line.X2Property, Lin10);
            Lin10 = null;
            Game.ChangeForAnim(11);
            Line11.BeginAnimation(System.Windows.Shapes.Line.Y2Property, Lin11);
            Lin11 = null;
        }
    }
}
