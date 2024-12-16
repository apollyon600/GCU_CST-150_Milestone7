namespace Milestone7
{
    partial class Milestone7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Milestone7));
            this.btnStartGame = new System.Windows.Forms.PictureBox();
            this.btnExitGame = new System.Windows.Forms.PictureBox();
            this.picBoxTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.Image = ((System.Drawing.Image)(resources.GetObject("btnStartGame.Image")));
            this.btnStartGame.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnStartGame.InitialImage")));
            this.btnStartGame.Location = new System.Drawing.Point(123, 207);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(565, 76);
            this.btnStartGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitGame.Image = ((System.Drawing.Image)(resources.GetObject("btnExitGame.Image")));
            this.btnExitGame.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExitGame.InitialImage")));
            this.btnExitGame.Location = new System.Drawing.Point(123, 320);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(565, 75);
            this.btnExitGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitGame.TabIndex = 2;
            this.btnExitGame.TabStop = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // picBoxTitle
            // 
            this.picBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxTitle.BackgroundImage")));
            this.picBoxTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxTitle.Location = new System.Drawing.Point(168, 54);
            this.picBoxTitle.Name = "picBoxTitle";
            this.picBoxTitle.Size = new System.Drawing.Size(461, 108);
            this.picBoxTitle.TabIndex = 3;
            this.picBoxTitle.TabStop = false;
            // 
            // Milestone7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 491);
            this.Controls.Add(this.picBoxTitle);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnStartGame);
            this.Name = "Milestone7";
            this.Text = "Milestone 7 - John Aquino";
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnStartGame;
        private System.Windows.Forms.PictureBox btnExitGame;
        private System.Windows.Forms.PictureBox picBoxTitle;
    }
}

