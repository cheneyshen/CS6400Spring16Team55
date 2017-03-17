using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace P3
{
    public partial class CreateProfile : Form
    {
        private Login _parent;
        private string _connStr = Utility.GetConnectionString();

        public CreateProfile(Login parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();

                if (!Utility.IsValidEmail(email))
                {
                    MessageBox.Show("Invalid Email address");
                    return;
                }

                //check if the email already exist
                using (var conn = new MySqlConnection(_connStr))
                {
                    bool userExist = false;
                    string query = "select * from customer c where 1=1 and c.Email = '" + email + "' ";
                    Console.WriteLine(query + "\n");
                    var cmd = new MySqlCommand(query, conn);
                    conn.Open(); //open the connection

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                        userExist = true;

                    reader.Close();

                    if (userExist)
                    {
                        MessageBox.Show("Email address already exist !");
                        return;
                    }
                    else
                    {
                        //check password length < 5
                        if (txtPassword.Text.Length < 5)
                        {
                            MessageBox.Show("Password should have at least 5 characters");
                            return;
                        }

                        //check if passwords match
                        if (!string.Equals(txtPassword.Text, txtPasswordConf.Text))
                        {
                            MessageBox.Show("Passwords doesn't match");
                            return;
                        }

                        //check if anything is Empty
                        if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                            string.IsNullOrWhiteSpace(txtHomePhone.Text)
                            || string.IsNullOrWhiteSpace(txtWorkPhone.Text) ||
                            string.IsNullOrWhiteSpace(txtAddress.Text))
                        {
                            MessageBox.Show("Values can't be Empty");
                            return;
                        }

                        //save data
                        var cmd2 = new MySqlCommand
                        {
                            Connection = conn,
                            CommandText = "INSERT INTO customer(email, password, first_name, last_name, address, home_phone, work_phone) "
                                + "VALUES(@email, @password, @first_name, @last_name, @address, @home_phone, @work_phone)"
                        };
                        cmd2.Prepare();
                        cmd2.Parameters.AddWithValue("@email", email);
                        cmd2.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd2.Parameters.AddWithValue("@first_name", txtEmail.Text);
                        cmd2.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        cmd2.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd2.Parameters.AddWithValue("@home_phone", txtHomePhone.Text);
                        cmd2.Parameters.AddWithValue("@work_phone", txtWorkPhone.Text);
                        Console.WriteLine(cmd.CommandText + "\n");
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Customer created Successfully !\n  Please Login with your new account.");
                        this.Hide();
                        _parent.Show();
                    }
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

        private void CreateProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
    }
}
