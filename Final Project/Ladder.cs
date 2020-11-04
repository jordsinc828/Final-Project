using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Ladder
    {
        public int x, y, sizeW, sizeH;
        public Image image;
        public bool shipDown = false;

        public Ladder(Image _image, int _x, int _y, int _sizeW, int _sizeH)
        {
            x = _x;
            y = _y;
            sizeW = _sizeW;
            sizeH = _sizeH;
            image = _image;
        }
    }
}
