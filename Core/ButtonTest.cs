using System;
using System.Collections.Generic;
using System.Text;

namespace Teplo
{
    public class ButtonTest
    {
        private bool image;
        public bool ChangeImage()
        {
            return image = !image;
        }
    }
}
