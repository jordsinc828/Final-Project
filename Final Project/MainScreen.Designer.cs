namespace Final_Project
{
    partial class MainScreen
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
            this.startingLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingLabel.Location = new System.Drawing.Point(133, 52);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(401, 85);
            this.startingLabel.TabIndex = 0;
            this.startingLabel.Text = "Space Climb";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("MV Boli", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(265, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // startLabel
            // 
            this.startLabel.Font = new System.Drawing.Font("MV Boli", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(265, 246);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(130, 50);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "Start";
            this.startLabel.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startingLabel);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(700, 700);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startLabel;
    }
}
