using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class CheckAvailability : Form
    {
        string connstr = P3.Utility.GetConnectionString();
        private Form _parent;
        public CheckAvailability(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        } 
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand()) 
                {
                    try
                    {
                        // determine which tool type was selected
                        string sToolType = '0'.ToString();
                        if (optHandTools.Checked)
                        {
                            sToolType = '1'.ToString();
                        }
                        else if (optConstruction.Checked)
                        {
                            sToolType = '2'.ToString();
                        }
                        else if (optPowerTools.Checked)
                        {
                            sToolType = '3'.ToString();
                        }
                        string query =
                        "select t.Tool_ID, t.abbr_description, t.deposit_cost, t.rent_cost, CONCAT(t.Tool_ID, ' - ', t.abbr_description, ' -  $', t.rent_cost) as display " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID not in ( " +
                        "SELECT t.Tool_ID " +
                        "from reservation r " +
                        "LEFT JOIN reservationtool rt on r.Reservation_ID = rt.Reservation_ID " +
                        "LEFT JOIN tool t on rt.Tool_ID = t.Tool_ID  " +
                        "where 1=1 " +
                        "and (r.start_date BETWEEN '" + dateTimePickerStart.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePickerEnd.Value.ToString("yyyy-MM-dd") + "' OR " +
                        "r.end_date BETWEEN '" + dateTimePickerEnd.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePickerEnd.Value.ToString("yyyy-MM-dd") + "' OR " +
                        "'" + dateTimePickerEnd.Value.ToString("yyyy-MM-dd") + "' BETWEEN r.start_date and r.end_date) " +
                        ") " +
                        "and t.Tool_ID not in ( " +
                        "SELECT s.Tool_ID " +
                        "from serviceorder s " +
                        "where 1=1 " +
                        "and (s.start_date BETWEEN '" + dateTimePickerStart.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePickerEnd.Value.ToString("yyyy-MM-dd") + "' OR " +
                        "s.end_date BETWEEN '" + dateTimePickerStart.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePickerEnd.Value.ToString("yyyy-MM-dd") + "' OR " +
                        "'" + dateTimePickerEnd.Value.ToString("yyyy-MM-dd") + "' BETWEEN s.start_date and s.end_date) " +
                        ") " +
                        "and t.tool_type_id = " + sToolType + " " +
                        "and t.on_sale = False ";
                        Console.WriteLine(query + "\n");
                        //populate the listview
                        cmd.CommandText = query;
                        cmd.Connection = conn; 
                        conn.Open();
                        listView1.Columns[0].TextAlign = HorizontalAlignment.Center;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            ListViewItem item = new ListViewItem(dr["Tool_id"].ToString());
                            item.SubItems.Add(dr["abbr_description"].ToString());
                            item.SubItems.Add(String.Format("{0:C}", dr["rent_cost"]));
                            item.SubItems.Add(String.Format("{0:C}", dr["deposit_cost"]));
                            listView1.Items.Add(item);
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred ! .. " + ex);
                    }
                }
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    try
                    {
                        cmd.CommandText = "SELECT tool_id, abbr_description, rent_cost, deposit_cost " +
                                        "FROM tool " +
                                         "WHERE tool_ID = " + txtToolID.Text.Trim();
                        cmd.Connection = conn;
                        Console.WriteLine(cmd.CommandText + "\n");
                        conn.Open();
                        listView2.Columns[0].TextAlign = HorizontalAlignment.Center;
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            ListViewItem item = new ListViewItem(dr["Tool_id"].ToString());
                            item.SubItems.Add(dr["abbr_description"].ToString());
                            item.SubItems.Add(String.Format("{0:C}", dr["rent_cost"]));
                            item.SubItems.Add(String.Format("{0:C}", dr["deposit_cost"]));
                            listView2.Items.Add(item);
                        }
                        conn.Close();
                        txtToolID.Text = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred ! .. " + ex);
                    }
                }
            }
        }

        private void CheckAvailability_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
    }
}
