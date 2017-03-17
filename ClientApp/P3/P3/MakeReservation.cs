using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace P3
{
    public partial class MakeReservation : Form
    {

        string connstr = P3.Utility.GetConnectionString();
        private Form _parent; 

        public MakeReservation(Form parent)
        {
            InitializeComponent();
            Load += new EventHandler(MakeReservation_Load);
            _parent = parent;
            lblConfirmNumber1.Hide();
            lblConfirmNumber2.Hide();
            lblConfirmNumber2.Text = "";
        }
        private void MakeReservation_Load(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query = "select Tool_Type_ID, tool_type_name from tooltype";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds1 = new DataSet();
                    da.Fill(ds1, "ToolTypes");
                    cbType1.DisplayMember = "tool_type_name";
                    cbType1.ValueMember = "Tool_Type_ID";
                    cbType1.DataSource = ds1.Tables["ToolTypes"];
                    DataSet ds2 = new DataSet();
                    da.Fill(ds2, "ToolTypes");
                    cbType2.DisplayMember = "tool_type_name";
                    cbType2.ValueMember = "Tool_Type_ID";
                    cbType2.DataSource = ds2.Tables["ToolTypes"];
                    DataSet ds3 = new DataSet();
                    da.Fill(ds3, "ToolTypes");
                    cbType3.DisplayMember = "tool_type_name";
                    cbType3.ValueMember = "Tool_Type_ID";
                    cbType3.DataSource = ds3.Tables["ToolTypes"];
                    DataSet ds4 = new DataSet();
                    da.Fill(ds4, "ToolTypes");
                    cbType4.DisplayMember = "tool_type_name";
                    cbType4.ValueMember = "Tool_Type_ID";
                    cbType4.DataSource = ds4.Tables["ToolTypes"];
                    DataSet ds5 = new DataSet();
                    da.Fill(ds5, "ToolTypes");
                    cbType5.DisplayMember = "tool_type_name";
                    cbType5.ValueMember = "Tool_Type_ID";
                    cbType5.DataSource = ds5.Tables["ToolTypes"];
                    DataSet ds6 = new DataSet();
                    da.Fill(ds6, "ToolTypes");
                    cbType6.DisplayMember = "tool_type_name";
                    cbType6.ValueMember = "Tool_Type_ID";
                    cbType6.DataSource = ds6.Tables["ToolTypes"];
                    DataSet ds7 = new DataSet();
                    da.Fill(ds7, "ToolTypes");
                    cbType7.DisplayMember = "tool_type_name";
                    cbType7.ValueMember = "Tool_Type_ID";
                    cbType7.DataSource = ds7.Tables["ToolTypes"];
                    DataSet ds8 = new DataSet();
                    da.Fill(ds8, "ToolTypes");
                    cbType8.DisplayMember = "tool_type_name";
                    cbType8.ValueMember = "Tool_Type_ID";
                    cbType8.DataSource = ds8.Tables["ToolTypes"];
                    DataSet ds9 = new DataSet();
                    da.Fill(ds9, "ToolTypes");
                    cbType9.DisplayMember = "tool_type_name";
                    cbType9.ValueMember = "Tool_Type_ID";
                    cbType9.DataSource = ds9.Tables["ToolTypes"];
                    DataSet ds10 = new DataSet();
                    da.Fill(ds10, "ToolTypes");
                    cbType10.DisplayMember = "tool_type_name";
                    cbType10.ValueMember = "Tool_Type_ID";
                    cbType10.DataSource = ds10.Tables["ToolTypes"];
                    DataSet ds11 = new DataSet();
                    da.Fill(ds11, "ToolTypes");
                    cbType11.DisplayMember = "tool_type_name";
                    cbType11.ValueMember = "Tool_Type_ID";
                    cbType11.DataSource = ds11.Tables["ToolTypes"];
                    DataSet ds12 = new DataSet();
                    da.Fill(ds12, "ToolTypes");
                    cbType12.DisplayMember = "tool_type_name";
                    cbType12.ValueMember = "Tool_Type_ID";
                    cbType12.DataSource = ds12.Tables["ToolTypes"];
                    DataSet ds13 = new DataSet();
                    da.Fill(ds13, "ToolTypes");
                    cbType13.DisplayMember = "tool_type_name";
                    cbType13.ValueMember = "Tool_Type_ID";
                    cbType13.DataSource = ds13.Tables["ToolTypes"];
                    DataSet ds14 = new DataSet();
                    da.Fill(ds14, "ToolTypes");
                    cbType14.DisplayMember = "tool_type_name";
                    cbType14.ValueMember = "Tool_Type_ID";
                    cbType14.DataSource = ds14.Tables["ToolTypes"];
                    DataSet ds15 = new DataSet();
                    da.Fill(ds15, "ToolTypes");
                    cbType15.DisplayMember = "tool_type_name";
                    cbType15.ValueMember = "Tool_Type_ID";
                    cbType15.DataSource = ds15.Tables["ToolTypes"];
                    DataSet ds16 = new DataSet();
                    da.Fill(ds16, "ToolTypes");
                    cbType16.DisplayMember = "tool_type_name";
                    cbType16.ValueMember = "Tool_Type_ID";
                    cbType16.DataSource = ds16.Tables["ToolTypes"];
                    DataSet ds17 = new DataSet();
                    da.Fill(ds17, "ToolTypes");
                    cbType17.DisplayMember = "tool_type_name";
                    cbType17.ValueMember = "Tool_Type_ID";
                    cbType17.DataSource = ds17.Tables["ToolTypes"];
                    DataSet ds18 = new DataSet();
                    da.Fill(ds18, "ToolTypes");
                    cbType18.DisplayMember = "tool_type_name";
                    cbType18.ValueMember = "Tool_Type_ID";
                    cbType18.DataSource = ds18.Tables["ToolTypes"];
                    DataSet ds19 = new DataSet();
                    da.Fill(ds19, "ToolTypes");
                    cbType19.DisplayMember = "tool_type_name";
                    cbType19.ValueMember = "Tool_Type_ID";
                    cbType19.DataSource = ds19.Tables["ToolTypes"];
                    DataSet ds20 = new DataSet();
                    da.Fill(ds20, "ToolTypes");
                    cbType20.DisplayMember = "tool_type_name";
                    cbType20.ValueMember = "Tool_Type_ID";
                    cbType20.DataSource = ds20.Tables["ToolTypes"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void MakeReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            _parent.Show();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // insert reservation 
            // display reservation number 
            // disable all fields except "Back to Main Menu"

            // INSERT INTO Reservation
            //  (Email, start_date, end_date)
            //  VALUES ($Email, $start_date, $end_date)

            // INSERT INTO ReservationTool
            // (Reservation_ID, Tool_ID)
            // VALUES (LAST_INSERT_ID(), $Tool_ID)

            //save data
            using (var conn = new MySqlConnection(connstr))
            {
                try
                {
                    if (cbTool1.Text != "" || cbTool2.Text != "" || cbTool3.Text != "" || cbTool4.Text != "" || cbTool5.Text != "" ||
                        cbTool6.Text != "" || cbTool7.Text != "" || cbTool8.Text != "" || cbTool9.Text != "" || cbTool10.Text != "" ||
                        cbTool11.Text != "" || cbTool12.Text != "" || cbTool13.Text != "" || cbTool14.Text != "" || cbTool15.Text != "" ||
                        cbTool16.Text != "" || cbTool17.Text != "" || cbTool18.Text != "" || cbTool19.Text != "" || cbTool20.Text != "")
                    {

                        conn.Open();
                        // the use has selected at least 1 tool; enter a record into reservation 
                        // in order to get PK to be used as FK in reservationtool
                        var cmd = new MySqlCommand
                        {
                            Connection = conn,
                            CommandText = "INSERT INTO reservation(Email, start_date, end_date) " +
                                "VALUES(@email, @start_date, @end_date); SELECT LAST_INSERT_ID();"
                        };
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@email", Login.LoggedUserId);
                        cmd.Parameters.AddWithValue("@start_date", dateTimePickerStart.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@end_date", dateTimePickerEnd.Value.ToString("yyyy-MM-dd"));
                        Console.WriteLine(cmd.CommandText.ToString() + "\n");
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        lblConfirmNumber1.Visible = true;
                        lblConfirmNumber2.Visible = true;
                        lblConfirmNumber2.Text = i.ToString();
                        
                        // for each tool selected; enter a record into reservationtool
                        var comboBoxes1 = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("cbTool"));
                        foreach (var c in comboBoxes1)
                        {
                            if (c.SelectedItem != null)
                            {
                                var cmd20 = new MySqlCommand
                                {
                                    Connection = conn,
                                    CommandText = "INSERT INTO reservationtool(Reservation_ID, Tool_ID) "
                                        + "VALUES(@Reservation_ID, @Tool_ID)"
                                };
                                cmd20.Prepare();
                                cmd20.Parameters.AddWithValue("@Reservation_ID", i);
                                cmd20.Parameters.AddWithValue("@Tool_ID", c.SelectedValue);
                                Console.WriteLine(cmd20.CommandText + "\n");
                                cmd20.ExecuteNonQuery();
                            }
                        }
                        // disable all of the dropdown/comboboxes (Types and Tools)
                        var comboBoxes2 = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("cbT"));
                        foreach (var c in comboBoxes2)
                        {
                            c.Enabled = false;
                        }
                        // disable all of the "Remove Tool" buttons
                        var buttonsRemoveTool = this.Controls.OfType<Button>().Where(x => x.Name.StartsWith("btnRemoveTool"));
                        foreach (var b in buttonsRemoveTool)
                        {
                            b.Enabled = false;
                        }
                        btnSubmit.Enabled = false;
                        dateTimePickerStart.Enabled = false;
                        dateTimePickerEnd.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
                    
            }
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.Show();
        }

        // for each of the tool types dropdowns
        // when user selects a tool type then populate the corresponding tool dropdown with appropriate available tools
        private void cbToolType1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool1.DisplayMember = "display";
                    cbTool1.ValueMember = "Tool_ID";
                    cbTool1.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool2.DisplayMember = "display";
                    cbTool2.ValueMember = "Tool_ID";
                    cbTool2.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool3.DisplayMember = "display";
                    cbTool3.ValueMember = "Tool_ID";
                    cbTool3.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool4.DisplayMember = "display";
                    cbTool4.ValueMember = "Tool_ID";
                    cbTool4.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool5.DisplayMember = "display";
                    cbTool5.ValueMember = "Tool_ID";
                    cbTool5.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool6.DisplayMember = "display";
                    cbTool6.ValueMember = "Tool_ID";
                    cbTool6.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool7.DisplayMember = "display";
                    cbTool7.ValueMember = "Tool_ID";
                    cbTool7.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool8.DisplayMember = "display";
                    cbTool8.ValueMember = "Tool_ID";
                    cbTool8.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool9.DisplayMember = "display";
                    cbTool9.ValueMember = "Tool_ID";
                    cbTool9.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool10.DisplayMember = "display";
                    cbTool10.ValueMember = "Tool_ID";
                    cbTool10.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool11.DisplayMember = "display";
                    cbTool11.ValueMember = "Tool_ID";
                    cbTool11.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType12_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool12.DisplayMember = "display";
                    cbTool12.ValueMember = "Tool_ID";
                    cbTool12.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType13_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool13.DisplayMember = "display";
                    cbTool13.ValueMember = "Tool_ID";
                    cbTool13.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType14_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool14.DisplayMember = "display";
                    cbTool14.ValueMember = "Tool_ID";
                    cbTool14.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType15_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool15.DisplayMember = "display";
                    cbTool15.ValueMember = "Tool_ID";
                    cbTool15.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType16_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool16.DisplayMember = "display";
                    cbTool16.ValueMember = "Tool_ID";
                    cbTool16.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType17_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool17.DisplayMember = "display";
                    cbTool17.ValueMember = "Tool_ID";
                    cbTool17.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }

        }
        private void cbToolType18_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool18.DisplayMember = "display";
                    cbTool18.ValueMember = "Tool_ID";
                    cbTool18.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType19_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool19.DisplayMember = "display";
                    cbTool19.ValueMember = "Tool_ID";
                    cbTool19.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }
        private void cbToolType20_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sToolType = cb.SelectedValue.ToString();
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    //string query = "select Tool_ID, abbr_description, rent_cost from tool where Tool_Type_ID = 1";
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
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tools");
                    DataRow blankRow = ds.Tables["Tools"].NewRow();
                    blankRow["Tool_ID"] = 0;
                    blankRow["abbr_description"] = "";
                    blankRow["deposit_cost"] = 0;
                    blankRow["rent_cost"] = 0;
                    ds.Tables["Tools"].Rows.InsertAt(blankRow, 0);
                    cbTool20.DisplayMember = "display";
                    cbTool20.ValueMember = "Tool_ID";
                    cbTool20.DataSource = ds.Tables["Tools"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
        }

        //user is adding a tool; we need to:
        //      1. add the rent price to the Total Rent Price
        //      2. add the deposit price to the Total Deposit Price
        //      3. disable the ToolType dropdown
        //      4. disable the Tool dropdown
        private void cbTool1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox) sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool1.Enabled = false;
            cbType1.Enabled = false;
        }
        private void cbTool2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool2.Enabled = false;
            cbType2.Enabled = false;
        }
        private void cbTool3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool3.Enabled = false;
            cbType3.Enabled = false;
        }
        private void cbTool4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool4.Enabled = false;
            cbType4.Enabled = false;
        }
        private void cbTool5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool5.Enabled = false;
            cbType5.Enabled = false;
        }
        private void cbTool6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool6.Enabled = false;
            cbType6.Enabled = false;
        }
        private void cbTool7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool7.Enabled = false;
            cbType7.Enabled = false;
        }
        private void cbTool8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool8.Enabled = false;
            cbType8.Enabled = false;
        }
        private void cbTool9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool9.Enabled = false;
            cbType9.Enabled = false;
        }
        private void cbTool10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool10.Enabled = false;
            cbType10.Enabled = false;
        }
        private void cbTool11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool11.Enabled = false;
            cbType11.Enabled = false;
        }
        private void cbTool12_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool12.Enabled = false;
            cbType12.Enabled = false;
        }
        private void cbTool13_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool13.Enabled = false;
            cbType13.Enabled = false;
        }
        private void cbTool14_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool14.Enabled = false;
            cbType14.Enabled = false;
        }
        private void cbTool15_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool15.Enabled = false;
            cbType15.Enabled = false;
        }
        private void cbTool16_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool16.Enabled = false;
            cbType16.Enabled = false;
        }
        private void cbTool17_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool17.Enabled = false;
            cbType17.Enabled = false;
        }
        private void cbTool18_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool18.Enabled = false;
            cbType18.Enabled = false;
        }
        private void cbTool19_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool19.Enabled = false;
            cbType19.Enabled = false;
        }
        private void cbTool20_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string sTool = cb.SelectedValue.ToString();
            if (cb.SelectedValue.Equals(0))
            {
                lblXTotalRentPrice.Text = "0";
                lblXTotalDepositPrice.Text = "0";
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    try
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + sTool;
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iAddedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iAddedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice + iAddedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice + iAddedToolDepositPrice).ToString();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occured! .. " + ex.ToString());
                    }
                }
            }
            cbTool20.Enabled = false;
            cbType20.Enabled = false;
        }
     
        //user is removing a tool; we need to:
        //      1. subtract the rent price from the Total Rent Price
        //      2. subtract the deposit price from the Total Deposit Price
        //      3. enable the ToolType dropdown
        //      4. clear the items from the Tool dropdown
        private void btnRemoveTool1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    if (cbTool1.SelectedItem != null){
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + cbTool1.SelectedValue.ToString();
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool1.Enabled = true;
            cbTool1.DataSource = null;
            cbType1.Enabled = true;
            cbType1.SelectedValue = "1";
            cbType1.Update();
        }
        private void btnRemoveTool2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    if (cbTool2.SelectedItem != null)
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + cbTool2.SelectedValue.ToString();
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool2.Enabled = true;
            cbTool2.DataSource = null;
            cbType2.Enabled = true;
            cbType2.SelectedValue = "1";
            cbType2.Update();
        }
        private void btnRemoveTool3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    if (cbTool3.SelectedItem != null)
                    {
                        string query =
                        "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                        " from tool t " +
                        "where 1=1 " +
                        "and t.Tool_ID = " + cbTool3.SelectedValue.ToString();
                        Console.WriteLine(query + "\n");
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                            int iRentDays = tspan.Days;
                            int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                            int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                            int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                            int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                            lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                            lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool3.Enabled = true;
            cbTool3.DataSource = null;
            cbType3.Enabled = true;
            cbType3.SelectedValue = "1";
            cbType3.Update();
        }
        private void btnRemoveTool4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool4.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool4.Enabled = true;
            cbTool4.DataSource = null;
            cbType4.Enabled = true;
            cbType4.SelectedValue = "1";
            cbType4.Update();
        }
        private void btnRemoveTool5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool5.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool5.Enabled = true;
            cbTool5.DataSource = null;
            cbType5.Enabled = true;
            cbType5.SelectedValue = "1";
            cbType5.Update();
        }
        private void btnRemoveTool6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool6.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool6.Enabled = true;
            cbTool6.DataSource = null;
            cbType6.Enabled = true;
            cbType6.SelectedValue = "1";
            cbType6.Update();
        }
        private void btnRemoveTool7_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool7.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool7.Enabled = true;
            cbTool7.DataSource = null;
            cbType7.Enabled = true;
            cbType7.SelectedValue = "1";
            cbType7.Update();
        }
        private void btnRemoveTool8_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool8.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool8.Enabled = true;
            cbTool8.DataSource = null;
            cbType8.Enabled = true;
            cbType8.SelectedValue = "1";
            cbType8.Update();
        }
        private void btnRemoveTool9_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool9.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool9.Enabled = true;
            cbTool9.DataSource = null;
            cbType9.Enabled = true;
            cbType9.SelectedValue = "1";
            cbType9.Update();
        }
        private void btnRemoveTool10_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool10.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool10.Enabled = true;
            cbTool10.DataSource = null;
            cbType10.Enabled = true;
            cbType10.SelectedValue = "1";
            cbType10.Update();
        }
        private void btnRemoveTool11_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool11.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool11.Enabled = true;
            cbTool11.DataSource = null;
            cbType11.Enabled = true;
            cbType11.SelectedValue = "1";
            cbType11.Update();
        }
        private void btnRemoveTool12_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool12.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool12.Enabled = true;
            cbTool12.DataSource = null;
            cbType12.Enabled = true;
            cbType12.SelectedValue = "1";
            cbType12.Update();
        }
        private void btnRemoveTool13_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool13.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool13.Enabled = true;
            cbTool13.DataSource = null;
            cbType13.Enabled = true;
            cbType13.SelectedValue = "1";
            cbType13.Update();
        }
        private void btnRemoveTool14_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool14.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool14.Enabled = true;
            cbTool14.DataSource = null;
            cbType14.Enabled = true;
            cbType14.SelectedValue = "1";
            cbType14.Update();
        }
        private void btnRemoveTool15_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool15.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool15.Enabled = true;
            cbTool15.DataSource = null;
            cbType15.Enabled = true;
            cbType15.SelectedValue = "1";
            cbType15.Update();
        }
        private void btnRemoveTool16_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool16.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool16.Enabled = true;
            cbTool16.DataSource = null;
            cbType16.Enabled = true;
            cbType16.SelectedValue = "1";
            cbType16.Update();
        }
        private void btnRemoveTool17_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool17.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool17.Enabled = true;
            cbTool17.DataSource = null;
            cbType17.Enabled = true;
            cbType17.SelectedValue = "1";
            cbType17.Update();
        }
        private void btnRemoveTool18_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool18.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool18.Enabled = true;
            cbTool18.DataSource = null;
            cbType18.Enabled = true;
            cbType18.SelectedValue = "1";
            cbType18.Update();
        }
        private void btnRemoveTool19_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool19.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool19.Enabled = true;
            cbTool19.DataSource = null;
            cbType19.Enabled = true;
            cbType19.SelectedValue = "1";
            cbType19.Update();
        }
        private void btnRemoveTool20_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    string query =
                    "select t.Tool_ID, t.deposit_cost, t.rent_cost " +
                    " from tool t " +
                    "where 1=1 " +
                    "and t.Tool_ID = " + cbTool20.SelectedValue.ToString();
                    Console.WriteLine(query + "\n");
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan tspan = dateTimePickerEnd.Value - dateTimePickerStart.Value;
                        int iRentDays = tspan.Days;
                        int iCurrentRentPrice = Convert.ToInt32(lblXTotalRentPrice.Text);
                        int iRemovedToolRentPrice = (Convert.ToInt32(reader.GetString("rent_cost"))) * iRentDays;
                        int iCurrentDepositPrice = Convert.ToInt32(lblXTotalDepositPrice.Text);
                        int iRemovedToolDepositPrice = Convert.ToInt32(reader.GetString("deposit_cost"));
                        lblXTotalRentPrice.Text = (iCurrentRentPrice - iRemovedToolRentPrice).ToString();
                        lblXTotalDepositPrice.Text = (iCurrentDepositPrice - iRemovedToolDepositPrice).ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured! .. " + ex.ToString());
                }
            }
            cbTool20.Enabled = true;
            cbTool20.DataSource = null;
            cbType20.Enabled = true;
            cbType20.SelectedValue = "1";
            cbType20.Update();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            // disable start date and end date fields, all combobox fields, etc.
            // Back to Main Menu will be only enabled
            var comboBoxes1 = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("cbTool"));
            foreach (var c in comboBoxes1)
            {
                if (c.SelectedItem != null)
                {
                    MessageBox.Show("Name: " + c.Name == null ? "null" : c.Name.ToString() + " - " +
                        "Text: " + c.Text == null ? "null" : c.Text.ToString() + " - " +
                        "SelectedIndex: " + c.SelectedIndex == null ? "null" : c.SelectedIndex.ToString() + " - " +
                        "SelectedItem: " + c.SelectedItem == null ? "null" : c.SelectedItem.ToString() + " - " +
                        "SelectedText: " + c.SelectedText == null ? "null" : c.SelectedText.ToString() + " - " +
                        "SelectedValue: " + c.SelectedValue == null ? "null" : c.SelectedValue.ToString());
                }
            }
            var comboBoxes2 = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("cbType"));
            foreach (var c in comboBoxes2)
            {
                if (c.SelectedItem != null)
                {
                    string displayText = "Name: " + (c.Name == null ? "null" : c.Name.ToString()) + " - " +
                        "Text: " + c.Text == null ? "null" : c.Text.ToString() + " - " +
                        "SelectedIndex: " + c.SelectedIndex == null ? "null" : c.SelectedIndex.ToString() + " - " +
                        "SelectedItem: " + c.SelectedItem == null ? "null" : c.SelectedItem.ToString() + " - " +
                        "SelectedText: " + c.SelectedText == null ? "null" : c.SelectedText.ToString() + " - " +
                        "SelectedValue: " + c.SelectedValue == null ? "null" : c.SelectedValue.ToString(); 
                    MessageBox.Show(displayText);
                }
            }
        }
        */

    }
}
