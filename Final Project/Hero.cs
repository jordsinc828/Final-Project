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
        public int x, y, sizeW, sizeH, speed, jumpSpeed;
        public Image image;
        public bool jump = false;

        public Hero(Image _image, int _x, int _y, int _sizeW, int _sizeH, int _speed, int _jumpSpeed)
        {
            x = _x;
            y = _y;
            sizeW = _sizeH;
            sizeH = _sizeH;
            image = _image;
            speed = _speed;
            jumpSpeed = _jumpSpeed;
        }
        
        public void Jump(string direction)
        {
            if (direction == "up")
            {
                jump = true;
            }
            else if (direction == "down")
            {
                jump = false;
            }
           
        }
        public void Left()
        {
            x -= speed;

        }
        public void Right()
        {
            x += speed;
        }
        public void Move(string direction)
        {
            if (direction == "left" && x > 0)
            {
                x -= speed;
                image = Properties.Resources.PlayerLeft_2_;
            }
            else if (direction == "right" && x < 334)
            {
                x += speed;
                image = Properties.Resources.PlayerRight_2_;
            }
            else if (direction == "idle")
            {
                image = Properties.Resources.PlayerIdle_2_;
            }
        }

    }
}
