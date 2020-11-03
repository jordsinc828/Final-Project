using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Ship
    {
        public int x, y, sizeW, sizeH, speed;
        public Image image;

        public Ship(Image _image, int _x, int _y, int _sizeW, int _sizeH, int _speed)
        {

            x = _x;
            y = _y;
            sizeW = _sizeW;
            sizeH = _sizeH;
            speed = _speed;
            image = _image;

        }
        public void Breathe()
        {
            if (y < 50)
            {
                y += speed;
            }
            else if (y > 200)
            {
                y -= speed;
            }
            else
            {
                y++;
            }
        }
    }
}
