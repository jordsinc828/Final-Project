using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Hero
    {
        public int x, y, sizeW, sizeH, speed;
        public Image image;
        int jump;

        public Hero(Image _image, int _x, int _y, int _sizeW, int _sizeH, int _speed)
        {
            x = _x;
            y = _y;
            sizeW = _sizeH;
            sizeH = _sizeH;
            image = _image;
            speed = _speed;
        }

        public void Gravity()
        {
            
        }
        public void Jump()
        {
            y--;
            //for (int i = 1; i <= 2000; i++)
            //{
            //    if (i > 100)
            //    {
            //        y -= 1;
            //    }
            //    else if (i < 101 && i > 201)
            //    {
            //        y++;
            //    }

            //}
        }
        public void Left()
        {
            x -= speed;

        }
        public void Right()
        {
            x += speed;
        }
    }
}
