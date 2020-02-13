using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core
{
    public class Game
    {
        private static bool chk = true;
        public void StartGame()
        {
            if (GetButtons.ButtonsC[0].IsState == true && GetButtons.ButtonsPmpRC[0].IsState == false)
            {
                chk = false;
            }
            if (GetButtons.ButtonsPmpRC[0].IsState == false && GetButtons.ButtonsC[0].IsState == false)
            {
                chk = true;
            }
        }
        public static int ForStartGame()
        {
            if (GetButtons.ButtonsPmpRC[0].IsState == true && GetButtons.ButtonsC[0].IsState == true && chk == true)
            {
                return 1;
            }
            return 0;
        }
        public static int Verification(int i)
        {
            if (GetButtons.ButtonsC[i].IsState == true)
            {
                return 1;
            }
            return 0;
        }
        public static int VerificationV(int i)
        {
            if (GetButtons.ButtonsVC[i].IsState == true)
            {
                return 1;
            }
            return 0;
        }
        public static int VerificationSml(int i)
        {
            if (GetButtons.ButtonsSmlC[i].IsState == true)
            {
                return 1;
            }
            return 0;
        }
    }
}
