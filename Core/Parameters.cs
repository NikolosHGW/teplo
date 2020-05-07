using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Parameters
    {
        public static int P1 { get; private set; }
        public static int NumberP1 { get; set; }
        public static int P2 { get; private set; }
        public static int NumberP2 { get; set; }
        public static int T1 { get; private set; }
        public static int NumberT1 { get; set; }
        public static int T2 { get; private set; }
        public static int NumberT2 { get; set; }
        public static int G1 { get; private set; }
        public static int NumberG1 { get; set; }
        public static int G2 { get; private set; }
        public static int NumberG2 { get; set; }
        public static int Gp { get; private set; }
        public static int NumberGp { get; set; }

        public static bool Chck { get; set; }
        public static void Calc()
        {
            if (GetButtons.ButtonsC[0].IsState == true && GetButtons.ButtonsPmpRC[0].IsState == true && Chck == true && GetButtons.ButtonsVC[14].IsState == true)
            {
                Gp = 350;
            }
        }
    }
}
