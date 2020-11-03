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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            startingLabel.Location = new Point((this.Width - startingLabel.Width) / 2, 20);
            exitButton.Location = new Point((this.Width - exitButton.Width) / 2, 200);
            startButton.Location = new Point((this.Width - startButton.Width) / 2, 125);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
            this.Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
