﻿using System;
using System.Collections.Generic;
using System.IO;
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
        public static DoubleAnimation Blade1Anim { get; set; }
        public static DoubleAnimation Blade2Anim { get; set; }
        public static Line Blade21 { get; set; }
        public static Line Blade22 { get; set; }
        public static DoubleAnimation Blade21Anim { get; set; }
        public static DoubleAnimation Blade22Anim { get; set; }
        public static Line Blade31 { get; set; }
        public static Line Blade32 { get; set; }
        public static DoubleAnimation Blade31Anim { get; set; }
        public static DoubleAnimation Blade32Anim { get; set; }
        public static Line Blade41 { get; set; }
        public static Line Blade42 { get; set; }
        public static DoubleAnimation Blade41Anim { get; set; }
        public static DoubleAnimation Blade42Anim { get; set; }
        public static bool RotationPmpR { get; private set; }

        public static void StartPmpR(int l, int t)
        {
            if (GetButtons.ButtonsPmpRC[0].IsState == true && l == 380 && t == 146)
            {
                MStart.Open(new Uri("../../../Resources/Zapusk.mp3", UriKind.RelativeOrAbsolute)); /*C:/Users/Николос/source/repos/teplo/Teplo/Resources/Start.mp3" */ //дома /*C:/Users/Nikolos/Desktop/All/Новая папка/Картинки для проекта/Запуск.mp3*/ запасной метод Directory.GetCurrentDirectory() + "/Sounds/Zapusk.mp3"
                MStart.Play();
                Blade1.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade1Anim);
                Blade2.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade2Anim);
                RotationPmpR = true;
            }
            if (GetButtons.ButtonsPmpRC[0].IsState == false && l == 380 && t == 146)
            {
                MStop.Open(new Uri("../../../Resources/Ostanov.mp3", UriKind.RelativeOrAbsolute)); //C:/Users/Николос/Downloads/Останов.mp3   дома C:/Users/Nikolos/Desktop/All/Новая папка/Картинки для проекта/Останов.mp3 запасной метод Directory.GetCurrentDirectory() + "/Sounds/Ostanov.mp3"
                MStop.Play();
                Blade1.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
                Blade2.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
                RotationPmpR = false;
            }
        }
        public static void StartPmpL(int l, int t)
        {
            //Насос номер 0
            if (GetButtons.ButtonsPmpLC[0].IsState == true && l == 349 && t == 246)
            {
                MStart.Open(new Uri("../../../Resources/Zapusk.mp3", UriKind.RelativeOrAbsolute));
                MStart.Play();
                Blade21.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade21Anim);
                Blade22.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade22Anim);
            }
            if (GetButtons.ButtonsPmpLC[0].IsState == false && l == 349 && t == 246)
            {
                MStop.Open(new Uri("../../../Resources/Ostanov.mp3", UriKind.RelativeOrAbsolute)); /*C:/Users/Николос/Downloads/Останов.mp3*/
                MStop.Play();
                Blade21.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
                Blade22.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
            }
            //Насос номер 1
            if (GetButtons.ButtonsPmpLC[1].IsState == true && l == 349 && t == 310)
            {
                MStart.Open(new Uri("../../../Resources/Zapusk.mp3", UriKind.RelativeOrAbsolute));
                MStart.Play();
                Blade31.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade31Anim);
                Blade32.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade32Anim);
            }
            if (GetButtons.ButtonsPmpLC[1].IsState == false && l == 349 && t == 310)
            {
                MStop.Open(new Uri("../../../Resources/Ostanov.mp3", UriKind.RelativeOrAbsolute));
                MStop.Play();
                Blade31.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
                Blade32.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
            }
            //Насос номер 2
            if (GetButtons.ButtonsPmpLC[2].IsState == true && l == 349 && t == 374)
            {
                MStart.Open(new Uri("../../../Resources/Zapusk.mp3", UriKind.RelativeOrAbsolute));
                MStart.Play();
                Blade41.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade41Anim);
                Blade42.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, Blade42Anim);
            }
            if (GetButtons.ButtonsPmpLC[2].IsState == false && l == 349 && t == 374)
            {
                MStop.Open(new Uri("../../../Resources/Ostanov.mp3", UriKind.RelativeOrAbsolute));
                MStop.Play();
                Blade41.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
                Blade42.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
            }
        }
    }
}
