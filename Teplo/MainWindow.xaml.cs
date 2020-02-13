using Core;
using System;
using System.Windows;
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

            //                                              Анимация Line0
            DoubleAnimationUsingKeyFrames lin0 = new DoubleAnimationUsingKeyFrames();
            lin0.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin0.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    25, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3/*была 1*/))) // KeyTime
                );
            AnimationVM.Lin0 = lin0;
            AnimationVM.Line0 = line0;


            //                                              Анимация Line1
            DoubleAnimationUsingKeyFrames lin1 = new DoubleAnimationUsingKeyFrames();
            lin1.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin1.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    40, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin1 = lin1;
            AnimationVM.Line1 = line1;


            //                                              Анимация Line2
            DoubleAnimationUsingKeyFrames lin2 = new DoubleAnimationUsingKeyFrames();
            lin2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin2.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    -65, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin2 = lin2;
            AnimationVM.Line2 = line2;


            //                                              Анимация Line3
            DoubleAnimationUsingKeyFrames lin3 = new DoubleAnimationUsingKeyFrames();
            lin3.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin3.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    68, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin3 = lin3;
            AnimationVM.Line3 = line3;


            //                                              Анимация Line4
            DoubleAnimationUsingKeyFrames lin4 = new DoubleAnimationUsingKeyFrames();
            lin4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    46, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin4 = lin4;
            AnimationVM.Line4 = line4;


            //                                              Анимация Line5
            DoubleAnimationUsingKeyFrames lin5 = new DoubleAnimationUsingKeyFrames();
            lin5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    20, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin5 = lin5;
            AnimationVM.Line5 = line5;


            //                                              Анимация Line6
            DoubleAnimationUsingKeyFrames lin6 = new DoubleAnimationUsingKeyFrames();
            lin6.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin6.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin6 = lin6;
            AnimationVM.Line6 = line6;


            //                                              Анимация Line7
            DoubleAnimationUsingKeyFrames lin7 = new DoubleAnimationUsingKeyFrames();
            lin7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    14, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin7 = lin7;
            AnimationVM.Line7 = line7;


            //                                              Анимация Line8
            DoubleAnimationUsingKeyFrames lin8 = new DoubleAnimationUsingKeyFrames();
            lin8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    148, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin8 = lin8;
            AnimationVM.Line8 = line8;


            //                                              Анимация Line9
            DoubleAnimationUsingKeyFrames lin9 = new DoubleAnimationUsingKeyFrames();
            lin9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin9 = lin9;
            AnimationVM.Line9 = line9;


            //                                              Анимация Line10
            DoubleAnimationUsingKeyFrames lin10 = new DoubleAnimationUsingKeyFrames();
            lin10.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin10.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    14, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin10 = lin10;
            AnimationVM.Line10 = line10;


            //                                              Анимация Line11
            DoubleAnimationUsingKeyFrames lin11 = new DoubleAnimationUsingKeyFrames();
            lin11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            lin11.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
            AnimationVM.Lin11 = lin11;
            AnimationVM.Line11 = line11;
        }
    }
}