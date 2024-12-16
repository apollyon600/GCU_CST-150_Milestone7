namespace Milestone7.PresentationLayer
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            this.txtBoxInputName = new System.Windows.Forms.TextBox();
            this.txtBoxInputDescription = new System.Windows.Forms.TextBox();
            this.txtBoxInputQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.PictureBox();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxInputName
            // 
            this.txtBoxInputName.Font = new System.Drawing.Font("Minecraft Dungeons", 18F);
            this.txtBoxInputName.Location = new System.Drawing.Point(277, 173);
            this.txtBoxInputName.Name = "txtBoxInputName";
            this.txtBoxInputName.Size = new System.Drawing.Size(411, 53);
            this.txtBoxInputName.TabIndex = 0;
            // 
            // txtBoxInputDescription
            // 
            this.txtBoxInputDescription.Font = new System.Drawing.Font("Minecraft Dungeons", 18F);
            this.txtBoxInputDescription.Location = new System.Drawing.Point(277, 248);
            this.txtBoxInputDescription.Name = "txtBoxInputDescription";
            this.txtBoxInputDescription.Size = new System.Drawing.Size(411, 53);
            this.txtBoxInputDescription.TabIndex = 1;
            // 
            // txtBoxInputQuantity
            // 
            this.txtBoxInputQuantity.Font = new System.Drawing.Font("Minecraft Dungeons", 18F);
            this.txtBoxInputQuantity.Location = new System.Drawing.Point(277, 323);
            this.txtBoxInputQuantity.Name = "txtBoxInputQuantity";
            this.txtBoxInputQuantity.Size = new System.Drawing.Size(411, 53);
            this.txtBoxInputQuantity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecraft Dungeons", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Item to Inventory";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.Location = new System.Drawing.Point(277, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(411, 56);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmit.Font = new System.Drawing.Font("Minecraft Dungeons", 12F);
            this.lblSubmit.Location = new System.Drawing.Point(438, 410);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(89, 30);
            this.lblSubmit.TabIndex = 5;
            this.lblSubmit.Text = "Submit";
            this.lblSubmit.Click += new System.EventHandler(this.BtnSubmitClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minecraft Dungeons", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minecraft Dungeons", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(694, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Minecraft Dungeons", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxInputQuantity);
            this.Controls.Add(this.txtBoxInputDescription);
            this.Controls.Add(this.txtBoxInputName);
            this.Font = new System.Drawing.Font("Minecraft Dungeons", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddItemForm";
            this.Text = "John Aquino - Add Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCloseEvent);
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInputName;
        private System.Windows.Forms.TextBox txtBoxInputDescription;
        private System.Windows.Forms.TextBox txtBoxInputQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSubmit;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}