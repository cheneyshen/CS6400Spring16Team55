using System;
using System.Windows.Forms;

namespace P3
{
    public partial class ClerkMainMenu : Form
    {
        private Login _parent;

        public ClerkMainMenu(Login parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.ResetTxt();
            _parent.Show(); 
        }

        private void btnPickUpReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            PickUp p = new PickUp(this);
            p.Show();
        }

        private void btnServiceOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServiceOrderRequest so = new ServiceOrderRequest(this);
            so.Show();
        }

        private void ClerkMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            _parent.ResetTxt();
            _parent.Show();
        }

        private void btnDropOffReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DropOff p = new DropOff(this);
            p.Show();
        }

        private void btnAddNewTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTool p = new AddTool(this);
            p.Show();
        }

        private void btnSellTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellTool p = new SellTool(this);
            p.Show();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateReports p = new GenerateReports(this);
            p.Show();
        }
    }
}
