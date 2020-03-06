using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Core;

namespace Teplo
{
    class PumpAnimVM
    {
        public static MediaPlayer MStart { get; set; } = new MediaPlayer();
        public static MediaPlayer MStop { get; set; } = new MediaPlayer();
        public static Line Blade1 { get; set; }
        public static Line Blade2 { get; set; }
        static DoubleAnimation blade1Anim = new DoubleAnimation();
        static DoubleAnimation blade2Anim = new DoubleAnimation();
        public static void Start()
        {
            if (GetButtons.ButtonsPmpRC[0].IsState == true)
            {
                //MStart.Open(new Uri("C:/Users/Nikolos/Downloads/Запуск.mp3"/*@"Resources/Start.mp3"*/, UriKind.RelativeOrAbsolute));
                blade1Anim.From = 0;
                blade1Anim.To = 360;
                blade1Anim.BeginTime = TimeSpan.FromSeconds(1);
                blade1Anim.Duration = TimeSpan.FromSeconds(0.3);
                blade1Anim.RepeatBehavior = RepeatBehavior.Forever;
                blade2Anim.From = 0;
                blade2Anim.To = 360;
                blade2Anim.BeginTime = TimeSpan.FromSeconds(1);
                blade2Anim.Duration = TimeSpan.FromSeconds(0.3);
                blade2Anim.RepeatBehavior = RepeatBehavior.Forever;
                MStart.Play();
                Blade1.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, blade1Anim);
                Blade2.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, blade2Anim);
            }
        }
    }
}
