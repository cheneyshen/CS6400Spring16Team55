using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace P3
{
    public partial class CustomerProfile : Form
    {
        private Form _parent;
        private string _connStr = Utility.GetConnectionString();

        public CustomerProfile(Form parent)
        {
            InitializeComponent();
            _parent = parent;

            try
            {
                using (var conn = new MySqlConnection(_connStr))
                {
                    //bool userExist = false;
                    string query = "select * from customer c where 1=1 and c.Email = '" + Login.LoggedUserId + "' ";

                    var cmd = new MySqlCommand(query, conn);
                    conn.Open(); //open the connection

                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    txtEmail.Text = reader.GetString(0);
                    txtName.Text = reader.GetString(3) + " " + reader.GetString(4);
                    txtHomePhone.Text = reader.GetString(6);
                    txtWorkPhone.Text = reader.GetString(7);
                    txtAddress.Text = reader.GetString(5);
                    reader.Close();


                    //load data to DataGrid
                    query = "SELECT r.Reservation_ID as 'Res #', t.abbr_description as 'Tools', r.start_date as 'Start',"
                                   + " r.end_date as 'End', datediff( r.end_date, r.start_date ) * t.rent_cost as 'Rental Price', t.deposit_cost as 'Deposit',"
                                   + " c1.first_name as 'Pickup-Clerk ID', c2.first_name  as 'Drop-Off Clerk ID'"
                                   + " FROM reservation r"
                                   + " inner join reservationtool rt on r.reservation_id=rt.reservation_id"
                                   + " inner join tool t on rt.tool_id=t.tool_id"
                                   + " left join clerk c1 on c1.clerk_id = r.clerk_id_pickup "
                                   + " left join clerk c2 on c2.clerk_id = r.clerk_id_dropoff " 
                                   + " Where r.email = '" + Login.LoggedUserId + "' "
                                   + " ORDER BY r.start_date,r.Reservation_ID";
                    var mySqlDataAdapter = new MySqlDataAdapter(query, conn);
                    var dataSet = new DataSet();
                    Console.WriteLine(query + "\n");
                    mySqlDataAdapter.Fill(dataSet);
                    dgResHistory.DataSource = dataSet.Tables[0]; 
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error with Database");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            } 
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.Show();
        }

        private void CustomerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
    }
}
