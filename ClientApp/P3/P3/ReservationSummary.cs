using System.Windows.Forms;

namespace P3
{
    public partial class ReservationSummary : Form
    {
        private Form _parent;

        public ReservationSummary(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }  

        private void ReservationSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
    }
}
