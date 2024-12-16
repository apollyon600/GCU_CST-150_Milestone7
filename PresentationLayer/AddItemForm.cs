using Milestone7.BusinessLayer;
using System;
using System.Windows.Forms;

namespace Milestone7.PresentationLayer
{
    public partial class AddItemForm : Form
    {

        private InventoryManager Inventory;
        public InventoryForm Reference;
        internal AddItemForm(InventoryManager Inventory)
        {
            InitializeComponent();
            this.Inventory = Inventory;

            lblSubmit.Parent = btnSubmit;
        }

        private void BtnSubmitClick(object sender, EventArgs e)
        {
            if (txtBoxInputName.Text.Length == 0)
            {
                MessageBox.Show("Please supply a valid name!", "Invalid Input");
                return;
            }

            string Name = txtBoxInputName.Text.Replace(" ", "_");
            string Description = txtBoxInputDescription.Text;
            
            if (Description.Length == 0)
            {
                MessageBox.Show("Please supply a description for the item.", "Invalid Input");
                return;
            }

            if (txtBoxInputQuantity.Text.Length == 0)
            {
                MessageBox.Show("Please supply a valid quantity", "Invalid Input");
                return;
            }

            if (int.TryParse(txtBoxInputQuantity.Text, out int Quantity))
            {
                if (Quantity <= 0 || Quantity > 64)
                {
                    MessageBox.Show("Please supply a valid quantity", "Invalid Input");
                } else
                {
                    if (Inventory.IsItem(Name))
                    {
                        Inventory.AddItem(Name, Description, Quantity);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please provide a valid item.", "Invalid Input");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please supply a valid quantity", "Invalid Input");
            }
        }

        private void FormCloseEvent(object sender, FormClosedEventArgs e)
        {
            InventoryForm form = new InventoryForm();
            form.Reference = Reference.Reference;
            
            form.Show();
        }
    }
}
