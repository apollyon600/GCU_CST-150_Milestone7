using Milestone7.BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Milestone7.PresentationLayer
{
    public partial class InventoryForm : Form
    {
        private Font DUNGEONS_FONT = new Font("Minecraft Dungeons", 12, FontStyle.Regular);
        private Item SelectedItem;
        private bool IsSplitting;
        private InventoryManager Inventory { get; }
        public Home Reference { get; set; }

        public InventoryForm()
        {
            InitializeComponent();

            this.Inventory = new InventoryManager();

            this.lblToolTip.Visible = false;
            this.btnDecQty.Visible = false;
            this.btnIncQty.Visible = false;

            this.picBoxApollo.Parent = picInventory;

            RenderSlots();
        }

        private void RenderSlots()
        {
            // Attributes for clearer stuff
            int rows = 4;
            int columns = 9;
            int boxSize = 50;
            int spacing = 6;

            int startX = spacing + 20;
            int startY = -20 + picInventory.ClientSize.Height - boxSize - spacing;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    int finalRow = row;
                    int finalCol = col;

                    Item item = Inventory.GetItem(InventoryManager.InventoryType.PLAYER, finalRow, finalCol);
                    item.PictureBox = new PictureBox
                    {
                        Size = new Size(boxSize, boxSize),
                        Location = new Point(startX + (col * (boxSize + spacing)), -(row > 0 ? 10 : 0) + startY - (row * (boxSize + spacing))),
                        BorderStyle = BorderStyle.FixedSingle,
                    };
                    item.Label = new Label
                    {
                        Text = null,
                        Font = DUNGEONS_FONT
                    };
                    item.Label.Parent = item.PictureBox;

                    item.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    item.PictureBox.ImageLocation = item?.ImagePath;
                    item.PictureBox.Parent = picInventory;
                    item.PictureBox.Click += (s, e) =>
                    {
                        if (SelectedItem == item)
                        {
                            SelectedItem.PictureBox.BackColor = Color.Transparent;
                            SelectedItem.Redraw();
                            SelectedItem = null;

                            lblToolTip.Visible = false;
                            btnDecQty.Visible = false;
                            btnIncQty.Visible = false;
                        }
                        else
                        {
                            if (SelectedItem != null)
                            {
                                Inventory.HandleItems(
                                    InventoryManager.InventoryType.PLAYER,
                                    SelectedItem, item, 
                                    IsSplitting
                                );

                                SelectedItem.PictureBox.BackColor = Color.Transparent;
                                SelectedItem.Redraw();
                                SelectedItem = null;
                                
                                lblToolTip.Visible = false;
                                btnDecQty.Visible = false;
                                btnIncQty.Visible = false;
                            }
                            else
                            {
                                SelectedItem = item;
                                
                                IsSplitting = (e as MouseEventArgs).Button == MouseButtons.Right;
                                SelectedItem.PictureBox.BackColor = IsSplitting ? Color.Aqua : Color.Yellow;
                                
                                Item selectedItem = Inventory.GetItem(InventoryManager.InventoryType.PLAYER, finalRow, finalCol);
                                if (selectedItem != null)
                                {
                                    lblToolTip.Visible = true;
                                    btnDecQty.Visible = true;
                                    btnIncQty.Visible = true;
                                    lblToolTip.Text = $"{selectedItem.Name}\n{selectedItem.Description}";
                                }
                            }
                        }
                    };
                    item.PictureBox.Cursor = Cursors.Hand;
                    picInventory.Controls.Add(item.PictureBox);
                    picInventory.Controls.Add(item.Label);
                    item.Redraw();
                }
            }
        }

        private void BtnBackToMenuEvent(object sender, EventArgs e)
        {
            Inventory.Save();
            this.Hide();
            Reference.Show();
        }

        private void InventoryCloseEvent(object sender, FormClosedEventArgs e)
        {
            Inventory.Save();
            this.Hide();
        }

        private void BtnOpenChestClickEvent(object sender, EventArgs e)
        {
            OpenChestMenu();
        }

        private void LblOpenChestClickEvent(object sender, EventArgs e)
        {
            OpenChestMenu();
        }

        public void Render()
        {
            InventoryForm form = new InventoryForm();
            form.Reference = Reference;
            form.Show();
        }

        private void OpenChestMenu()
        {
            ChestForm chestForm = new ChestForm(Inventory, null);
            chestForm.Reference = this;
            this.Hide();
            chestForm.Show();
        }

        private void BtnDecQtyEvent(object sender, EventArgs e)
        {
            if (SelectedItem == null) return;
            SelectedItem.DecrementQty();
        }

        private void BtnIncQtyEvent(object sender, EventArgs e)
        {
            if (SelectedItem == null) return;
            SelectedItem.IncrementQty();
        }

        private void BtnOpenCreativeEvent(object sender, EventArgs e)
        {

        }

        private void LblBtnOpenCreativeEvent(object sender, EventArgs e)
        {
            AddItemForm addForm = new AddItemForm(Inventory);
            addForm.Reference = this;
            this.Hide();
            addForm.Show();
        }
    }
}
