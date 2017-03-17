using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class SellTool : Form
    {
        string connstr = Utility.GetConnectionString();
        private Form _parent;

        public SellTool(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            lblMessage.Text = "";
        }

        private void SellTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }

        private void btnMarkForSale_Click(object sender, EventArgs e)
        {
            //mark a tool for sale (on_sale = TRUE)
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        bool bFound = false;
                        string sSalePrice = "";
                        string sToolId = "";
                        cmd.CommandText = "SELECT t.*, t.orig_purchase_price/2 as sale_price " +
                                        "FROM tool t " +
                                         "WHERE tool_ID = " + Convert.ToInt32(txtToolID.Text.Trim().ToString()) + 
                                         " AND on_sale = 0 ";
                        Console.WriteLine(cmd.CommandText + "\n"); 
                        cmd.Connection = conn;
                        conn.Open();
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            sToolId = dr["Tool_ID"].ToString();
                            sSalePrice = String.Format("{0:C}", dr["sale_price"]);
                            bFound = true;
                        }
                        conn.Close();

                        if (bFound)
                        {
                            try
                            {
                                //cmd.Connection = conn;
                                conn.Open();
                                MySqlCommand cmd2 = conn.CreateCommand();
                                cmd2.CommandText = "UPDATE tool " +
                                                   "set on_sale = True, " +
                                                   "marked_for_sale_by = '" + Login.LoggedUserId + "' " +
                                                   "where Tool_ID = " + Convert.ToInt32(txtToolID.Text.Trim().ToString());
                                Console.WriteLine(cmd2.CommandText + "\n");
                                cmd2.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error occurred ! .. " + ex);
                            }
                            // reset all the fields to default state
                            txtToolID.Text = "";
                            //display sale price to the user
                            lblMessage.Text = "Tool ID #" + sToolId + " is now on sale for " + sSalePrice + "...";
                        }
                        else
                        {
                            //display message to user that the Tool ID entered was not found
                            lblMessage.Text = "Tool ID #" + txtToolID.Text.Trim().ToString() + " was not found...";
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.Show();
        }  
    }
}
