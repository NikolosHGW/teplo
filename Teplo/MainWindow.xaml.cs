using Core;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Teplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ButtonsVM();

            //                                              Анимация насоса
            MediaPlayer mediaStart = new MediaPlayer();
            //mediaStart.Open(new Uri("C:/Users/Николос/source/repos/teplo/Teplo/Resources/Start.mp3"/*@"Resources/Start.mp3"*/, UriKind.RelativeOrAbsolute)); /*C:/Users/Nikolos/Downloads/Запуск.mp3*/
            PumpAnimVM.MStart = mediaStart;
            MediaPlayer mediaStop = new MediaPlayer();
            //mediaStop.Open(new Uri("C:/Users/Николос/Downloads/Останов.mp3", UriKind.RelativeOrAbsolute));
            PumpAnimVM.MStop = mediaStop;

            DoubleAnimation blade1Anim = new DoubleAnimation();
            PumpAnimVM.Blade1Anim = blade1Anim;
            PumpAnimVM.Blade1 = blade1;
            DoubleAnimation blade2Anim = new DoubleAnimation();
            PumpAnimVM.Blade2Anim = blade2Anim;
            PumpAnimVM.Blade2 = blade2;

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

            DoubleAnimation blade21Anim = new DoubleAnimation();
            PumpAnimVM.Blade21Anim = blade21Anim;
            PumpAnimVM.Blade21 = blade21;
            DoubleAnimation blade22Anim = new DoubleAnimation();
            PumpAnimVM.Blade22Anim = blade22Anim;
            PumpAnimVM.Blade22 = blade22;

            blade21Anim.From = 0;
            blade21Anim.To = -360;
            blade21Anim.BeginTime = TimeSpan.FromSeconds(1);
            blade21Anim.Duration = TimeSpan.FromSeconds(0.3);
            blade21Anim.RepeatBehavior = RepeatBehavior.Forever;
            blade22Anim.From = 0;
            blade22Anim.To = -360;
            blade22Anim.BeginTime = TimeSpan.FromSeconds(1);
            blade22Anim.Duration = TimeSpan.FromSeconds(0.3);
            blade22Anim.RepeatBehavior = RepeatBehavior.Forever;

            DoubleAnimation blade31Anim = new DoubleAnimation();
            PumpAnimVM.Blade31Anim = blade31Anim;
            PumpAnimVM.Blade31 = blade31;
            DoubleAnimation blade32Anim = new DoubleAnimation();
            PumpAnimVM.Blade32Anim = blade32Anim;
            PumpAnimVM.Blade32 = blade32;

            blade31Anim.From = 0;
            blade31Anim.To = -360;
            blade31Anim.BeginTime = TimeSpan.FromSeconds(1);
            blade31Anim.Duration = TimeSpan.FromSeconds(0.3);
            blade31Anim.RepeatBehavior = RepeatBehavior.Forever;
            blade32Anim.From = 0;
            blade32Anim.To = -360;
            blade32Anim.BeginTime = TimeSpan.FromSeconds(1);
            blade32Anim.Duration = TimeSpan.FromSeconds(0.3);
            blade32Anim.RepeatBehavior = RepeatBehavior.Forever;

            DoubleAnimation blade41Anim = new DoubleAnimation();
            PumpAnimVM.Blade41Anim = blade41Anim;
            PumpAnimVM.Blade41 = blade41;
            DoubleAnimation blade42Anim = new DoubleAnimation();
            PumpAnimVM.Blade42Anim = blade42Anim;
            PumpAnimVM.Blade42 = blade42;

            blade41Anim.From = 0;
            blade41Anim.To = -360;
            blade41Anim.BeginTime = TimeSpan.FromSeconds(1);
            blade41Anim.Duration = TimeSpan.FromSeconds(0.3);
            blade41Anim.RepeatBehavior = RepeatBehavior.Forever;
            blade42Anim.From = 0;
            blade42Anim.To = -360;
            blade42Anim.BeginTime = TimeSpan.FromSeconds(1);
            blade42Anim.Duration = TimeSpan.FromSeconds(0.3);
            blade42Anim.RepeatBehavior = RepeatBehavior.Forever;

            //                                              Анимация Line0
            DoubleAnimationUsingKeyFrames anLine0 = new DoubleAnimationUsingKeyFrames();
            anLine0.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine0.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    25, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );


            //                                              Анимация Line1
            DoubleAnimationUsingKeyFrames anLine1 = new DoubleAnimationUsingKeyFrames();
            anLine1.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine1.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    40, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine1.BeginTime = TimeSpan.FromSeconds(0.3);


            //                                              Анимация Line2
            DoubleAnimationUsingKeyFrames anLine2 = new DoubleAnimationUsingKeyFrames();
            anLine2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine2.BeginTime = TimeSpan.FromSeconds(0.6);


            //                                              Анимация Line3
            DoubleAnimationUsingKeyFrames anLine3 = new DoubleAnimationUsingKeyFrames();
            anLine3.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine3.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    68, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine3.BeginTime = TimeSpan.FromSeconds(0.6);


            //                                              Анимация Line4
            DoubleAnimationUsingKeyFrames anLine4 = new DoubleAnimationUsingKeyFrames();
            anLine4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -46, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine4.BeginTime = TimeSpan.FromSeconds(3.3);

            //                                              Анимация Line5
            DoubleAnimationUsingKeyFrames anLine5 = new DoubleAnimationUsingKeyFrames();
            anLine5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -20, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine5.BeginTime = TimeSpan.FromSeconds(3.0);

            //                                              Анимация Line6
            DoubleAnimationUsingKeyFrames anLine6 = new DoubleAnimationUsingKeyFrames();
            anLine6.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine6.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine6.BeginTime = TimeSpan.FromSeconds(3.3);

            //                                              Анимация Line7
            DoubleAnimationUsingKeyFrames anLine7 = new DoubleAnimationUsingKeyFrames();
            anLine7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -14, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine7.BeginTime = TimeSpan.FromSeconds(2.7);

            //                                              Анимация Line8
            DoubleAnimationUsingKeyFrames anLine8 = new DoubleAnimationUsingKeyFrames();
            anLine8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -148, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine8.BeginTime = TimeSpan.FromSeconds(2.4);

            //                                              Анимация Line9
            DoubleAnimationUsingKeyFrames anLine9 = new DoubleAnimationUsingKeyFrames();
            anLine9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    56, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine9.BeginTime = TimeSpan.FromSeconds(2.7);

            //                                              Анимация Line10
            DoubleAnimationUsingKeyFrames anLine10 = new DoubleAnimationUsingKeyFrames();
            anLine10.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine10.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    14, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );


            //                                              Анимация Line11
            DoubleAnimationUsingKeyFrames anLine11 = new DoubleAnimationUsingKeyFrames();
            anLine11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    58, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine11.BeginTime = TimeSpan.FromSeconds(2.4);

            //                                              Анимация Line12
            DoubleAnimationUsingKeyFrames anLine12 = new DoubleAnimationUsingKeyFrames();
            anLine12.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine12.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    50, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line13
            DoubleAnimationUsingKeyFrames anLine13 = new DoubleAnimationUsingKeyFrames();
            anLine13.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine13.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    22, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line14
            DoubleAnimationUsingKeyFrames anLine14 = new DoubleAnimationUsingKeyFrames();
            anLine14.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine14.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    58, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line15
            DoubleAnimationUsingKeyFrames anLine15 = new DoubleAnimationUsingKeyFrames();
            anLine15.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine15.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    22, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line16
            DoubleAnimationUsingKeyFrames anLine16 = new DoubleAnimationUsingKeyFrames();
            anLine16.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine16.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    60, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line17
            DoubleAnimationUsingKeyFrames anLine17 = new DoubleAnimationUsingKeyFrames();
            anLine17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine17.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -58, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line18
            DoubleAnimationUsingKeyFrames anLine18 = new DoubleAnimationUsingKeyFrames();
            anLine18.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine18.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    43, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line19
            DoubleAnimationUsingKeyFrames anLine19 = new DoubleAnimationUsingKeyFrames();
            anLine19.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine19.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    18, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line20
            DoubleAnimationUsingKeyFrames anLine20 = new DoubleAnimationUsingKeyFrames();
            anLine20.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine20.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    54, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line21
            DoubleAnimationUsingKeyFrames anLine21 = new DoubleAnimationUsingKeyFrames();
            anLine21.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine21.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -56, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine21.BeginTime = TimeSpan.FromSeconds(0.9);

            //                                              Анимация Line22
            DoubleAnimationUsingKeyFrames anLine22 = new DoubleAnimationUsingKeyFrames();
            anLine22.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine22.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    160, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine22.BeginTime = TimeSpan.FromSeconds(0.6);

            //                                              Анимация Line23
            DoubleAnimationUsingKeyFrames anLine23 = new DoubleAnimationUsingKeyFrames();
            anLine23.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine23.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    8, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line24
            DoubleAnimationUsingKeyFrames anLine24 = new DoubleAnimationUsingKeyFrames();
            anLine24.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine24.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -8, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line25
            DoubleAnimationUsingKeyFrames anLine25 = new DoubleAnimationUsingKeyFrames();
            anLine25.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine25.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -57, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine25.BeginTime = TimeSpan.FromSeconds(0.6);

            //                                              Анимация Line26
            DoubleAnimationUsingKeyFrames anLine26 = new DoubleAnimationUsingKeyFrames();
            anLine26.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine26.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -60, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line27
            DoubleAnimationUsingKeyFrames anLine27 = new DoubleAnimationUsingKeyFrames();
            anLine27.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine27.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -58, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line28
            DoubleAnimationUsingKeyFrames anLine28 = new DoubleAnimationUsingKeyFrames();
            anLine28.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine28.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -22, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line29
            DoubleAnimationUsingKeyFrames anLine29 = new DoubleAnimationUsingKeyFrames();
            anLine29.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine29.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    22, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine29.BeginTime = TimeSpan.FromSeconds(0.3);

            //                                              Анимация Line30
            DoubleAnimationUsingKeyFrames anLine30 = new DoubleAnimationUsingKeyFrames();
            anLine30.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine30.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    50, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line31
            DoubleAnimationUsingKeyFrames anLine31 = new DoubleAnimationUsingKeyFrames();
            anLine31.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine31.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    58, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine31.BeginTime = TimeSpan.FromSeconds(0.3);

            //                                              Анимация Line32
            DoubleAnimationUsingKeyFrames anLine32 = new DoubleAnimationUsingKeyFrames();
            anLine32.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine32.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -58, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine32.BeginTime = TimeSpan.FromSeconds(0.3);

            //                                              Анимация Line33
            DoubleAnimationUsingKeyFrames anLine33 = new DoubleAnimationUsingKeyFrames();
            anLine33.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine33.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -375, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine33.BeginTime = TimeSpan.FromSeconds(1.2);

            //                                              Анимация Line34
            DoubleAnimationUsingKeyFrames anLine34 = new DoubleAnimationUsingKeyFrames();
            anLine34.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine34.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    66, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );

            //                                              Анимация Line35
            DoubleAnimationUsingKeyFrames anLine35 = new DoubleAnimationUsingKeyFrames();
            anLine35.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine35.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -133, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine35.BeginTime = TimeSpan.FromSeconds(1.5);

            //                                              Анимация Line36
            DoubleAnimationUsingKeyFrames anLine36 = new DoubleAnimationUsingKeyFrames();
            anLine36.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine36.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -28, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line37
            DoubleAnimationUsingKeyFrames anLine37 = new DoubleAnimationUsingKeyFrames();
            anLine37.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine37.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    92, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line38
            DoubleAnimationUsingKeyFrames anLine38 = new DoubleAnimationUsingKeyFrames();
            anLine38.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine38.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    15, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line39
            DoubleAnimationUsingKeyFrames anLine39 = new DoubleAnimationUsingKeyFrames();
            anLine39.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine39.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -46, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line40
            DoubleAnimationUsingKeyFrames anLine40 = new DoubleAnimationUsingKeyFrames();
            anLine40.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine40.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    50, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line41
            DoubleAnimationUsingKeyFrames anLine41 = new DoubleAnimationUsingKeyFrames();
            anLine41.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine41.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    58, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine41.BeginTime = TimeSpan.FromSeconds(2.1);

            //                                              Анимация Line42
            DoubleAnimationUsingKeyFrames anLine42 = new DoubleAnimationUsingKeyFrames();
            anLine42.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine42.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -229, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine42.BeginTime = TimeSpan.FromSeconds(1.8);

            //                                              Анимация Line43
            DoubleAnimationUsingKeyFrames anLine43 = new DoubleAnimationUsingKeyFrames();
            anLine43.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine43.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    262, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine43.BeginTime = TimeSpan.FromSeconds(0.9);

            //                                              Анимация Line44
            DoubleAnimationUsingKeyFrames anLine44 = new DoubleAnimationUsingKeyFrames();
            anLine44.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine44.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -276, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line45
            DoubleAnimationUsingKeyFrames anLine45 = new DoubleAnimationUsingKeyFrames();
            anLine45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            //                                              Анимация Line46
            DoubleAnimationUsingKeyFrames anLine46 = new DoubleAnimationUsingKeyFrames();
            anLine46.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine46.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -261, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine46.BeginTime = TimeSpan.FromSeconds(1.5);

            //                                              Анимация Line47
            DoubleAnimationUsingKeyFrames anLine47 = new DoubleAnimationUsingKeyFrames();
            anLine47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    227, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine47.BeginTime = TimeSpan.FromSeconds(1.2);

            //                                              Анимация Line48
            DoubleAnimationUsingKeyFrames anLine48 = new DoubleAnimationUsingKeyFrames();
            anLine48.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine48.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -56, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine48.BeginTime = TimeSpan.FromSeconds(1.2);

            //                                              Анимация Line49
            DoubleAnimationUsingKeyFrames anLine49 = new DoubleAnimationUsingKeyFrames();
            anLine49.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine49.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -36, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            anLine49.BeginTime = TimeSpan.FromSeconds(0.6);

            WaterVM.Lines.Add(line0);
            WaterVM.AnLines.Add(anLine0);
            WaterVM.Lines.Add(line1);
            WaterVM.AnLines.Add(anLine1);
            WaterVM.Lines.Add(line2);
            WaterVM.AnLines.Add(anLine2);
            WaterVM.Lines.Add(line3);
            WaterVM.AnLines.Add(anLine3);
            WaterVM.Lines.Add(line4);
            WaterVM.AnLines.Add(anLine4);
            WaterVM.Lines.Add(line5);
            WaterVM.AnLines.Add(anLine5);
            WaterVM.Lines.Add(line6);
            WaterVM.AnLines.Add(anLine6);
            WaterVM.Lines.Add(line7);
            WaterVM.AnLines.Add(anLine7);
            WaterVM.Lines.Add(line8);
            WaterVM.AnLines.Add(anLine8);
            WaterVM.Lines.Add(line9);
            WaterVM.AnLines.Add(anLine9);
            WaterVM.Lines.Add(line10);
            WaterVM.AnLines.Add(anLine10);
            WaterVM.Lines.Add(line11);
            WaterVM.AnLines.Add(anLine11);
            WaterVM.Lines.Add(line12);
            WaterVM.AnLines.Add(anLine12);
            WaterVM.Lines.Add(line13);
            WaterVM.AnLines.Add(anLine13);
            WaterVM.Lines.Add(line14);
            WaterVM.AnLines.Add(anLine14);
            WaterVM.Lines.Add(line15);
            WaterVM.AnLines.Add(anLine15);
            WaterVM.Lines.Add(line16);
            WaterVM.AnLines.Add(anLine16);
            WaterVM.Lines.Add(line17);
            WaterVM.AnLines.Add(anLine17);
            WaterVM.Lines.Add(line18);
            WaterVM.AnLines.Add(anLine18);
            WaterVM.Lines.Add(line19);
            WaterVM.AnLines.Add(anLine19);
            WaterVM.Lines.Add(line20);
            WaterVM.AnLines.Add(anLine20);
            WaterVM.Lines.Add(line21);
            WaterVM.AnLines.Add(anLine21);
            WaterVM.Lines.Add(line22);
            WaterVM.AnLines.Add(anLine22);
            WaterVM.Lines.Add(line23);
            WaterVM.AnLines.Add(anLine23);
            WaterVM.Lines.Add(line24);
            WaterVM.AnLines.Add(anLine24);
            WaterVM.Lines.Add(line25);
            WaterVM.AnLines.Add(anLine25);
            WaterVM.Lines.Add(line26);
            WaterVM.AnLines.Add(anLine26);
            WaterVM.Lines.Add(line27);
            WaterVM.AnLines.Add(anLine27);
            WaterVM.Lines.Add(line28);
            WaterVM.AnLines.Add(anLine28);
            WaterVM.Lines.Add(line29);
            WaterVM.AnLines.Add(anLine29);
            WaterVM.Lines.Add(line30);
            WaterVM.AnLines.Add(anLine30);
            WaterVM.Lines.Add(line31);
            WaterVM.AnLines.Add(anLine31);
            WaterVM.Lines.Add(line32);
            WaterVM.AnLines.Add(anLine32);
            WaterVM.Lines.Add(line33);
            WaterVM.AnLines.Add(anLine33);
            WaterVM.Lines.Add(line34);
            WaterVM.AnLines.Add(anLine34);
            WaterVM.Lines.Add(line35);
            WaterVM.AnLines.Add(anLine35);
            WaterVM.Lines.Add(line36);
            WaterVM.AnLines.Add(anLine36);
            WaterVM.Lines.Add(line37);
            WaterVM.AnLines.Add(anLine37);
            WaterVM.Lines.Add(line38);
            WaterVM.AnLines.Add(anLine38);
            WaterVM.Lines.Add(line39);
            WaterVM.AnLines.Add(anLine39);
            WaterVM.Lines.Add(line40);
            WaterVM.AnLines.Add(anLine40);
            WaterVM.Lines.Add(line41);
            WaterVM.AnLines.Add(anLine41);
            WaterVM.Lines.Add(line42);
            WaterVM.AnLines.Add(anLine42);
            WaterVM.Lines.Add(line43);
            WaterVM.AnLines.Add(anLine43);
            WaterVM.Lines.Add(line44);
            WaterVM.AnLines.Add(anLine44);
            WaterVM.Lines.Add(line45);
            WaterVM.AnLines.Add(anLine45);
            WaterVM.Lines.Add(line46);
            WaterVM.AnLines.Add(anLine46);
            WaterVM.Lines.Add(line47);
            WaterVM.AnLines.Add(anLine47);
            WaterVM.Lines.Add(line48);
            WaterVM.AnLines.Add(anLine48);
            WaterVM.Lines.Add(line49);
            WaterVM.AnLines.Add(anLine49);
            WaterVM.FillUp();

            // Линии для циркуляции
            //                                              Анимация Line0a2
            DoubleAnimationUsingKeyFrames anLine0a2 = new DoubleAnimationUsingKeyFrames();
            anLine0a2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine0a2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -114, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line1a5
            DoubleAnimationUsingKeyFrames anLine1a5 = new DoubleAnimationUsingKeyFrames();
            anLine1a5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine1a5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line2a7
            DoubleAnimationUsingKeyFrames anLine2a7 = new DoubleAnimationUsingKeyFrames();
            anLine2a7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine2a7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -164, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line3a11
            DoubleAnimationUsingKeyFrames anLine3a11 = new DoubleAnimationUsingKeyFrames();
            anLine3a11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine3a11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -59, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line4a20
            DoubleAnimationUsingKeyFrames anLine4a20 = new DoubleAnimationUsingKeyFrames();
            anLine4a20.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine4a20.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -95, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line5a21
            DoubleAnimationUsingKeyFrames anLine5a21 = new DoubleAnimationUsingKeyFrames();
            anLine5a21.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine5a21.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line6a22
            DoubleAnimationUsingKeyFrames anLine6a22 = new DoubleAnimationUsingKeyFrames();
            anLine6a22.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine6a22.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    160, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line7a33
            DoubleAnimationUsingKeyFrames anLine7a33 = new DoubleAnimationUsingKeyFrames();
            anLine7a33.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine7a33.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    489, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line8a35
            DoubleAnimationUsingKeyFrames anLine8a35 = new DoubleAnimationUsingKeyFrames();
            anLine8a35.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine8a35.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    134, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line9a36
            DoubleAnimationUsingKeyFrames anLine9a36 = new DoubleAnimationUsingKeyFrames();
            anLine9a36.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine9a36.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    29, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line10a37
            DoubleAnimationUsingKeyFrames anLine10a37 = new DoubleAnimationUsingKeyFrames();
            anLine10a37.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine10a37.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -89, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line11a47
            DoubleAnimationUsingKeyFrames anLine11a47 = new DoubleAnimationUsingKeyFrames();
            anLine11a47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine11a47.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    45, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line12a46
            DoubleAnimationUsingKeyFrames anLine12a46 = new DoubleAnimationUsingKeyFrames();
            anLine12a46.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine12a46.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    77, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line13a45
            DoubleAnimationUsingKeyFrames anLine13a45 = new DoubleAnimationUsingKeyFrames();
            anLine13a45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine13a45.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -174, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line14a44
            DoubleAnimationUsingKeyFrames anLine14a44 = new DoubleAnimationUsingKeyFrames();
            anLine14a44.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine14a44.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    276, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line15a43
            DoubleAnimationUsingKeyFrames anLine15a43 = new DoubleAnimationUsingKeyFrames();
            anLine15a43.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine15a43.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -415, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );
            //                                              Анимация Line16a42
            DoubleAnimationUsingKeyFrames anLine16a42 = new DoubleAnimationUsingKeyFrames();
            anLine16a42.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine16a42.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -153, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2/*была 1*/))) // KeyTime
                );


            CirculationVM.CircLines.Add(line0a2);
            CirculationVM.CircAnLines.Add(anLine0a2);
            CirculationVM.CircLines.Add(line1a5);
            CirculationVM.CircAnLines.Add(anLine1a5);
            CirculationVM.CircLines.Add(line2a7);
            CirculationVM.CircAnLines.Add(anLine2a7);
            CirculationVM.CircLines.Add(line3a11);
            CirculationVM.CircAnLines.Add(anLine3a11);
            CirculationVM.CircLines.Add(line4a20);
            CirculationVM.CircAnLines.Add(anLine4a20);
            CirculationVM.CircLines.Add(line5a21);
            CirculationVM.CircAnLines.Add(anLine5a21);
            CirculationVM.CircLines.Add(line6a22);
            CirculationVM.CircAnLines.Add(anLine6a22);
            CirculationVM.CircLines.Add(line7a33);
            CirculationVM.CircAnLines.Add(anLine7a33);
            CirculationVM.CircLines.Add(line8a35);
            CirculationVM.CircAnLines.Add(anLine8a35);
            CirculationVM.CircLines.Add(line9a36);
            CirculationVM.CircAnLines.Add(anLine9a36);
            CirculationVM.CircLines.Add(line10a37);
            CirculationVM.CircAnLines.Add(anLine10a37);
            CirculationVM.CircLines.Add(line11a47);
            CirculationVM.CircAnLines.Add(anLine11a47);
            CirculationVM.CircLines.Add(line12a46);
            CirculationVM.CircAnLines.Add(anLine12a46);
            CirculationVM.CircLines.Add(line13a45);
            CirculationVM.CircAnLines.Add(anLine13a45);
            CirculationVM.CircLines.Add(line14a44);
            CirculationVM.CircAnLines.Add(anLine14a44);
            CirculationVM.CircLines.Add(line15a43);
            CirculationVM.CircAnLines.Add(anLine15a43);
            CirculationVM.CircLines.Add(line16a42);
            CirculationVM.CircAnLines.Add(anLine16a42);



        }
    }
}