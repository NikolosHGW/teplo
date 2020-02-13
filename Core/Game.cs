using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Core
{
    public class Game
    {
        public static bool l0 = true;
        public void Pusk()
        {
            if (GetButtons.ButtonsPmpRC[0].IsState == true && GetButtons.ButtonsC[0].IsState == true)
            {
                GetLines.LinesC[0].State = true;
            }
        }
    }
}
