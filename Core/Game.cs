using System;
using System.Collections.Generic;

namespace Core
{
    public class Game
    {
        public Game()
        {
        }

        // callback -- это функция, которую мы хотим сохранить в списке
        //Game.SubscribeOnPumpChanged(UpdatePumpPicture);
        //private void UpdatePumpPicture(bool pumpState)
        //{
        //    if (pumpState) // pumpState == true
        //    {
        //        pumpImage.Source = new BitmapImage(new Uri(@"Resources/nasos_green.png", UriKind.Relative));
        //    }
        //    else // pumpState == false
        //    {
        //        pumpImage.Source = new BitmapImage(new Uri(@"Resources/nasos.png", UriKind.Relative));
        //    }
        //}


        //                                 ПОДПИСКА НА ИЗМЕНЕНИЕ; ДОБАВЛЕНИЕ ФУНКЦИИ В СПИСОК
        public void SubscribeOnPumpChanged(Action<bool> callback)
        {
            Callbacks.Add(callback);
        }

        public void SubscribeOnPump2Changed(Action<bool> callback2)
        {
            Callbacks2.Add(callback2);
        }
        public void SubscribeOnValve1Changed(Action<bool> callbackv1)
        {
            Callbacksv1.Add(callbackv1);
        }
        public void SubscribeOnValve2Changed(Action<bool> callbackv2)
        {
            Callbacksv2.Add(callbackv2);
        }
        public void SubscribeOnValve3Changed(Action<bool> callbackv3)
        {
            Callbacksv3.Add(callbackv3);
        }
        public void SubscribeOnValve4Changed(Action<bool> callbackv4)
        {
            Callbacksv4.Add(callbackv4);
        }
        public void SubscribeOnValve5Changed(Action<bool> callbackv5)
        {
            Callbacksv5.Add(callbackv5);
        }
        public void SubscribeOnValve6Changed(Action<bool> callbackv6)
        {
            Callbacksv6.Add(callbackv6);
        }
        public void SubscribeOnValve7Changed(Action<bool> callbackv7)
        {
            Callbacksv7.Add(callbackv7);
        }
        public void SubscribeOnValve8Changed(Action<bool> callbackv8)
        {
            Callbacksv8.Add(callbackv8);
        }
        public void SubscribeOnValve9Changed(Action<bool> callbackv9)
        {
            Callbacksv9.Add(callbackv9);
        }
        public void SubscribeOnValve10Changed(Action<bool> callbackv10)
        {
            Callbacksv10.Add(callbackv10);
        }
        public void SubscribeOnValve11Changed(Action<bool> callbackv11)
        {
            Callbacksv11.Add(callbackv11);
        }
        public void SubscribeOnValve12Changed(Action<bool> callbackv12)
        {
            Callbacksv12.Add(callbackv12);
        }
        public void SubscribeOnValve13Changed(Action<bool> callbackv13)
        {
            Callbacksv13.Add(callbackv13);
        }
        public void SubscribeOnValve14Changed(Action<bool> callbackv14)
        {
            Callbacksv14.Add(callbackv14);
        }
        public void SubscribeOnValve15Changed(Action<bool> callbackv15)
        {
            Callbacksv15.Add(callbackv15);
        }
        public void SubscribeOnValve16Changed(Action<bool> callbackv16)
        {
            Callbacksv16.Add(callbackv16);
        }
        public void SubscribeOnValve17Changed(Action<bool> callbackv17)
        {
            Callbacksv17.Add(callbackv17);
        }
        public void SubscribeOnValve18Changed(Action<bool> callbackv18)
        {
            Callbacksv18.Add(callbackv18);
        }
        public void SubscribeOnValve19Changed(Action<bool> callbackv19)
        {
            Callbacksv19.Add(callbackv19);
        }
        public void SubscribeOnValve20Changed(Action<bool> callbackv20)
        {
            Callbacksv20.Add(callbackv20);
        }
        public void SubscribeOnValve21Changed(Action<bool> callbackv21)
        {
            Callbacksv21.Add(callbackv21);
        }
        public void SubscribeOnValve22Changed(Action<bool> callbackv22)
        {
            Callbacksv22.Add(callbackv22);
        }
        public void SubscribeOnValve23Changed(Action<bool> callbackv23)
        {
            Callbacksv23.Add(callbackv23);
        }
        public void SubscribeOnValve24Changed(Action<bool> callbackv24)
        {
            Callbacksv24.Add(callbackv24);
        }
        public void SubscribeOnValve25Changed(Action<bool> callbackv25)
        {
            Callbacksv25.Add(callbackv25);
        }
        public void SubscribeOnValve26Changed(Action<bool> callbackv26)
        {
            Callbacksv26.Add(callbackv26);
        }
        public void SubscribeOnValve27Changed(Action<bool> callbackv27)
        {
            Callbacksv27.Add(callbackv27);
        }
        public void SubscribeOnValve28Changed(Action<bool> callbackv28)
        {
            Callbacksv28.Add(callbackv28);
        }
        public void SubscribeOnValve29Changed(Action<bool> callbackv29)
        {
            Callbacksv29.Add(callbackv29);
        }

