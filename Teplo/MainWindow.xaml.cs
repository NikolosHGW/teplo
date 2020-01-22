using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Teplo;

namespace Teplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game Game { get; set; } = new Game();
        private int circ = 0;
        public MainWindow()
        {
            InitializeComponent();

            Game.Pump.StateChanged += UpdatePumpPicture;
            Game.Pump2.StateChanged += UpdatePump2Picture;
            Game.Valve1.StateChanged += UpdateValve1Picture;
            Game.Valve2.StateChanged += UpdateValve2Picture;
            Game.Valve3.StateChanged += UpdateValve3Picture;
            Game.Valve4.StateChanged += UpdateValve4Picture;
            Game.Valve5.StateChanged += UpdateValve5Picture;
            Game.Valve6.StateChanged += UpdateValve6Picture;
            Game.Valve7.StateChanged += UpdateValve7Picture;
            Game.Valve8.StateChanged += UpdateValve8Picture;
            Game.Valve9.StateChanged += UpdateValve9Picture;
            Game.Valve10.StateChanged += UpdateValve10Picture;
            Game.Valve11.StateChanged += UpdateValve11Picture;
            Game.Valve12.StateChanged += UpdateValve12Picture;
            Game.Valve13.StateChanged += UpdateValve13Picture;
            Game.Valve14.StateChanged += UpdateValve14Picture;
            Game.Valve15.StateChanged += UpdateValve15Picture;
            Game.Valve16.StateChanged += UpdateValve16Picture;
            Game.Valve17.StateChanged += UpdateValve17Picture;
            Game.Valve18.StateChanged += UpdateValve18Picture;
            Game.Valve19.StateChanged += UpdateValve19Picture;
            Game.Valve20.StateChanged += UpdateValve20Picture;
            Game.Valve21.StateChanged += UpdateValve21Picture;
            Game.Valve22.StateChanged += UpdateValve22Picture;
            Game.Valve23.StateChanged += UpdateValve23Picture;
            Game.Valve24.StateChanged += UpdateValve24Picture;
            Game.Valve25.StateChanged += UpdateValve25Picture;
            Game.Valve26.StateChanged += UpdateValve26Picture;
            Game.Valve27.StateChanged += UpdateValve27Picture;
            Game.Valve28.StateChanged += UpdateValve28Picture;
            Game.Valve29.StateChanged += UpdateValve29Picture;

            //Game.SubscribeOnPumpChanged(ShowMessage);
        }

        //private void ShowMessage(bool pumpState)
        //{
        //    MessageBox.Show("Pump is now " + pumpState);
        //}


        //                                 СВАП КАРТИНКИ
        private void UpdatePumpPicture(bool pumpState)
        {
            if (pumpState) // pumpState == true
            {
                pumpImage.Source = new BitmapImage(new Uri(@"Resources/nasos_green.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                pumpImage.Source = new BitmapImage(new Uri(@"Resources/nasos.png", UriKind.Relative));
            }
        }

        private void UpdatePump2Picture(bool pumpState2)
        {
            if (pumpState2) // pumpState == true
            {
                pump2Image.Source = new BitmapImage(new Uri(@"Resources/nasos_green.png", UriKind.Relative));
                if (Game.Valve2.IsActive == true && Game.Valve16.IsActive == true && Game.Valve17.IsActive == true && line26.Opacity == 1 && Game.Valve5.IsActive == false)
                {
                    //2
                    circ += 1;
                }
            }
            else // pumpState == false
            {
                pump2Image.Source = new BitmapImage(new Uri(@"Resources/nasos.png", UriKind.Relative));
            }
        }

        private void UpdateValve1Picture(bool valveState1)
        {
            if (valveState1) // pumpState == true
            {
                valveImage1.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                if (Game.Pump.IsActive == true && Game.Valve3.IsActive == true && Game.Valve11.IsActive == true && Game.Valve20.IsActive == true && Game.Valve21.IsActive == true && Game.Valve2.IsActive == false && Game.Valve6.IsActive == false && Game.Valve14.IsActive == false && Game.Valve19.IsActive == false && Game.Valve22.IsActive == false)
                {
                    line1.Opacity = 1;
                    line2.Opacity = 1;
                    line3.Opacity = 1;
                    line4.Opacity = 1;
                    line5.Opacity = 1;
                    line6.Opacity = 1;
                    line7.Opacity = 1;
                    line8.Opacity = 1;
                    line9.Opacity = 1;
                    line10.Opacity = 1;
                    line13.Opacity = 1;
                    line14.Opacity = 1;
                    line15.Opacity = 1;
                }
            }
            else // pumpState == false
            {
                valveImage1.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve2Picture(bool valveState2)
        {
            if (valveState2) // pumpState == true
            {
                valveImage2.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                if (Game.Valve16.IsActive == true && Game.Valve17.IsActive == true && line26.Opacity == 1 && Game.Valve5.IsActive == false && Game.Pump2.IsActive == false)
                {
                    //1
                    circ += 1;
                }
            }
            else // pumpState == false
            {
                valveImage2.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve3Picture(bool valveState3)
        {
            if (valveState3) // pumpState == true
            {
                valveImage3.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage3.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve4Picture(bool valveState4)
        {
            if (valveState4) // pumpState == true
            {
                valveImage4.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage4.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve5Picture(bool valveState5)
        {
            if (valveState5) // pumpState == true
            {
                valveImage5.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                if (Game.Valve2.IsActive == true && Game.Valve16.IsActive == true && Game.Valve17.IsActive == true && line26.Opacity == 1 && Game.Pump2.IsActive == true)
                {
                    //3
                    circ += 1;
                }
            }
            else // pumpState == false
            {
                valveImage5.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve6Picture(bool valveState6)
        {
            if (valveState6) // pumpState == true
            {
                valveImage6.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage6.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve7Picture(bool valveState7)
        {
            if (valveState7) // pumpState == true
            {
                valveImage7.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage7.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve8Picture(bool valveState8)
        {
            if (valveState8) // pumpState == true
            {
                valveImage8.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage8.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve9Picture(bool valveState9)
        {
            if (valveState9) // pumpState == true
            {
                valveImage9.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage9.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve10Picture(bool valveState10)
        {
            if (valveState10) // pumpState == true
            {
                valveImage10.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage10.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve11Picture(bool valveState11)
        {
            if (valveState11) // pumpState == true
            {
                valveImage11.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage11.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve12Picture(bool valveState12)
        {
            if (valveState12) // pumpState == true
            {
                valveImage12.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage12.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve13Picture(bool valveState13)
        {
            if (valveState13) // pumpState == true
            {
                valveImage13.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage13.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve14Picture(bool valveState14)
        {
            if (valveState14) // pumpState == true
            {
                valveImage14.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                if (Game.Valve9.IsActive == false && Game.Valve1.IsActive == true && line7.Opacity == 1)
                {
                    line16.Opacity = 1;
                    line18.Opacity = 1;
                }
                if (Game.Valve9.IsActive == true && line7.Opacity == 1 && Game.Valve6.IsActive == false && Game.Valve12.IsActive == false && Game.Valve22.IsActive == false)
                {
                    line12.Opacity = 1;
                    line16.Opacity = 1;
                    line18.Opacity = 1;
                    line20.Opacity = 1;
                    line23.Opacity = 1;
                }
            }
            else // pumpState == false
            {
                valveImage14.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve15Picture(bool valveState15)
        {
            if (valveState15) // pumpState == true
            {
                valveImage15.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage15.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve16Picture(bool valveState16)
        {
            if (valveState16) // pumpState == true
            {
                valveImage16.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage16.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve17Picture(bool valveState17)
        {
            if (valveState17) // pumpState == true
            {
                valveImage17.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                if (Game.Valve16.IsActive == true && line25.Opacity == 1)
                {
                    line26.Opacity = 1;
                    line27.Opacity = 1;
                }
            }
            else // pumpState == false
            {
                valveImage17.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve18Picture(bool valveState18)
        {
            if (valveState18) // pumpState == true
            {
                valveImage18.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage18.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve19Picture(bool valveState19)
        {
            if (valveState19) // pumpState == true
            {
                valveImage19.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                if (Game.Valve11.IsActive == true && line9.Opacity == 1 && line12.Opacity == 1 && Game.Valve20.IsActive == false && Game.Valve21.IsActive == false && Game.Valve22.IsActive == false)
                {
                    line9.Opacity = 0;
                    line10.Opacity = 0;
                    line14.Opacity = 0;
                    line15.Opacity = 0;
                }
            }
            else // pumpState == false
            {
                valveImage19.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve20Picture(bool valveState20)
        {
            if (valveState20) // pumpState == true
            {
                valveImage20.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                //if (Game.Valve11.IsActive == true)
                //{
                //    l2line9.Opacity = 1;
                //    l2line10.Opacity = 1;
                //}
            }
            else // pumpState == false
            {
                valveImage20.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve21Picture(bool valveState21)
        {
            if (valveState21) // pumpState == true
            {
                valveImage21.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage21.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve22Picture(bool valveState22)
        {
            if (valveState22) // pumpState == true
            {
                valveImage22.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
                if (Game.Valve4.IsActive == true && Game.Valve11.IsActive == true && Game.Valve19.IsActive == true && line12.Opacity == 1 && Game.Valve17.IsActive == false && Game.Valve20.IsActive == false && Game.Valve21.IsActive == false)
                {
                    line11.Opacity = 1;
                    line24.Opacity = 1;
                    line25.Opacity = 1;
                    line9.Opacity = 1;
                    line10.Opacity = 1;
                    line14.Opacity = 1;
                    line15.Opacity = 1;
                }
            }
            else // pumpState == false
            {
                valveImage22.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve23Picture(bool valveState23)
        {
            if (valveState23) // pumpState == true
            {
                valveImage23.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage23.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve24Picture(bool valveState24)
        {
            if (valveState24) // pumpState == true
            {
                valveImage24.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage24.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve25Picture(bool valveState25)
        {
            if (valveState25) // pumpState == true
            {
                valveImage25.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage25.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve26Picture(bool valveState26)
        {
            if (valveState26) // pumpState == true
            {
                valveImage26.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage26.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve27Picture(bool valveState27)
        {
            if (valveState27) // pumpState == true
            {
                valveImage27.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage27.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve28Picture(bool valveState28)
        {
            if (valveState28) // pumpState == true
            {
                valveImage28.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage28.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }
        private void UpdateValve29Picture(bool valveState29)
        {
            if (valveState29) // pumpState == true
            {
                valveImage29.Source = new BitmapImage(new Uri(@"Resources/valveOPN.png", UriKind.Relative));
            }
            else // pumpState == false
            {
                valveImage29.Source = new BitmapImage(new Uri(@"Resources/valveCLS.png", UriKind.Relative));
            }
        }

        //                                 КНОПКИ

        private void Button_Click(object sender, RoutedEventArgs e) => Game.Pump.ToggleState();

        private void Button_Click2(object sender, RoutedEventArgs e) => Game.Pump2.ToggleState();

        private void Button_ClickValve1(object sender, RoutedEventArgs e) => Game.Valve1.ToggleState();

        private void Button_ClickValve2(object sender, RoutedEventArgs e) => Game.Valve2.ToggleState();

        private void Button_ClickValve3(object sender, RoutedEventArgs e) => Game.Valve3.ToggleState();

        private void Button_ClickValve4(object sender, RoutedEventArgs e) => Game.Valve4.ToggleState();

        private void Button_ClickValve5(object sender, RoutedEventArgs e) => Game.Valve5.ToggleState();

        private void Button_ClickValve6(object sender, RoutedEventArgs e) => Game.Valve6.ToggleState();

        private void Button_ClickValve7(object sender, RoutedEventArgs e) => Game.Valve7.ToggleState();

        private void Button_ClickValve8(object sender, RoutedEventArgs e) => Game.Valve8.ToggleState();

        private void Button_ClickValve9(object sender, RoutedEventArgs e) => Game.Valve9.ToggleState();

        private void Button_ClickValve10(object sender, RoutedEventArgs e) => Game.Valve10.ToggleState();

        private void Button_ClickValve11(object sender, RoutedEventArgs e) => Game.Valve11.ToggleState();

        private void Button_ClickValve12(object sender, RoutedEventArgs e) => Game.Valve12.ToggleState();

        private void Button_ClickValve13(object sender, RoutedEventArgs e) => Game.Valve13.ToggleState();

        private void Button_ClickValve14(object sender, RoutedEventArgs e) => Game.Valve14.ToggleState();

        private void Button_ClickValve15(object sender, RoutedEventArgs e) => Game.Valve15.ToggleState();

        private void Button_ClickValve16(object sender, RoutedEventArgs e) => Game.Valve16.ToggleState();

        private void Button_ClickValve17(object sender, RoutedEventArgs e) => Game.Valve17.ToggleState();

        private void Button_ClickValve18(object sender, RoutedEventArgs e) => Game.Valve18.ToggleState();

        private void Button_ClickValve19(object sender, RoutedEventArgs e) => Game.Valve19.ToggleState();

        private void Button_ClickValve20(object sender, RoutedEventArgs e) => Game.Valve20.ToggleState();

        private void Button_ClickValve21(object sender, RoutedEventArgs e) => Game.Valve21.ToggleState();

        private void Button_ClickValve22(object sender, RoutedEventArgs e) => Game.Valve22.ToggleState();

        private void Button_ClickValve23(object sender, RoutedEventArgs e) => Game.Valve23.ToggleState();
        private void Button_ClickValve24(object sender, RoutedEventArgs e) => Game.Valve24.ToggleState();

        private void Button_ClickValve25(object sender, RoutedEventArgs e) => Game.Valve25.ToggleState();
        private void Button_ClickValve26(object sender, RoutedEventArgs e) => Game.Valve26.ToggleState();
        private void Button_ClickValve27(object sender, RoutedEventArgs e) => Game.Valve27.ToggleState();

        private void Button_ClickValve28(object sender, RoutedEventArgs e) => Game.Valve28.ToggleState();
        private void Button_ClickValve29(object sender, RoutedEventArgs e) => Game.Valve29.ToggleState();
        private void Button_Info(object sender, RoutedEventArgs e)
        {
            ViewModelINFO infoshka = (ViewModelINFO)this.Resources["abc"];
            if (infoshka.Opa == 0)
                infoshka.Opa = 1;
            else
                infoshka.Opa = 0;
        }
    }
}
