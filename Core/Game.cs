﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core
{
    public class Game
    {
        public static bool l0 = true;
        public static bool l4 = true;
        public void StartGame()
        {
            if (GetButtons.ButtonsPmpRC[0].IsState == true && GetButtons.ButtonsC[0].IsState == true)
            {
                GetLines.LinesC[0].State = true;
            }
        }
        public static void ChangeForAnim(int i)
        {
            GetLines.LinesC[i].State = true;
        }
    }
}
