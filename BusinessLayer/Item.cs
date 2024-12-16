using System.Drawing;
using System.Windows.Forms;

namespace Milestone7.BusinessLayer
{
    internal class Item
    {
        private Font DUNGEONS_FONT = new Font("Minecraft Dungeons", 12, FontStyle.Regular);
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public PictureBox PictureBox { get; set; }
        public int x;
        public int y;
        public Label Label { get; set; }
        public Item() {
            PictureBox = new PictureBox();
            Label = new Label
            {
                Text = null,
                Font = DUNGEONS_FONT
            };
            Redraw();
        }

        public void IncrementQty()
        {
            if (Quantity + 1 > 64) return;
            Quantity++;
            Redraw();
        }

        public void DecrementQty()
        {
            if (Quantity - 1 < 0)
            {
                Name = null;
                Description = null;
                ImagePath = null;
                return;
            }
            Quantity--;
            Redraw();
        }

        public void CopyTo(Item item)
        {
            item.ImagePath = ImagePath;
            item.Name = Name;
            item.Description = Description;
            item.Quantity = Quantity;
            item.PictureBox.ImageLocation = PictureBox.ImageLocation;
            item.Label.Text = Label.Text;

            Redraw();
            item.Redraw();
        }

        public void SwapWith(Item item)
        {
            if (item == null) return;
            (Name, item.Name) = (item.Name, Name);
            (Description, item.Description) = (item.Description, Description);
            (ImagePath, item.ImagePath) = (item.ImagePath, ImagePath);
            (Quantity, item.Quantity) = (item.Quantity, Quantity);
            item.Redraw();
            Redraw();
        }

        public void Delete()
        {
            ImagePath = null;
            Name = null;
            Description = null;
            Quantity = 0;
            Redraw();
        }

        public bool Exists()
        {
            return ImagePath != null && Name != null && Description != null;
        }

        public void Redraw()
        {
            PictureBox.Invalidate();
            PictureBox.ImageLocation = ImagePath;
            if (ImagePath != null)
            {
                Label.Text = Quantity.ToString();
                Label.Parent = PictureBox;
                Label.ForeColor = Color.White;
            } else
            {
                Label.Text = null;
            }
        }
    }
}
