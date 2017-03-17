using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class PickUp : Form
    {
        private Form _parent;
        string _connstr = Utility.GetConnectionString();
        public static string reservationNum = null;

        public PickUp(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            lbl_invalidRes.Visible = false;
            lbl_ccMessage.Visible = false;

        }   

        private void PickUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            lbl_invalidRes.Visible = false;
            lbl_ccMessage.Visible = false;
            btn_retrieveRes.Visible = true;
            btn_PickUp.Visible = false;
            this.Hide();
            _parent.Show();
        }

        private void btn_PickUp_Click(object sender, EventArgs e)
        {
            if (!(txt_CCNum.Text == "" || txt_ExpDate.Text == ""))
            {
                using (MySqlConnection conn = new MySqlConnection(_connstr))
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                        try
                        {
                            cmd.CommandText = "UPDATE reservation " +
                                              "SET credit_card_number = @ccnum, credit_card_expiration = @ccexp, clerk_id_pickup = @clerk_id_pickup " +
                                              "WHERE Reservation_ID = " + txt_ResNum.Text.Trim();

                            cmd.Parameters.AddWithValue("@ccnum", txt_CCNum.Text.Trim());
                            cmd.Parameters.AddWithValue("@ccexp", txt_ExpDate.Text.Trim());
                            cmd.Parameters.AddWithValue("@clerk_id_pickup", Login.LoggedUserId);
                            Console.WriteLine(cmd.CommandText + "\n");
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            reservationNum = txt_ResNum.Text.Trim();
                            this.Hide();
                            btn_retrieveRes.Visible = true;
                            txt_ResNum.Text = null;
                            txt_CCNum.Text = null;
                            txt_ExpDate.Text = null;
                            txt_DepReq_static.Text = null;
                            txt_EstCost_static.Text = null;
                            listView1.Items.Clear();
                            lbl_ccMessage.Visible = false;

                            RentalContract rc = new RentalContract(this);
                            rc.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error occurred ! .. " + ex);
                        }
                }
            }
            else
            {
                lbl_ccMessage.Visible = true;
            }
            
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(_connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                try
                {
                    cmd.CommandText = "SELECT tool_id, abbr_description, rent_cost, deposit_cost " +
                                    "FROM tool " +
                                     "WHERE tool_ID = " + txt_ToolId.Text.Trim();
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
                    txt_ToolId.Text = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred ! .. " + ex);
                }
            }
        }

        private void btn_retrieveRes_Click(object sender, EventArgs e)
        {
         
            lbl_invalidRes.Visible = false;

            using (MySqlConnection conn = new MySqlConnection(_connstr))
            {
                try
                {
                    bool validRes = false;
                    string query =
                    "select * " +
                    " from reservation " +
                    "where reservation_id = " + txt_ResNum.Text.Trim();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    Console.WriteLine(query + "\n");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        validRes = true;
                    }

                    if (!validRes)
                    {
                        lbl_invalidRes.Visible = true;
                    }
                    else
                    {
                        loadReservation();
                        btn_retrieveRes.Visible = false;
                        btn_PickUp.Visible = true;
                        btn_PickUp.Enabled = true;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred ! .. " + ex);
                }
            }
            
        }

        private void loadReservation()
        {
            using (MySqlConnection conn = new MySqlConnection(_connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                try
                {
                    cmd.CommandText = "SELECT t.tool_id, t.abbr_description " +
                                    "FROM reservation r " +
                                    "INNER JOIN reservationtool rt ON r.Reservation_ID = rt.Reservation_ID " +
                                    "INNER JOIN tool t ON rt.Tool_ID = t.Tool_ID " +
                                     "WHERE r.Reservation_ID = " + txt_ResNum.Text.Trim() +
                                     "; SELECT SUM(datediff(r.end_date, r.start_date ) * t.rent_cost) AS rental_price, " +
                                     "SUM(t.deposit_cost) as deposit_cost " +
                                     "FROM reservation r " +
                                     "INNER JOIN reservationtool rt ON r.Reservation_ID = rt.Reservation_ID " +
                                     "INNER JOIN tool t ON rt.Tool_ID = t.Tool_ID " +
                                     "WHERE r.Reservation_ID = " + txt_ResNum.Text.Trim();
                    cmd.Connection = conn;
                    Console.WriteLine(cmd.CommandText + "\n");
                    conn.Open();
                    
                    listView1.Columns[0].TextAlign = HorizontalAlignment.Center;

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["Tool_id"].ToString());
                        item.SubItems.Add(dr["abbr_description"].ToString());
                        listView1.Items.Add(item);
                    }

                    dr.NextResult();

                    while (dr.Read())
                    {
                        txt_DepReq_static.Text = String.Format("{0:C}", dr["deposit_cost"]);
                        txt_EstCost_static.Text = String.Format("{0:C}", dr["rental_price"]);

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
}
