using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class GameScreen : UserControl
    {
        Image ShipImage = Properties.Resources.Ship;
        Image AlienIdle = Properties.Resources.AlienIdle;
        Image AlienShooting = Properties.Resources.AlienShooting;
        Image PlayerIdle = Properties.Resources.PlayerIdle;
        Image PlayerLeft = Properties.Resources.PlayerLeft;
        Image PlayerRight = Properties.Resources.PlayerRight;
        Image Floor = Properties.Resources.Floor;

        List<Platforms> platforms = new List<Platforms>();
        List<Ship> ship = new List<Ship>();

        int test = 70;
        public GameScreen()
        {
            InitializeComponent();
            GameTimer.Enabled = true;
        }


        private void GameScreen_Load(object sender, EventArgs e)
        {
            Ship ship1 = new Ship(ShipImage, 200, 75, 100, 100, 5);
            ship.Add(ship1);

            Platforms platform1 = new Platforms(Floor, 100, 100, 200, 50);
            platforms.Add(platform1);
        }
        private void GameTickTimer(object sender, EventArgs e)
        {
            foreach (Ship s in ship)
            {
                s.Breathe();
            }
            //for (int i = 0; i < ship.Count(); i++)
            //{
            //    if (ship[i].y > 240)
            //    {
            //        ship[i].speed = ship[i].speed;
            //    }
            //    else if (platforms[i].x < 155)
            //    {
            //        platforms[i].speed = rand;
            //    }
            //}
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Ship s in ship)
            {
                e.Graphics.DrawImage(s.image, s.x, s.y, s.sizeW, s.sizeH);
            }
         
            foreach (Platforms p in platforms)
            {
                e.Graphics.DrawImage(p.image, p.x, p.y, p.sizeW, p.sizeH);
            }
        }
    }
}