        //                                 ПЕРЕКЛЮЧАТЕЛЬ(ТУМБЛЕР) ТРУ|ФОЛС
        public void TogglePumpState()
        {
            // перключение состояния насоса: True -> False -> True -> False -> ...
            Pump.IsActive = !Pump.IsActive;

            //if (Pump.IsActive == true)
            //    Pump.IsActive = false;
            //else
            //    Pump.IsActive = true;

            // Action - какая-то функция
            // Action<bool> - не какая-то функция, а функция, которая принимает аргумент типа bool
            // Action<bool>[] - массив таких фукнций
            // List<Action<bool>> - список таких функций

            //Action<bool>[] callbacksArray = callbacks.ToArray();

            //for (int i = 0; i < callbacksArray.Length; i++)
            //{
            //    callbacksArray[i](Pump.IsActive);
            //}

            foreach (var callback in Callbacks)
            {
                callback(Pump.IsActive);
            }
        }

        public void TogglePump2State()
        {
            Pump2.IsActive = !Pump2.IsActive;

            foreach (var callback2 in Callbacks2)
            {
                callback2(Pump2.IsActive);
            }
        }
        public void ToggleValve1State()
        {
            PumpV1.IsActive = !PumpV1.IsActive;

            foreach (var callbackv1 in Callbacksv1)
            {
                callbackv1(PumpV1.IsActive);
            }
        }
        public void ToggleValve2State()
        {
            PumpV2.IsActive = !PumpV2.IsActive;

            foreach (var callbackv2 in Callbacksv2)
            {
                callbackv2(PumpV2.IsActive);
            }
        }
        public void ToggleValve3State()
        {
            PumpV3.IsActive = !PumpV3.IsActive;

            foreach (var callbackv3 in Callbacksv3)
            {
                callbackv3(PumpV3.IsActive);
            }
        }
        public void ToggleValve4State()
        {
            PumpV4.IsActive = !PumpV4.IsActive;

            foreach (var callbackv4 in Callbacksv4)
            {
                callbackv4(PumpV4.IsActive);
            }
        }
        public void ToggleValve5State()
        {
            PumpV5.IsActive = !PumpV5.IsActive;

            foreach (var callbackv5 in Callbacksv5)
            {
                callbackv5(PumpV5.IsActive);
            }
        }
        public void ToggleValve6State()
        {
            PumpV6.IsActive = !PumpV6.IsActive;

            foreach (var callbackv6 in Callbacksv6)
            {
                callbackv6(PumpV6.IsActive);
            }
        }
        public void ToggleValve7State()
        {
            PumpV7.IsActive = !PumpV7.IsActive;

            foreach (var callbackv7 in Callbacksv7)
            {
                callbackv7(PumpV7.IsActive);
            }
        }
        public void ToggleValve8State()
        {
            PumpV8.IsActive = !PumpV8.IsActive;

            foreach (var callbackv8 in Callbacksv8)
            {
                callbackv8(PumpV8.IsActive);
            }
        }
        public void ToggleValve9State()
        {
            PumpV9.IsActive = !PumpV9.IsActive;

            foreach (var callbackv9 in Callbacksv9)
            {
                callbackv9(PumpV9.IsActive);
            }
        }
        public void ToggleValve10State()
        {
            PumpV10.IsActive = !PumpV10.IsActive;

            foreach (var callbackv10 in Callbacksv10)
            {
                callbackv10(PumpV10.IsActive);
            }
        }
        public void ToggleValve11State()
        {
            PumpV11.IsActive = !PumpV11.IsActive;

            foreach (var callbackv11 in Callbacksv11)
            {
                callbackv11(PumpV11.IsActive);
            }
        }
        public void ToggleValve12State()
        {
            PumpV12.IsActive = !PumpV12.IsActive;

            foreach (var callbackv12 in Callbacksv12)
            {
                callbackv12(PumpV12.IsActive);
            }
        }
        public void ToggleValve13State()
        {
            PumpV13.IsActive = !PumpV13.IsActive;

            foreach (var callbackv13 in Callbacksv13)
            {
                callbackv13(PumpV13.IsActive);
            }
        }
        public void ToggleValve14State()
        {
            PumpV14.IsActive = !PumpV14.IsActive;

            foreach (var callbackv14 in Callbacksv14)
            {
                callbackv14(PumpV14.IsActive);
            }
        }
        public void ToggleValve15State()
        {
            PumpV15.IsActive = !PumpV15.IsActive;

            foreach (var callbackv15 in Callbacksv15)
            {
                callbackv15(PumpV15.IsActive);
            }
        }
        public void ToggleValve16State()
        {
            PumpV16.IsActive = !PumpV16.IsActive;

            foreach (var callbackv16 in Callbacksv16)
            {
                callbackv16(PumpV16.IsActive);
            }
        }
        public void ToggleValve17State()
        {
            PumpV17.IsActive = !PumpV17.IsActive;

            foreach (var callbackv17 in Callbacksv17)
            {
                callbackv17(PumpV17.IsActive);
            }
        }
        public void ToggleValve18State()
        {
            PumpV18.IsActive = !PumpV18.IsActive;

            foreach (var callbackv18 in Callbacksv18)
            {
                callbackv18(PumpV18.IsActive);
            }
        }
        public void ToggleValve19State()
        {
            PumpV19.IsActive = !PumpV19.IsActive;

            foreach (var callbackv19 in Callbacksv19)
            {
                callbackv19(PumpV19.IsActive);
            }
        }
        public void ToggleValve20State()
        {
            PumpV20.IsActive = !PumpV20.IsActive;

            foreach (var callbackv20 in Callbacksv20)
            {
                callbackv20(PumpV20.IsActive);
            }
        }
        public void ToggleValve21State()
        {
            PumpV21.IsActive = !PumpV21.IsActive;

            foreach (var callbackv21 in Callbacksv21)
            {
                callbackv21(PumpV21.IsActive);
            }
        }
        public void ToggleValve22State()
        {
            PumpV22.IsActive = !PumpV22.IsActive;

            foreach (var callbackv22 in Callbacksv22)
            {
                callbackv22(PumpV22.IsActive);
            }
        }
        public void ToggleValve23State()
        {
            PumpV23.IsActive = !PumpV23.IsActive;

            foreach (var callbackv23 in Callbacksv23)
            {
                callbackv23(PumpV23.IsActive);
            }
        }
        public void ToggleValve24State()
        {
            PumpV24.IsActive = !PumpV24.IsActive;

            foreach (var callbackv24 in Callbacksv24)
            {
                callbackv24(PumpV24.IsActive);
            }
        }
        public void ToggleValve25State()
        {
            PumpV25.IsActive = !PumpV25.IsActive;

            foreach (var callbackv25 in Callbacksv25)
            {
                callbackv25(PumpV25.IsActive);
            }
        }
        public void ToggleValve26State()
        {
            PumpV26.IsActive = !PumpV26.IsActive;

            foreach (var callbackv26 in Callbacksv26)
            {
                callbackv26(PumpV26.IsActive);
            }
        }
        public void ToggleValve27State()
        {
            PumpV27.IsActive = !PumpV27.IsActive;

            foreach (var callbackv27 in Callbacksv27)
            {
                callbackv27(PumpV27.IsActive);
            }
        }
        public void ToggleValve28State()
        {
            PumpV28.IsActive = !PumpV28.IsActive;

            foreach (var callbackv28 in Callbacksv28)
            {
                callbackv28(PumpV28.IsActive);
            }
        }
        public void ToggleValve29State()
        {
            PumpV29.IsActive = !PumpV29.IsActive;

            foreach (var callbackv29 in Callbacksv29)
            {
                callbackv29(PumpV29.IsActive);
            }
        }

