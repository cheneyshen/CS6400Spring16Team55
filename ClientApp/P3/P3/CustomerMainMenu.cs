using System;
using System.Windows.Forms;

namespace P3
{
    public partial class CustomerMainMenu : Form
    {
        private Login _parent;

        public CustomerMainMenu(Login parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckAvailability ca = new CheckAvailability(this);
            ca.Show();
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            MakeReservation mr = new MakeReservation(this);
            mr.Show(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parent.ResetTxt();
            _parent.Show(); 
        }

        private void CustomerMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.ResetTxt();
            _parent.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerProfile c = new CustomerProfile(this);
            c.Show();
        }
    }
}
