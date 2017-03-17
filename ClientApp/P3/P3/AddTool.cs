using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace P3
{
    public partial class AddTool : Form
    {
        string connstr = Utility.GetConnectionString();
        private Form _parent;

        public AddTool(Form parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }

        private void AddTool_Load(object sender, EventArgs e)
        {
            txtAccessories.Enabled = false;
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query = "select Tool_Type_ID, tool_type_name from tooltype";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    Console.WriteLine(query + "\n");
                    conn.Open();
                    DataSet ds1 = new DataSet();
                    da.Fill(ds1, "ToolTypes");
                    cbToolType.DisplayMember = "tool_type_name";
                    cbToolType.ValueMember = "Tool_Type_ID";
                    cbToolType.DataSource = ds1.Tables["ToolTypes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred ! .. " + ex);
                }
            }
        }

        private void cbToolType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // if tool type selected is Power Tools then enable Accessories
            // otherwise disable Accessories and remove any text that exists
            ComboBox cb = (ComboBox) sender;
            string sToolType = cb.SelectedValue.ToString();
            if (sToolType == "3")
            {
                txtAccessories.Enabled = true;
            }
            else
            {
                txtAccessories.Enabled = false;
                txtAccessories.Text = "";
            }
            
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //save data; insert a new tool record
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO tool " +
                                          "(Tool_Type_ID, rent_cost, deposit_cost, description, " +
                                          "orig_purchase_price, abbr_description, on_sale, " +
                                          "marked_for_sale_by, added_by, accessories) " +
                                          " VALUES (@tool_type_id, @rent_cost, @deposit_cost, @description, " +
                                          "@orig_purchase_price, @abbr_description, False, " +
                                          "NULL, @loggedinClerk, @accessories)";

                        cmd.Parameters.AddWithValue("@tool_type_id", cbToolType.SelectedValue);
                        cmd.Parameters.AddWithValue("@rent_cost", Convert.ToInt32(txtRentPrice.Text.Trim().ToString()));
                        cmd.Parameters.AddWithValue("@deposit_cost", Convert.ToInt32(txtDepositPrice.Text.Trim().ToString()));
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim().ToString());
                        cmd.Parameters.AddWithValue("@orig_purchase_price", Convert.ToInt32(txtPurchasePrice.Text.Trim().ToString()));
                        cmd.Parameters.AddWithValue("@abbr_description", txtAbbrDescription.Text.Trim().ToString());
                        cmd.Parameters.AddWithValue("@loggedinClerk", Login.LoggedUserId.Trim());
                        cmd.Parameters.AddWithValue("@accessories", txtAccessories.Text.Trim().ToString());
                        conn.Open();
                        Console.WriteLine(cmd.CommandText + "\n");
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        // reset all the fields to default state
                        cbToolType.SelectedValue = "1";
                        txtRentPrice.Text = "";
                        txtDepositPrice.Text = "";
                        txtDescription.Text = "";
                        txtPurchasePrice.Text = "";
                        txtAbbrDescription.Text = "";
                        txtAccessories.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred ! .. " + ex);
                    }
                }
            }
        }
    }
}
