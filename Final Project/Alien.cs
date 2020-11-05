using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Alien
    {
        public int x, y, sizeW, sizeH, speed;
        public Image image;
        public bool shipDown = false;

        public Alien(Image _image, int _x, int _y, int _sizeW, int _sizeH, int _speed)
        {
            x = _x;
            y = _y;
            sizeW = _sizeW;
            sizeH = _sizeH;
            speed = _speed;
            image = _image;
        }
        public void Hover()
        {
            if (y > 60)
            {
                speed = 3;
            }
            else
            {
                speed = 1;
            }
            if (y < 40)
            {
                shipDown = true;
            }
            else if (y > 55)
            {
                shipDown = false;
            }

            if (shipDown == true)
            {
                y += speed;
            }
            else if (shipDown == false)
            {
                y -= speed;
            }
        }
    }
}
