using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Parameters
    {
        public static int Gp { get; set; }
        public static void Calc()
        {
            if (GetButtons.ButtonsC[0].IsState == true)
            {
                Gp = 100;
            }
        }
    }
}
