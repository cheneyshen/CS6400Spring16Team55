using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class RentalContract : Form
    {

        private Form _parent;
        string _connstr = Utility.GetConnectionString();

        public RentalContract(Form parent)
        {
            InitializeComponent();
            _parent = parent;
            LoadRental();
        }

        private void RentalContract_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }

        private void LoadRental()
        {
            txt_resNum.Text = PickUp.reservationNum;
            txt_clerk.Text = Login.LoggedUserId;
            using (MySqlConnection conn = new MySqlConnection(_connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                    try
                    {
                        cmd.CommandText = "SELECT concat(c.first_name, ' ', c.last_name) as custname , r.credit_card_number, r.start_date, r.end_date " +
                                          "FROM reservation r " +
                                          "INNER JOIN customer c ON c.email = r.email " +
                                          "WHERE r.Reservation_ID = " + txt_resNum.Text.Trim() +
                                          "; SELECT t.tool_id, t.abbr_description " +
                                          "FROM reservation r " +
                                          "INNER JOIN reservationtool rt ON r.Reservation_ID = rt.Reservation_ID " + 
                                          "INNER JOIN tool t ON rt.Tool_ID = t.Tool_ID " +
                                          "WHERE r.Reservation_ID = " + txt_resNum.Text.Trim() +
                                          "; SELECT SUM(datediff(r.end_date, r.start_date ) * t.rent_cost) AS rental_price, " +
                                          "SUM(t.deposit_cost) as deposit_cost, " + 
                                          "SUM(datediff(r.end_date, r.start_date ) * t.rent_cost) + SUM(t.deposit_cost) as total " +
                                          "FROM reservation r " +
                                          "INNER JOIN reservationtool rt ON r.Reservation_ID = rt.Reservation_ID " +
                                          "INNER JOIN tool t ON rt.Tool_ID = t.Tool_ID " +
                                          "WHERE r.Reservation_ID = " + txt_resNum.Text.Trim();

                        cmd.Connection = conn;
                        Console.WriteLine(cmd.CommandText + "\n");
                        conn.Open();

                        listView1.Columns[0].TextAlign = HorizontalAlignment.Center;

                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            txt_custNum.Text = dr["custname"].ToString();
                            txt_ccNum.Text = dr["credit_card_number"].ToString();
                            txt_startDate.Text = dr["start_date"].ToString();
                            txt_endDate.Text = dr["end_date"].ToString();
                        }

                        dr.NextResult();

                        while (dr.Read())
                        {
                            ListViewItem item = new ListViewItem(dr["Tool_id"].ToString());
                            item.SubItems.Add(dr["abbr_description"].ToString());
                            listView1.Items.Add(item);
                        }
                        
                        dr.NextResult();

                        while (dr.Read())
                        {
                            txt_estRental.Text = String.Format("{0:C}", dr["rental_price"]);
                            txt_deposit.Text = String.Format("{0:C}", dr["deposit_cost"]);


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
