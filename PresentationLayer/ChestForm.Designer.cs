namespace Milestone7.PresentationLayer
{
    partial class ChestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChestForm));
            this.btnExitChest = new System.Windows.Forms.PictureBox();
            this.picChest = new System.Windows.Forms.PictureBox();
            this.txtBoxInputFilter = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picBoxSubmit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitChest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitChest
            // 
            this.btnExitChest.BackColor = System.Drawing.Color.Transparent;
            this.btnExitChest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitChest.BackgroundImage")));
            this.btnExitChest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitChest.Location = new System.Drawing.Point(506, 171);
            this.btnExitChest.Name = "btnExitChest";
            this.btnExitChest.Size = new System.Drawing.Size(44, 38);
            this.btnExitChest.TabIndex = 1;
            this.btnExitChest.TabStop = false;
            this.btnExitChest.Click += new System.EventHandler(this.BtnExitChestEvent);
            // 
            // picChest
            // 
            this.picChest.BackColor = System.Drawing.Color.Transparent;
            this.picChest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picChest.BackgroundImage")));
            this.picChest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChest.Location = new System.Drawing.Point(32, 162);
            this.picChest.Name = "picChest";
            this.picChest.Size = new System.Drawing.Size(548, 520);
            this.picChest.TabIndex = 2;
            this.picChest.TabStop = false;
            // 
            // txtBoxInputFilter
            // 
            this.txtBoxInputFilter.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxInputFilter.Font = new System.Drawing.Font("Minecraft Dungeons", 14F);
            this.txtBoxInputFilter.ForeColor = System.Drawing.Color.White;
            this.txtBoxInputFilter.Location = new System.Drawing.Point(32, 64);
            this.txtBoxInputFilter.Name = "txtBoxInputFilter";
            this.txtBoxInputFilter.Size = new System.Drawing.Size(548, 43);
            this.txtBoxInputFilter.TabIndex = 3;
            this.txtBoxInputFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Minecraft Dungeons", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(32, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(548, 40);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Filter Items";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxSubmit
            // 
            this.picBoxSubmit.BackColor = System.Drawing.Color.Transparent;
            this.picBoxSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxSubmit.BackgroundImage")));
            this.picBoxSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxSubmit.Location = new System.Drawing.Point(161, 122);
            this.picBoxSubmit.Name = "picBoxSubmit";
            this.picBoxSubmit.Size = new System.Drawing.Size(286, 34);
            this.picBoxSubmit.TabIndex = 5;
            this.picBoxSubmit.TabStop = false;
            this.picBoxSubmit.Click += new System.EventHandler(this.PicBoxSubmitClickEvent);
            // 
            // ChestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 755);
            this.Controls.Add(this.picBoxSubmit);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtBoxInputFilter);
            this.Controls.Add(this.btnExitChest);
            this.Controls.Add(this.picChest);
            this.Name = "ChestForm";
            this.Text = "Chest - John Aquino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCloseEvent);
            ((System.ComponentModel.ISupportInitialize)(this.btnExitChest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnExitChest;
        private System.Windows.Forms.PictureBox picChest;
        private System.Windows.Forms.TextBox txtBoxInputFilter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picBoxSubmit;
    }
}