namespace Final_Project
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.deciderLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 16;
            this.GameTimer.Tick += new System.EventHandler(this.GameTickTimer);
            // 
            // deciderLabel
            // 
            this.deciderLabel.AutoSize = true;
            this.deciderLabel.BackColor = System.Drawing.Color.Transparent;
            this.deciderLabel.Font = new System.Drawing.Font("MV Boli", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deciderLabel.Location = new System.Drawing.Point(172, 180);
            this.deciderLabel.Name = "deciderLabel";
            this.deciderLabel.Size = new System.Drawing.Size(143, 55);
            this.deciderLabel.TabIndex = 0;
            this.deciderLabel.Text = "Label1";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(3, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(87, 34);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "label2";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("MV Boli", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(3, 97);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(157, 70);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "label1";
            // 
            // replayButton
            // 
            this.replayButton.BackColor = System.Drawing.Color.Transparent;
            this.replayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayButton.Location = new System.Drawing.Point(103, 285);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(192, 94);
            this.replayButton.TabIndex = 4;
            this.replayButton.Text = "Play Again?";
            this.replayButton.UseVisualStyleBackColor = false;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(103, 397);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(192, 94);
            this.menuButton.TabIndex = 6;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.Game_Image;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.deciderLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(725, 725);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label deciderLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button menuButton;
    }
}
