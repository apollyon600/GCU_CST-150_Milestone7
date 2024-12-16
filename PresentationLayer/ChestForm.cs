using Milestone7.BusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Milestone7.PresentationLayer
{
    public partial class ChestForm : Form
    {
        private Font DUNGEONS_FONT = new Font("Minecraft Dungeons", 12, FontStyle.Regular);
        
        private bool IsSplitting;
        private bool IsReopening;
        private string Filter;
        
        private Item SelectedInventoryItem;
        private Item SelectedChestItem;

        public InventoryForm Reference { get; set; }
        private InventoryManager Inventory;
        

        internal ChestForm(InventoryManager Inventory, string filter)
        {
            InitializeComponent();
            this.Inventory = Inventory;
            this.Filter = filter;

            this.picBoxSubmit.Cursor = Cursors.Hand;

            RenderSlots();
        }

        private void RenderSlots()
        {

            // inventory shit
            // attributes for clearer stuff
            int rows = 4;
            int columns = 9;
            int boxSize = 50;
            int spacing = 6;

            int startX = spacing + 20;
            int startY = -20 + picChest.ClientSize.Height - boxSize - spacing;

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
                        Text = item.Quantity.ToString(),
                        Font = DUNGEONS_FONT
                    };
                    item.Label.Parent = item.PictureBox;

                    if (!((Filter == null || item.Exists() && item.Name.ToLower().Contains(Filter.ToLower())))) continue;

                    item.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    item.PictureBox.ImageLocation = item?.ImagePath;
                    item.PictureBox.Parent = picChest;
                    item.PictureBox.Click += (s, e) =>
                    {
                        if (SelectedChestItem != null)
                        {
                            if (item.Exists())
                            {
                                Inventory.HandleItems(
                                        InventoryManager.InventoryType.PLAYER,
                                        SelectedInventoryItem, item,
                                        IsSplitting
                                    );
                                SelectedInventoryItem.PictureBox.BackColor = Color.Transparent;
                            }

                            SelectedChestItem = null;
                            return;
                        }

                        if (SelectedInventoryItem == item)
                        {
                            SelectedInventoryItem.PictureBox.BackColor = Color.Transparent;
                            SelectedInventoryItem = null;
                        }
                        else
                        {
                            if (SelectedInventoryItem != null)
                            {
                                    Inventory.HandleItems(
                                        InventoryManager.InventoryType.PLAYER,
                                        SelectedInventoryItem, item,
                                        IsSplitting
                                    );
                                SelectedInventoryItem.PictureBox.BackColor = Color.Transparent;
                                SelectedInventoryItem = null;
                            }
                            else
                            {
                                SelectedInventoryItem = item;
                                IsSplitting = (e as MouseEventArgs).Button == MouseButtons.Right;
                                SelectedInventoryItem.PictureBox.BackColor = IsSplitting ? Color.Aqua : Color.Yellow;
                            }
                        }
                    };

                    item.PictureBox.Cursor = Cursors.Hand;
                    picChest.Controls.Add(item.PictureBox);
                    picChest.Controls.Add(item.Label);
                    item.Redraw();
                }
            }

            // chest shit
            rows = 3;
            startY += -275;
            columns = 9;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    int finalRow = row;
                    int finalCol = col;

                    Item item = Inventory.GetItem(InventoryManager.InventoryType.CHEST, finalRow, finalCol);

                    item.PictureBox = new PictureBox
                    {
                        Size = new Size(boxSize, boxSize),
                        Location = new Point(startX + (col * (boxSize + spacing)), startY - (row * (boxSize + spacing))),
                        BorderStyle = BorderStyle.FixedSingle,
                    };
                    item.Label = new Label
                    {
                        Text = null,
                        Font = DUNGEONS_FONT
                    };
                    item.Label.Parent = item.PictureBox;

                    item.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    item.PictureBox.ImageLocation = Inventory.GetItem(InventoryManager.InventoryType.CHEST, finalRow, finalCol)?.ImagePath;
                    item.PictureBox.Parent = picChest;
                    item.PictureBox.Click += (s, e) =>
                    {
                        if (SelectedChestItem != null)
                        {
                            if (item.Exists())
                            {
                                Inventory.HandleItems(
                                        InventoryManager.InventoryType.PLAYER,
                                        SelectedInventoryItem, item,
                                        IsSplitting
                                    );
                                SelectedInventoryItem.PictureBox.BackColor = Color.Transparent;
                            }

                            SelectedChestItem = null;
                            return;
                        }

                        if (SelectedInventoryItem == item)
                        {
                            SelectedInventoryItem.PictureBox.BackColor = Color.Transparent;
                            SelectedInventoryItem = null;
                        }
                        else
                        {
                            if (SelectedInventoryItem != null)
                            {
                                Inventory.HandleItems(
                                    InventoryManager.InventoryType.PLAYER,
                                    SelectedInventoryItem, item,
                                    IsSplitting
                                );
                                SelectedInventoryItem.PictureBox.BackColor = Color.Transparent;
                                SelectedInventoryItem = null;
                            }
                            else
                            {
                                SelectedInventoryItem = item;
                                IsSplitting = (e as MouseEventArgs).Button == MouseButtons.Right;
                                SelectedInventoryItem.PictureBox.BackColor = IsSplitting ? Color.Aqua : Color.Yellow;
                            }
                        }
                    };

                    item.PictureBox.Cursor = Cursors.Hand;
                    picChest.Controls.Add(item.PictureBox);
                    picChest.Controls.Add(item.Label);
                    item.Redraw();
                }
            }
        }

        private void FormCloseEvent(object sender, FormClosedEventArgs e)
        {
            Inventory.Save();
            if (!IsReopening)
                Reference.Render();
        }

        private void BtnExitChestEvent(object sender, EventArgs e)
        {
            Inventory.Save();
            Reference.Render();
            this.Hide();
        }

        private void PicBoxSubmitClickEvent(object sender, EventArgs e)
        {
            IsReopening = true;
            Filter = txtBoxInputFilter.Text;
            this.Close();
            ChestForm chest = new ChestForm(Inventory, Filter);
            chest.Reference = Reference; 
            chest.Show();
        }
    }
}
