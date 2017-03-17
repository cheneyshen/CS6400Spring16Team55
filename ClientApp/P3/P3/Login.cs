using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class Login : Form
    {
        string _connstr = Utility.GetConnectionString();
        public static string LoggedUserId = null; //have the customer/clerk ID accessible for other windows

        public Login()
        {
            InitializeComponent();
        }

        private void linkCreateProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateProfile cp = new CreateProfile(this);
            cp.Show();
        }

        // Login Button Click Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // if Clerk login, then authenticate using the 'clerk' table
            if (this.optClerk.Checked)
            {
                using (MySqlConnection conn = new MySqlConnection(_connstr))
                {
                    try
                    {
                        bool bLogin = false;
                        string query =
                        "select * " +
                        "from clerk c " +
                        "where 1=1 " +
                        "and c.Clerk_ID = '" + txtID.Text.Trim() + "' " +
                        "and c.password = '" + txtPassword.Text + "' ";
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bLogin = true;
                        }
                        reader.Close();

                        // successful login; show the Clerk Main Menu
                        if (bLogin)
                        {
                            LoggedUserId = txtID.Text.Trim();

                            var cmd2 = new MySqlCommand
                            {
                                Connection = conn,
                                CommandText = "UPDATE clerk SET last_login = @last_login WHERE clerk_id = @clerk_id"
                            };
                            cmd2.Prepare();
                            cmd2.Parameters.AddWithValue("@clerk_id", LoggedUserId);
                            cmd2.Parameters.AddWithValue("@last_login", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            Console.WriteLine(cmd2.CommandText + "\n");
                            cmd2.ExecuteNonQuery();

                            this.Hide();
                            var clerkMenu = new ClerkMainMenu(this);
                            clerkMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login or Password is invalid !");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred while authenticating Clerk!");
                    }
                }
            }
            // if Customer login, then authenticate using the 'customer' table
            else if (this.optCustomer.Checked)
            {
                using (MySqlConnection conn = new MySqlConnection(_connstr))
                {
                    try
                    {
                        bool bLogin = false;
                        string query =
                        "select * " +
                        "from customer c " +
                        "where 1=1 " +
                        "and c.Email = '" + txtID.Text.Trim() + "' " +
                        "and c.password = '" + txtPassword.Text + "' ";
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            bLogin = true;
                        }
                        reader.Close();

                        // successful login; show the Customer Main Menu
                        if (bLogin)
                        {
                            LoggedUserId = txtID.Text.Trim();

                            var cmd2 = new MySqlCommand
                            {
                                Connection = conn,
                                CommandText = "UPDATE customer SET last_login = @last_login WHERE Email = @email" 
                            };
                            cmd2.Prepare();
                            cmd2.Parameters.AddWithValue("@email", LoggedUserId);
                            cmd2.Parameters.AddWithValue("@last_login", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            Console.WriteLine(cmd2.CommandText + "\n");
                            cmd2.ExecuteNonQuery();

                            this.Hide();
                            var custMenu = new CustomerMainMenu(this);
                            custMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login or Password is invalid !");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred while authenticating Customer!");
                    }

                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //reset the variables in this page when it's loaded again
        public void ResetTxt()
        {
            txtID.Text = "";
            txtPassword.Text = "";
            LoggedUserId = "";
        }
    }
}