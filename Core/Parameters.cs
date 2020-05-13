using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Parameters
    {
        public static int P1 { get; private set; }
        public static int NumberP1 { get; set; } = 0;
        public static int P2 { get; private set; }
        public static int NumberP2 { get; set; } = 0;
        public static int T1 { get; private set; }
        public static int NumberT1 { get; set; } = 0;
        public static int T2 { get; private set; }
        public static int NumberT2 { get; set; } = 0;
        public static int G1 { get; private set; }
        public static int NumberG1 { get; set; } = 0;
        public static int G2 { get; private set; }
        public static int NumberG2 { get; set; } = 0;
        public static int Gp { get; private set; }
        public static int NumberGp { get; set; } = 0;

        public static bool Chck { get; set; }
        public static bool ChckF12 { get; set; }
        public static void Calc()
        {
            if (NumberGp == 1)
            {
                G1 = 350;
                Gp = 350;
            }
            if (NumberGp == 2)
            {
                P1 = 3;
                P2 = 3;
                G1 = 0;
                Gp = 0;
            }
            if (NumberGp == 3)
            {
                P1 = 0;
                P2 = 0;
                G1 = 350;
                Gp = 350;
            }
            if (NumberGp == 4)
            {
                P1 = 3;
                P2 = 3;
                G1 = 0;
                Gp = 0;
            }
            if (NumberGp == 5)
            {
                P1 = 0;
                P2 = 0;
                G1 = 100;
                Gp = 100;
            }
        }
    }
}
