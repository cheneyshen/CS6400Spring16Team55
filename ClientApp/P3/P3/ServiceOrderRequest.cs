using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P3
{
    public partial class ServiceOrderRequest : Form
    {
        private Form _parent;
        string _connstr = Utility.GetConnectionString();

        public ServiceOrderRequest(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(_connstr))
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                        try
                        {
                            cmd.CommandText = "INSERT INTO serviceorder " +
                                              "(Tool_ID, added_by, est_repair_cost, start_date, end_date) " +
                                              "VALUES (@toolID, @addedby, @estimate, @start, @end)";

                            cmd.Parameters.AddWithValue("@toolID", txt_toolID.Text.Trim());
                            cmd.Parameters.AddWithValue("@addedby", Login.LoggedUserId.Trim());
                            cmd.Parameters.AddWithValue("@estimate", txt_estimate.Text.Trim());
                            cmd.Parameters.AddWithValue("@start", txt_startDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@end", txt_endDate.Text.Trim());
                            Console.WriteLine(cmd.CommandText + "\n");
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            txt_toolID.Text = null;
                            txt_estimate.Text = null;
                            txt_startDate.Text = null;
                            txt_endDate.Text = null;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error occurred ! .. " + ex);
                        }
                }
        }

        private void ServiceOrderRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
    }
}
