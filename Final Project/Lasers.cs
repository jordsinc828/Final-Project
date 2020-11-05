using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Lasers
    {
        public int x, y, sizeW, sizeH, speed;
        public Image image;

        public Lasers(Image _image, int _x, int _y, int _sizeW, int _sizeH, int _speed)
        { 
            x = _x;
            y = _y;
            sizeW = _sizeW;
            sizeH = _sizeH;
            image = _image;
            speed = _speed;
        }

        public void LaserMove()
        {
            x += speed;
            if (x > 345)
            {
                speed = -4;
                y += 50;
            }
            else if (x < -3)
            {
                speed = +4;
                y += 50;
            }
        }
    }
}
