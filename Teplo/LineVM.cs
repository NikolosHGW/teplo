using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Shapes;
using Core;

namespace Teplo
{
    class LineVM
    {
        public static ObservableCollection<Line> Lines { get; set; } = new ObservableCollection<Line>();
        public static void Push()
        {
            if (Game.ForStartGame() == 1)
            {
                Lines[0].Opacity = 1;
                Lines[1].Opacity = 1;
                Lines[2].Opacity = 1;
                Lines[3].Opacity = 1;
            }
            if (Game.Verification(2) == 1 && Lines[3].Opacity == 1)
            {
                Lines[4].Opacity = 1;
                Lines[5].Opacity = 1;
                Lines[6].Opacity = 1;
            }
            if (Game.Verification(3) == 1 && Lines[5].Opacity == 1)
            {
                Lines[7].Opacity = 1;
                Lines[8].Opacity = 1;
                Lines[9].Opacity = 1;
                Lines[10].Opacity = 1;
                Lines[11].Opacity = 1;
            }
            else
            {
                if (Game.Verification(3) == 1 && Lines[7].Opacity == 1)
                {
                    Lines[4].Opacity = 1;
                    Lines[5].Opacity = 1;
                    Lines[6].Opacity = 1;
                }
            }
            if (Game.VerificationV(7) == 1 && Lines[6].Opacity == 1)
            {
                Lines[12].Opacity = 1;
                Lines[13].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(7) == 1 && Lines[12].Opacity == 1)
                {
                    Lines[4].Opacity = 1;
                    Lines[5].Opacity = 1;
                    Lines[6].Opacity = 1;
                }
            }
            if (Game.VerificationV(8) == 1 && Lines[9].Opacity == 1)
            {
                Lines[14].Opacity = 1;
                Lines[15].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(8) == 1 && Lines[14].Opacity == 1)
                {
                    Lines[7].Opacity = 1;
                    Lines[8].Opacity = 1;
                    Lines[9].Opacity = 1;
                    Lines[10].Opacity = 1;
                    Lines[11].Opacity = 1;
                }
            }
            if (Game.VerificationV(2) == 1 && Lines[11].Opacity == 1)
            {
                Lines[16].Opacity = 1;
                Lines[17].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(2) == 1 && Lines[16].Opacity == 1)
                {
                    Lines[7].Opacity = 1;
                    Lines[8].Opacity = 1;
                    Lines[9].Opacity = 1;
                    Lines[10].Opacity = 1;
                    Lines[11].Opacity = 1;
                }
            }
            if (Game.Verification(5) == 1 && Lines[10].Opacity == 1)
            {
                Lines[18].Opacity = 1;
                Lines[19].Opacity = 1;
                Lines[20].Opacity = 1;
                Lines[21].Opacity = 1;
            }
            else
            {
                if (Game.Verification(5) == 1 && Lines[19].Opacity == 1)
                {
                    Lines[7].Opacity = 1;
                    Lines[8].Opacity = 1;
                    Lines[9].Opacity = 1;
                    Lines[10].Opacity = 1;
                    Lines[11].Opacity = 1;
                }
            }
            if (Game.VerificationV(3) == 1 && Lines[18].Opacity == 1)
            {
                Lines[22].Opacity = 1;
                Lines[23].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(3) == 1 && Lines[22].Opacity == 1)
                {
                    Lines[18].Opacity = 1;
                    Lines[19].Opacity = 1;
                    Lines[20].Opacity = 1;
                    Lines[21].Opacity = 1;
                }
            }
            if (Game.VerificationV(1) == 1 && Lines[22].Opacity == 1)
            {
                Lines[24].Opacity = 1;
                Lines[25].Opacity = 1;
                Lines[26].Opacity = 1;
                Lines[27].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(1) == 1 && Lines[24].Opacity == 1)
                {
                    Lines[22].Opacity = 1;
                    Lines[23].Opacity = 1;
                }
            }
            if (Game.VerificationV(6) == 1 && Lines[12].Opacity == 1)
            {
                Lines[28].Opacity = 1;
                Lines[29].Opacity = 1;
                Lines[30].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(6) == 1 && Lines[28].Opacity == 1)
                {
                    Lines[12].Opacity = 1;
                    Lines[13].Opacity = 1;
                }
            }
            if (Game.VerificationV(4) == 1 && Game.VerificationV(5) == 1 && Lines[12].Opacity == 1)
            {
                Lines[31].Opacity = 1;
                Lines[32].Opacity = 1;
            }
            if (Game.VerificationV(9) == 1 && Lines[14].Opacity == 1)
            {
                Lines[33].Opacity = 1;
                Lines[34].Opacity = 1;
                Lines[35].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(9) == 1 && Lines[33].Opacity == 1)
                {
                    Lines[14].Opacity = 1;
                    Lines[15].Opacity = 1;
                }
            }
            if (Game.VerificationV(0) == 1 && Lines[16].Opacity == 1)
            {
                Lines[33].Opacity = 1;
                Lines[34].Opacity = 1;
                Lines[35].Opacity = 1;
            }
            else
            {
                if (Game.VerificationV(0) == 1 && Lines[35].Opacity == 1)
                {
                    Lines[16].Opacity = 1;
                    Lines[17].Opacity = 1;
                }
            }
            if (Game.Verification(6) == 1 && Lines[29].Opacity == 1)
            {
                Lines[33].Opacity = 1;
                Lines[34].Opacity = 1;
                Lines[35].Opacity = 1;
            }
            else
            {
                if (Game.Verification(6) == 1 && Lines[34].Opacity == 1)
                {
                    Lines[28].Opacity = 1;
                    Lines[29].Opacity = 1;
                    Lines[30].Opacity = 1;
                }
            }
            if (Game.Verification(7) == 1 && Lines[34].Opacity == 1)
            {
                Lines[24].Opacity = 1;
                Lines[25].Opacity = 1;
                Lines[26].Opacity = 1;
                Lines[27].Opacity = 1;
            }
            else
            {
                if (Game.Verification(7) == 1 && Lines[25].Opacity == 1)
                {
                    Lines[33].Opacity = 1;
                    Lines[34].Opacity = 1;
                    Lines[35].Opacity = 1;
                }
            }
            if (Game.VerificationSml(2) == 1 && Lines[13].Opacity == 1)
            {
                Lines[14].Opacity = 1;
                Lines[15].Opacity = 1;
            }
            else
            {
                if (Game.VerificationSml(2) == 1 && Lines[15].Opacity == 1)
                {
                    Lines[12].Opacity = 1;
                    Lines[13].Opacity = 1;
                }
            }

            if (Game.VerificationSml(3) == 1 && Lines[17].Opacity == 1)
            {
                Lines[22].Opacity = 1;
                Lines[23].Opacity = 1;
            }
            else
            {
                if (Game.VerificationSml(3) == 1 && Lines[23].Opacity == 1)
                {
                    Lines[16].Opacity = 1;
                    Lines[17].Opacity = 1;
                }
            }

        }
        public static void PushDrain()
        {
            if (GetButtons.ButtonsVC[14].IsState == true)
            {
                Lines[0].Opacity = 0;
                Lines[1].Opacity = 0;
                Lines[2].Opacity = 0;
                Lines[3].Opacity = 0;
            }
        }
    }
}
