using System;
using System.Windows.Forms;

namespace P3
{
    public partial class GenerateReports : Form
    {
        private Form _parent;
        public GenerateReports(Form parent)
        {
            _parent = parent;
            InitializeComponent();
        } 

        private void GenerateReports_Load(object sender, EventArgs e)
        {
        }

        private void OnShowReport1Click(object sender, System.EventArgs e)
        {
            Report1Form p = new Report1Form();
            p.Show();
        }

        private void OnShowReport2Click(object sender, System.EventArgs e)
        {
            Report2Form p = new Report2Form();
            p.Show();
        }

        private void OnShowReport3Click(object sender, System.EventArgs e)
        {
            Report3Form p = new Report3Form();
            p.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            
            string selectedReport = (string)comboBox.SelectedItem;
            int resultIndex = comboBox.FindStringExact(selectedReport);
            
            switch (resultIndex)
            {
                case 0:
                    OnShowReport1Click(this, EventArgs.Empty);
                    break;
                case 1:
                    OnShowReport2Click(this, EventArgs.Empty);
                    break;
                case 2:
                    OnShowReport3Click(this, EventArgs.Empty);
                    break;
                default:
                    OnShowReport1Click(this, EventArgs.Empty);
                    break;

            }
        }

        private void GenerateReports_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
    }
}
