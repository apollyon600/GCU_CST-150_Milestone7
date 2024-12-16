using System.Windows.Forms;

namespace Milestone7.PresentationLayer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            lblExitGame.Parent = btnExitGame;
            lblStartGame.Parent = btnStartGame;
        }

        private void BtnStartGameEvent(object sender, System.EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Reference = this;
            this.Hide();
            inventoryForm.Show();
        }

        private void BtnExitGameEvent(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
