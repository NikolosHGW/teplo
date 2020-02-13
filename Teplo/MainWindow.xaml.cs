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
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))) // KeyTime
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
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))) // KeyTime
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
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))) // KeyTime
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
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))) // KeyTime
                );
            AnimationVM.Lin3 = lin3;
            AnimationVM.Line3 = line3;
        }
    }
}