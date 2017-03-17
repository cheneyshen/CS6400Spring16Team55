using System;
using System.Windows.Forms;

namespace P3
{
    public partial class ReservationFinal : Form
    {
        private Form _parent;

        public ReservationFinal(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.Show();
        }

        private void ReservationFinal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
    }
}
