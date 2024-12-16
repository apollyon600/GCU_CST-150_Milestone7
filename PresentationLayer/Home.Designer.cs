namespace Milestone7.PresentationLayer
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnStartGame = new System.Windows.Forms.PictureBox();
            this.btnExitGame = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.lblExitGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartGame.BackgroundImage")));
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartGame.Location = new System.Drawing.Point(205, 236);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(519, 67);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGameEvent);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitGame.BackgroundImage")));
            this.btnExitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitGame.Location = new System.Drawing.Point(205, 319);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(519, 67);
            this.btnExitGame.TabIndex = 1;
            this.btnExitGame.TabStop = false;
            this.btnExitGame.Click += new System.EventHandler(this.BtnExitGameEvent);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(167, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(597, 133);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.BackColor = System.Drawing.Color.Transparent;
            this.lblStartGame.Font = new System.Drawing.Font("Minecraft Dungeons", 14.25F);
            this.lblStartGame.Location = new System.Drawing.Point(386, 249);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(165, 37);
            this.lblStartGame.TabIndex = 3;
            this.lblStartGame.Text = "Start Game";
            // 
            // lblExitGame
            // 
            this.lblExitGame.AutoSize = true;
            this.lblExitGame.BackColor = System.Drawing.Color.Transparent;
            this.lblExitGame.Font = new System.Drawing.Font("Minecraft Dungeons", 14.25F);
            this.lblExitGame.Location = new System.Drawing.Point(395, 333);
            this.lblExitGame.Name = "lblExitGame";
            this.lblExitGame.Size = new System.Drawing.Size(143, 37);
            this.lblExitGame.TabIndex = 4;
            this.lblExitGame.Text = "Exit Game";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 509);
            this.Controls.Add(this.lblExitGame);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnStartGame);
            this.Font = new System.Drawing.Font("Minecraft Dungeons", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Home";
            this.Text = "John Aquino - Milestone 7";
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnStartGame;
        private System.Windows.Forms.PictureBox btnExitGame;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label lblExitGame;
    }
}