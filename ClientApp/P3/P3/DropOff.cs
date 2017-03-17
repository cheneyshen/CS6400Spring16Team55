using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class DropOff : Form
    {
        private Form _parent;
        string _connstr = Utility.GetConnectionString();
        public static string reservationNum = null;

        public DropOff(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            lbl_invalidRes.Visible = false;
        }

        private void DropOff_FormClosed(object sender, FormClosedEventArgs e)
        {
            lbl_invalidRes.Visible = false;
            this.Hide();
            _parent.Show();
        }


        private void btn_retrieveRes_Click(object sender, EventArgs e)
        {
            loadReservation();
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
                        btn_retrieveRes.Visible = false;
                        btn_dropOff.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred ! .. " + ex);
                    }
            }
        }

        private void btn_dropOff_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(_connstr))
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                    try
                    {
                        cmd.CommandText = "UPDATE reservation " +
                                          "SET clerk_id_dropoff = '" + Login.LoggedUserId +
                                          "' WHERE Reservation_ID = " + txt_ResNum.Text.Trim();

                        conn.Open();
                        Console.WriteLine(cmd.CommandText + "\n");
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

                        RentalReceipt rc = new RentalReceipt(this);
                        rc.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred ! .. " + ex);
                    }
            }
        }

    }
}