        //                                 ОБЪЯВЛЕНИЕ СПИСКА

        // список функций
        private List<Action<bool>> Callbacks { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacks2 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv1 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv2 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv3 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv4 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv5 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv6 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv7 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv8 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv9 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv10 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv11 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv12 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv13 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv14 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv15 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv16 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv17 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv18 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv19 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv20 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv21 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv22 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv23 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv24 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv25 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv26 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv27 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv28 { get; set; } = new List<Action<bool>>();
        private List<Action<bool>> Callbacksv29 { get; set; } = new List<Action<bool>>();



        //                                 ОБЪЯВЛЕНИЕ ОБЪЕКТОВ ЭЛЕМЕНТОВ
        public Pump Pump { get; set; } = new Pump();
        private Pump Pump2 { get; set; } = new Pump();
        public Pump PumpV1 { get; set; } = new Pump();
        private Pump PumpV2 { get; set; } = new Pump();
        public Pump PumpV3 { get; set; } = new Pump();
        private Pump PumpV4 { get; set; } = new Pump();
        private Pump PumpV5 { get; set; } = new Pump();
        private Pump PumpV6 { get; set; } = new Pump();
        private Pump PumpV7 { get; set; } = new Pump();
        private Pump PumpV8 { get; set; } = new Pump();
        private Pump PumpV9 { get; set; } = new Pump();
        private Pump PumpV10 { get; set; } = new Pump();
        public Pump PumpV11 { get; set; } = new Pump();
        private Pump PumpV12 { get; set; } = new Pump();
        private Pump PumpV13 { get; set; } = new Pump();
        private Pump PumpV14 { get; set; } = new Pump();
        private Pump PumpV15 { get; set; } = new Pump();
        private Pump PumpV16 { get; set; } = new Pump();
        private Pump PumpV17 { get; set; } = new Pump();
        private Pump PumpV18 { get; set; } = new Pump();
        private Pump PumpV19 { get; set; } = new Pump();
        public Pump PumpV20 { get; set; } = new Pump();
        private Pump PumpV21 { get; set; } = new Pump();
        private Pump PumpV22 { get; set; } = new Pump();
        private Pump PumpV23 { get; set; } = new Pump();
        private Pump PumpV24 { get; set; } = new Pump();
        private Pump PumpV25 { get; set; } = new Pump();
        public Pump PumpV26 { get; set; } = new Pump();
        private Pump PumpV27 { get; set; } = new Pump();
        private Pump PumpV28 { get; set; } = new Pump();
        private Pump PumpV29 { get; set; } = new Pump();
    }
    //                                                ЛОГИКА ВОДЫ

    
}
