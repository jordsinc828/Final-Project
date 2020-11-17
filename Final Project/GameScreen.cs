using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class GameScreen : UserControl
    {
        #region Global Variables
        Image ShipImage = Properties.Resources.Ship;
        Image AlienIdle = Properties.Resources.AlienIdle;
        Image AlienShooting = Properties.Resources.AlienShooting;
        Image PlayerIdle = Properties.Resources.PlayerIdle_2_;
        Image PlayerLeft = Properties.Resources.PlayerLeft_2_;
        Image PlayerRight = Properties.Resources.PlayerRight_2_;
        Image Floor = Properties.Resources.Floor__3_;
        Image FloorRight = Properties.Resources.FloorRight;
        Image FloorMiddle = Properties.Resources.FloorMiddle;
        Image FloorLeft = Properties.Resources.FloorLeft;
        Image Ladder = Properties.Resources.Ladder;
        Image Laser = Properties.Resources.laser;

        SoundPlayer death = new SoundPlayer(Properties.Resources.Dying);
        //SoundPlayer jump = new SoundPlayer(Properties.Resources.Jump);
        SoundPlayer shooting = new SoundPlayer(Properties.Resources.Laser_Shooting);
        SoundPlayer winning = new SoundPlayer(Properties.Resources.Winning);

        List<Platforms> platforms = new List<Platforms>();
        List<Ladder> ladders = new List<Ladder>();
        List<Lasers> lasers = new List<Lasers>();

        Alien alien;
        Ship ship;
        Hero hero;


        Boolean aKeyDown, dKeyDown, wKeyDown, sKeyDown, spaceKeyDown;
        bool gravity = true;
        int counter;
        int timer;
        int startTimer;
        Random randNum = new Random();
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            GameTimer.Enabled = true;
        }
        #region Key Inputs
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
                case Keys.Space:
                    spaceKeyDown = false;
                    break;
            }
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
                case Keys.Space:
                    spaceKeyDown = true;
                    break;
            }
        }
        #endregion
        private void GameScreen_Load(object sender, EventArgs e)
        {
            SetParameters();
        }
        #region Set Parameters
        public void SetParameters()
        {

            platforms.Clear();
            ladders.Clear();
            lasers.Clear();
            timer = 0;
            startTimer = 312;


            deciderLabel.Visible = false;
            replayButton.Visible = false;
            menuButton.Visible = false;
            startLabel.Visible = true;
            scoreLabel.Visible = false;

            hero = new Hero(PlayerIdle, 20, 310, 17, 17, 1, 2);
            ship = new Ship(ShipImage, 60, 300, 40, 40, 1);
            alien = new Alien(AlienIdle, 5, 290, 30, 30, 1);

            #region Ladders
            //all ladders from top to bottom -- left to right
            Ladder ladder1 = new Ladder(Ladder, 225, 80, 20, 50);
            ladders.Add(ladder1);
            Ladder ladder2 = new Ladder(Ladder, 150, 130, 20, 50);
            ladders.Add(ladder2);
            Ladder ladder3 = new Ladder(Ladder, 100, 180, 20, 50);
            ladders.Add(ladder3);
            Ladder ladder4 = new Ladder(Ladder, 130, 230, 20, 50);
            ladders.Add(ladder4);
            Ladder ladder5 = new Ladder(Ladder, 200, 230, 20, 50);
            ladders.Add(ladder5);
            Ladder ladder6 = new Ladder(Ladder, 250, 280, 20, 50);
            ladders.Add(ladder6);
            #endregion
            #region Platforms
            //all platforms in order from top to bottom -- left to right
            #region 1st Level
            Platforms platform1 = new Platforms(Floor, 50, 40, 60, 10);
            platforms.Add(platform1);
            Platforms platform2 = new Platforms(FloorLeft, 0, 80, 75, 15);
            platforms.Add(platform2);
            Platforms platform3 = new Platforms(FloorMiddle, 75, 80, 50, 15);
            platforms.Add(platform3);
            Platforms platform4 = new Platforms(FloorMiddle, 125, 80, 50, 15);
            platforms.Add(platform4);
            Platforms platform5 = new Platforms(FloorMiddle, 175, 80, 50, 15);
            platforms.Add(platform5);
            Platforms platform6 = new Platforms(FloorRight, 245, 80, 50, 15);
            platforms.Add(platform6);
            #endregion
            #region 2nd Level
            Platforms platform7 = new Platforms(FloorLeft, 50, 130, 50, 15);
            platforms.Add(platform7);
            Platforms platform8 = new Platforms(FloorMiddle, 100, 130, 50, 15);
            platforms.Add(platform8);
            Platforms platform9 = new Platforms(FloorMiddle, 170, 130, 50, 15);
            platforms.Add(platform9);
            Platforms platform10 = new Platforms(FloorMiddle, 210, 130, 50, 15);
            platforms.Add(platform10);
            Platforms platform11 = new Platforms(FloorMiddle, 260, 130, 50, 15);
            platforms.Add(platform11);
            Platforms platform12 = new Platforms(FloorRight, 310, 130, 35, 15);
            platforms.Add(platform12);
            #endregion
            #region 3rd Level
            Platforms platform13 = new Platforms(FloorLeft, 0, 180, 50, 15);
            platforms.Add(platform13);
            Platforms platform14 = new Platforms(FloorMiddle, 50, 180, 50, 15);
            platforms.Add(platform14);
            Platforms platform15 = new Platforms(FloorMiddle, 120, 180, 50, 15);
            platforms.Add(platform15);
            Platforms platform16 = new Platforms(FloorMiddle, 150, 180, 50, 15);
            platforms.Add(platform16);
            Platforms platform17 = new Platforms(FloorMiddle, 200, 180, 50, 15);
            platforms.Add(platform17);
            Platforms platform18 = new Platforms(FloorRight, 245, 180, 50, 15);
            platforms.Add(platform18);
            #endregion
            #region 4th Level
            Platforms platform19 = new Platforms(FloorLeft, 50, 230, 50, 15);
            platforms.Add(platform19);
            Platforms platform20 = new Platforms(FloorMiddle, 100, 230, 30, 15);
            platforms.Add(platform20);
            Platforms platform21 = new Platforms(FloorMiddle, 150, 230, 50, 15);
            platforms.Add(platform21);
            Platforms platform22 = new Platforms(FloorMiddle, 220, 230, 50, 15);
            platforms.Add(platform22);
            Platforms platform23 = new Platforms(FloorMiddle, 270, 230, 50, 15);
            platforms.Add(platform23);
            Platforms platform24 = new Platforms(FloorRight, 310, 230, 35, 15);
            platforms.Add(platform24);
            #endregion
            #region 5th Level
            Platforms platform25 = new Platforms(FloorLeft, 0, 280, 50, 15);
            platforms.Add(platform25);
            Platforms platform26 = new Platforms(FloorMiddle, 50, 280, 50, 15);
            platforms.Add(platform26);
            Platforms platform27 = new Platforms(FloorMiddle, 100, 280, 50, 15);
            platforms.Add(platform27);
            Platforms platform28 = new Platforms(FloorMiddle, 150, 280, 50, 15);
            platforms.Add(platform28);
            Platforms platform29 = new Platforms(FloorMiddle, 200, 280, 50, 15);
            platforms.Add(platform29);
            Platforms platform30 = new Platforms(FloorRight, 270, 280, 25, 15);
            platforms.Add(platform30);
            #endregion
            #region 6th Level
            Platforms platform31 = new Platforms(FloorLeft, 0, 330, 50, 15);
            platforms.Add(platform31);
            Platforms platform32 = new Platforms(FloorMiddle, 50, 330, 50, 15);
            platforms.Add(platform32);
            Platforms platform33 = new Platforms(FloorMiddle, 100, 330, 50, 15);
            platforms.Add(platform33);
            Platforms platform34 = new Platforms(FloorMiddle, 150, 330, 50, 15);
            platforms.Add(platform34);
            Platforms platform35 = new Platforms(FloorMiddle, 200, 330, 50, 15);
            platforms.Add(platform35);
            Platforms platform36 = new Platforms(FloorMiddle, 250, 330, 60, 15);
            platforms.Add(platform36);
            Platforms platform37 = new Platforms(FloorRight, 310, 330, 50, 15);
            platforms.Add(platform37);
            #endregion
            #endregion
            hero.jump = false;
            replayButton.Enabled = false;
            menuButton.Enabled = false;
            this.Focus();
            GameTimer.Enabled = true;
        }
        #endregion
        #region Game Endings
        public void GameOver()
        {
            death.Play();
            GameTimer.Enabled = false;
            deciderLabel.Visible = true;
            deciderLabel.Text = "Game Over!";
            replayButton.Visible = true;
            menuButton.Visible = true;
            menuButton.Enabled = true;
            replayButton.Enabled = true;
            GameTimer.Enabled = false;
        }


        public void GameWin()
        {
            winning.Play();
            GameTimer.Enabled = false;
            deciderLabel.Visible = true;
            replayButton.Enabled = true;
            replayButton.Enabled = true;
            deciderLabel.Text = "You Win!" +
                "\n it took you " + startTimer / -32;
            replayButton.Visible = true;
            menuButton.Visible = true;
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            SetParameters();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            this.Refresh();
        }
        #endregion
        public void ShipCollision()
        {
            Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.sizeW - 10, hero.sizeH);
            Rectangle shipRec = new Rectangle(ship.x, ship.y, ship.sizeW - 15, ship.sizeH - 15);

            if (heroRec.IntersectsWith(shipRec))
            {
                GameWin();
            }
        }
        private void GameTickTimer(object sender, EventArgs e)
        {
            startTimer--;
            startLabel.Text = "Game will begin in " + startTimer / 32;

            #region Movement

            foreach (Platforms p in platforms)
            {
                Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.sizeW - 10, hero.sizeH);
                Rectangle platRec = new Rectangle(p.x, p.y, p.sizeW, p.sizeH);
                if (heroRec.IntersectsWith(platRec))
                {
                    gravity = false;
                    break;
                }
                else
                {
                    gravity = true;
                }
            }
            if (gravity == true)
            {
                hero.y++;
            }
            else
            {

            }

            #region Works after 10 seconds


            if (startTimer / 32 < 0)
            {
                timer++;
                scoreLabel.Text = "Time: " + timer / 32;
                startLabel.Visible = false;

                if (spaceKeyDown == true)
                {
                    shooting.Play();
                    hero.Jump("up");
                }
                if (hero.jump == true)
                {
                    counter++;
                    if (counter > 1 && counter < 28)
                    {
                        hero.y -= 3;
                    }
                    else if (counter > 29 && counter < 60)
                    {

                    }
                    else if (counter > 61)
                    {
                        hero.Jump("down");
                        counter = 0;
                    }
                    foreach (Platforms p in platforms)
                    {
                        Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.sizeW - 10, hero.sizeH);
                        Rectangle platRec = new Rectangle(p.x, p.y, p.sizeW, p.sizeH);

                        if (heroRec.IntersectsWith(platRec) && heroRec.Y > p.y)
                        {
                            hero.y += 5;
                            counter = 26;
                        }
                    }

                }
                if (aKeyDown == true)
                {
                    hero.Move("left");
                }
                else if (dKeyDown == true)
                {
                    hero.Move("right");
                }
                else
                {
                    hero.Move("idle");
                }
            }
            #endregion
            ship.Breathe();
            alien.Hover();

            #endregion
            foreach (Ladder l in ladders)
            {
                Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.sizeW - 10, hero.sizeH);
                Rectangle ladderRec = new Rectangle(l.x, l.y, l.sizeW - 5, l.sizeH - 15);

                if (heroRec.IntersectsWith(ladderRec))
                {
                    hero.y--;
                    if (wKeyDown == true)
                    {
                        hero.y -= 1;
                    }
                    else if (sKeyDown == true)
                    {
                        hero.y += 2;
                    }
                }
            }

            int rand = randNum.Next(1, 101);


            if (rand < 10 && alien.y > 50 && alien.y < 60)
            {
                //jump.Play();
                Lasers laser1 = new Lasers(Laser, 5, 60, 10, 20, 4);
                lasers.Add(laser1);
            }
            try
            {
                foreach (Lasers l in lasers)
                {


                    if (l.y > 340)
                    {
                        lasers.Remove(l);
                    }
                    l.LaserMove();
                    Rectangle heroRec = new Rectangle(hero.x, hero.y, hero.sizeW - 10, hero.sizeH - 10);
                    Rectangle laserRec = new Rectangle(l.x, l.y, l.sizeW - 5, l.sizeH - 10);
                    if (heroRec.IntersectsWith(laserRec))
                    {
                        GameOver();
                        return;
                    }

                }
            }
            catch
            {

            }
            ShipCollision();

            this.Refresh();

            




        }
        #region Paint
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ship.image, ship.x, ship.y, ship.sizeW, ship.sizeH);
            e.Graphics.DrawImage(alien.image, alien.x, alien.y, alien.sizeW, alien.sizeH);

            foreach (Ladder L in ladders)
            {
                e.Graphics.DrawImage(L.image, L.x, L.y, L.sizeW, L.sizeH);
            }
            foreach (Platforms p in platforms)
            {
                e.Graphics.DrawImage(p.image, p.x, p.y, p.sizeW, p.sizeH);
            }
            foreach (Lasers l in lasers)
            {
                e.Graphics.DrawImage(l.image, l.x, l.y, l.sizeW, l.sizeH);
            }
            e.Graphics.DrawImage(hero.image, hero.x, hero.y, hero.sizeW, hero.sizeH);
        }
        #endregion
    }
}
