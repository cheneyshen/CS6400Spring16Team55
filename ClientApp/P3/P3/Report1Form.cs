using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3
{
    public partial class Report1Form : Form
    {
        public Report1Form()
        {
            InitializeComponent();
        }

        private void Report1Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'team55_dbDataSet.report1_proc' table. You can move, or remove it, as needed.
            this.report1_procTableAdapter.Fill(this.team55_dbDataSet.report1_proc);

            this.reportViewer1.RefreshReport();
        }
    }
}
