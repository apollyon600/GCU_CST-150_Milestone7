using Milestone7.PresentationLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Milestone7
{
    public partial class Milestone7 : Form
    {
        public static Font DUNGEONS_FONT = new Font("Minecraft Dungeons", 12, FontStyle.Regular);
        public Milestone7()
        {
            InitializeComponent();

            this.btnStartGame.Paint += new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                string label = "Start Game";

                SizeF textSize = e.Graphics.MeasureString(label, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (btnStartGame.Width / 2.7f) - (textSize.Width / 2.7f);
                locationToDraw.Y = (btnStartGame.Height / 4) - (textSize.Height / 4);

                e.Graphics.DrawString(label, DUNGEONS_FONT, Brushes.Black, locationToDraw);
            });

            this.btnExitGame.Paint += new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                string label = "Exit Game";

                SizeF textSize = e.Graphics.MeasureString(label, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (btnStartGame.Width / 2.5f) - (textSize.Width / 2.5f);
                locationToDraw.Y = (btnStartGame.Height / 4) - (textSize.Height / 4);

                e.Graphics.DrawString(label, DUNGEONS_FONT, Brushes.Black, locationToDraw);
            });
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // open form
            InventoryForm inventory = new InventoryForm();

            inventory.Reference = this;

            this.Hide();
            inventory.Render();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            // exit form

            this.Close();
        }
    }
}
