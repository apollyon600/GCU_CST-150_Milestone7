namespace Milestone7.PresentationLayer
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.picInventory = new System.Windows.Forms.PictureBox();
            this.btnOpenChest = new System.Windows.Forms.PictureBox();
            this.btnOpenCreativeMenu = new System.Windows.Forms.PictureBox();
            this.lblOpenChest = new System.Windows.Forms.Label();
            this.lblOpenCreativeMenu = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.PictureBox();
            this.lblToolTip = new System.Windows.Forms.Label();
            this.btnDecQty = new System.Windows.Forms.Button();
            this.btnIncQty = new System.Windows.Forms.Button();
            this.picBoxApollo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenChest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenCreativeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxApollo)).BeginInit();
            this.SuspendLayout();
            // 
            // picInventory
            // 
            this.picInventory.BackColor = System.Drawing.Color.Transparent;
            this.picInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInventory.BackgroundImage")));
            this.picInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInventory.Location = new System.Drawing.Point(35, 34);
            this.picInventory.Name = "picInventory";
            this.picInventory.Size = new System.Drawing.Size(550, 508);
            this.picInventory.TabIndex = 0;
            this.picInventory.TabStop = false;
            // 
            // btnOpenChest
            // 
            this.btnOpenChest.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenChest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenChest.BackgroundImage")));
            this.btnOpenChest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenChest.Location = new System.Drawing.Point(600, 143);
            this.btnOpenChest.Name = "btnOpenChest";
            this.btnOpenChest.Size = new System.Drawing.Size(128, 131);
            this.btnOpenChest.TabIndex = 1;
            this.btnOpenChest.TabStop = false;
            this.btnOpenChest.Click += new System.EventHandler(this.BtnOpenChestClickEvent);
            // 
            // btnOpenCreativeMenu
            // 
            this.btnOpenCreativeMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenCreativeMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenCreativeMenu.BackgroundImage")));
            this.btnOpenCreativeMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenCreativeMenu.Location = new System.Drawing.Point(600, 290);
            this.btnOpenCreativeMenu.Name = "btnOpenCreativeMenu";
            this.btnOpenCreativeMenu.Size = new System.Drawing.Size(128, 131);
            this.btnOpenCreativeMenu.TabIndex = 2;
            this.btnOpenCreativeMenu.TabStop = false;
            this.btnOpenCreativeMenu.Click += new System.EventHandler(this.BtnOpenCreativeEvent);
            // 
            // lblOpenChest
            // 
            this.lblOpenChest.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenChest.Font = new System.Drawing.Font("Minecraft Dungeons", 24F);
            this.lblOpenChest.ForeColor = System.Drawing.Color.White;
            this.lblOpenChest.Location = new System.Drawing.Point(734, 143);
            this.lblOpenChest.Name = "lblOpenChest";
            this.lblOpenChest.Size = new System.Drawing.Size(242, 131);
            this.lblOpenChest.TabIndex = 4;
            this.lblOpenChest.Text = "Open Chest";
            this.lblOpenChest.Click += new System.EventHandler(this.LblOpenChestClickEvent);
            // 
            // lblOpenCreativeMenu
            // 
            this.lblOpenCreativeMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenCreativeMenu.Font = new System.Drawing.Font("Minecraft Dungeons", 24F);
            this.lblOpenCreativeMenu.ForeColor = System.Drawing.Color.White;
            this.lblOpenCreativeMenu.Location = new System.Drawing.Point(734, 288);
            this.lblOpenCreativeMenu.Name = "lblOpenCreativeMenu";
            this.lblOpenCreativeMenu.Size = new System.Drawing.Size(271, 131);
            this.lblOpenCreativeMenu.TabIndex = 5;
            this.lblOpenCreativeMenu.Text = "Open Creative";
            this.lblOpenCreativeMenu.Click += new System.EventHandler(this.LblBtnOpenCreativeEvent);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToMenu.BackgroundImage")));
            this.btnBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMenu.Image")));
            this.btnBackToMenu.Location = new System.Drawing.Point(511, 52);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(50, 47);
            this.btnBackToMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.TabStop = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.BtnBackToMenuEvent);
            // 
            // lblToolTip
            // 
            this.lblToolTip.AutoSize = true;
            this.lblToolTip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToolTip.Font = new System.Drawing.Font("Minecraft Dungeons", 12F);
            this.lblToolTip.ForeColor = System.Drawing.Color.White;
            this.lblToolTip.Location = new System.Drawing.Point(288, 52);
            this.lblToolTip.Name = "lblToolTip";
            this.lblToolTip.Size = new System.Drawing.Size(197, 120);
            this.lblToolTip.TabIndex = 8;
            this.lblToolTip.Text = "ITEM NAME\r\nITEM DESCRIPTION\r\n\r\nITEM ENCHANTS?";
            // 
            // btnDecQty
            // 
            this.btnDecQty.BackColor = System.Drawing.Color.Transparent;
            this.btnDecQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecQty.BackgroundImage")));
            this.btnDecQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecQty.Font = new System.Drawing.Font("Minecraft Dungeons", 8.25F);
            this.btnDecQty.Location = new System.Drawing.Point(339, 216);
            this.btnDecQty.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecQty.Name = "btnDecQty";
            this.btnDecQty.Size = new System.Drawing.Size(59, 58);
            this.btnDecQty.TabIndex = 9;
            this.btnDecQty.Text = "Dec Qty";
            this.btnDecQty.UseVisualStyleBackColor = false;
            this.btnDecQty.Click += new System.EventHandler(this.BtnDecQtyEvent);
            // 
            // btnIncQty
            // 
            this.btnIncQty.BackColor = System.Drawing.Color.Transparent;
            this.btnIncQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncQty.BackgroundImage")));
            this.btnIncQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncQty.Font = new System.Drawing.Font("Minecraft Dungeons", 8.25F);
            this.btnIncQty.Location = new System.Drawing.Point(403, 216);
            this.btnIncQty.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncQty.Name = "btnIncQty";
            this.btnIncQty.Size = new System.Drawing.Size(59, 58);
            this.btnIncQty.TabIndex = 10;
            this.btnIncQty.Text = "Inc Qty";
            this.btnIncQty.UseVisualStyleBackColor = false;
            this.btnIncQty.Click += new System.EventHandler(this.BtnIncQtyEvent);
            // 
            // picBoxApollo
            // 
            this.picBoxApollo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxApollo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxApollo.BackgroundImage")));
            this.picBoxApollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxApollo.Location = new System.Drawing.Point(92, 49);
            this.picBoxApollo.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxApollo.Name = "picBoxApollo";
            this.picBoxApollo.Size = new System.Drawing.Size(121, 161);
            this.picBoxApollo.TabIndex = 11;
            this.picBoxApollo.TabStop = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 590);
            this.Controls.Add(this.picBoxApollo);
            this.Controls.Add(this.btnIncQty);
            this.Controls.Add(this.btnDecQty);
            this.Controls.Add(this.lblToolTip);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblOpenCreativeMenu);
            this.Controls.Add(this.lblOpenChest);
            this.Controls.Add(this.btnOpenCreativeMenu);
            this.Controls.Add(this.btnOpenChest);
            this.Controls.Add(this.picInventory);
            this.Name = "InventoryForm";
            this.Text = "Milestone 7 - John Aquino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryCloseEvent);
            ((System.ComponentModel.ISupportInitialize)(this.picInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenChest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenCreativeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxApollo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picInventory;
        private System.Windows.Forms.PictureBox btnOpenChest;
        private System.Windows.Forms.PictureBox btnOpenCreativeMenu;
        private System.Windows.Forms.Label lblOpenChest;
        private System.Windows.Forms.Label lblOpenCreativeMenu;
        private System.Windows.Forms.PictureBox btnBackToMenu;
        private System.Windows.Forms.Label lblToolTip;
        private System.Windows.Forms.Button btnDecQty;
        private System.Windows.Forms.Button btnIncQty;
        private System.Windows.Forms.PictureBox picBoxApollo;
    }
}