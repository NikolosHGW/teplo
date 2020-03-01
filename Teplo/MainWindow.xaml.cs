using Core;
using System;
using System.Collections.ObjectModel;
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


            //                                              Анимация Line4
            DoubleAnimationUsingKeyFrames anLine4 = new DoubleAnimationUsingKeyFrames();
            anLine4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine4.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    46, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );


            //                                              Анимация Line5
            DoubleAnimationUsingKeyFrames anLine5 = new DoubleAnimationUsingKeyFrames();
            anLine5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine5.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    20, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );


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


            //                                              Анимация Line7
            DoubleAnimationUsingKeyFrames anLine7 = new DoubleAnimationUsingKeyFrames();
            anLine7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine7.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    14, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );


            //                                              Анимация Line8
            DoubleAnimationUsingKeyFrames anLine8 = new DoubleAnimationUsingKeyFrames();
            anLine8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine8.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    148, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );


            //                                              Анимация Line9
            DoubleAnimationUsingKeyFrames anLine9 = new DoubleAnimationUsingKeyFrames();
            anLine9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))) // KeyTime
                );
            anLine9.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );


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
                    55, // Target value (KeyValue)
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3))) // KeyTime
                );
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

            LineVM.Lines.Add(line0);
            LineVM.AnLines.Add(anLine0);
            LineVM.Lines.Add(line1);
            LineVM.AnLines.Add(anLine1);
            LineVM.Lines.Add(line2);
            LineVM.AnLines.Add(anLine2);
            LineVM.Lines.Add(line3);
            LineVM.AnLines.Add(anLine3);
            LineVM.Lines.Add(line4);
            LineVM.AnLines.Add(anLine4);
            LineVM.Lines.Add(line5);
            LineVM.AnLines.Add(anLine5);
            LineVM.Lines.Add(line6);
            LineVM.AnLines.Add(anLine6);
            LineVM.Lines.Add(line7);
            LineVM.AnLines.Add(anLine7);
            LineVM.Lines.Add(line8);
            LineVM.AnLines.Add(anLine8);
            LineVM.Lines.Add(line9);
            LineVM.AnLines.Add(anLine9);
            LineVM.Lines.Add(line10);
            LineVM.AnLines.Add(anLine10);
            LineVM.Lines.Add(line11);
            LineVM.AnLines.Add(anLine11);
            LineVM.Lines.Add(line12);
            LineVM.AnLines.Add(anLine12);
            LineVM.Lines.Add(line13);
            LineVM.AnLines.Add(anLine13);
            LineVM.Lines.Add(line14);
            LineVM.AnLines.Add(anLine14);
            //LineVM.Lines.Add(line15);
            //LineVM.Lines.Add(line16);
            //LineVM.Lines.Add(line17);
            //LineVM.Lines.Add(line18);
            //LineVM.Lines.Add(line19);
            //LineVM.Lines.Add(line20);
            //LineVM.Lines.Add(line21);
            //LineVM.Lines.Add(line22);
            //LineVM.Lines.Add(line23);
            //LineVM.Lines.Add(line24);
            //LineVM.Lines.Add(line25);
            //LineVM.Lines.Add(line26);
            //LineVM.Lines.Add(line27);
            //LineVM.Lines.Add(line28);
            //LineVM.Lines.Add(line29);
            //LineVM.Lines.Add(line30);
            //LineVM.Lines.Add(line31);
            //LineVM.Lines.Add(line32);
            //LineVM.Lines.Add(line33);
            //LineVM.Lines.Add(line34);
            //LineVM.Lines.Add(line35);
        }
    }
}