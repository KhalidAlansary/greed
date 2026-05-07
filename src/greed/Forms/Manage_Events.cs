using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_phase2
{
    public partial class Manage_Events : Form
    {
        public Manage_Events()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Event", con);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Columns.Add("Event_ID");
            dt.Columns.Add("event_name");
            dt.Columns.Add("event_description");
            dt.Columns.Add("Start_date");
            dt.Columns.Add("Finish_date");
            dt.Columns.Add("Event_Address");
            dt.Columns.Add("Balance");
            DataRow row;
            while (reader.Read())
            {
                row = dt.NewRow();
                row["Event_ID"] = reader["Event_ID"];
                row["event_name"] = reader["event_name"];
                row["event_description"] = reader["event_description"];
                row["Start_date"] = reader["Start_date"];
                row["Finish_date"] = reader["Finish_date"];
                row["Event_Address"] = reader["Event_Address"];
                row["Balance"] = reader["Balance"];
                dt.Rows.Add(row);
            }
            reader.Close();

            SqlCommand cmdAct = new SqlCommand("Select * from Activity", con);
            DataTable dtAct = new DataTable();
            SqlDataReader readerAct = cmdAct.ExecuteReader();

            dtAct.Columns.Add("activity_name");
            dtAct.Columns.Add("start_date");
            dtAct.Columns.Add("end_date");
            dtAct.Columns.Add("Event_ID");

            DataRow row1;
            while (readerAct.Read()) { 
                row1 = dtAct.NewRow();
                row1["activity_name"] = readerAct["activity_name"];
                row1["start_date"] = readerAct["start_date"];
                row1["end_date"] = readerAct["end_date"];
                row1["Event_ID"] = readerAct["Event_ID"];
                dtAct.Rows.Add(row1);
            }
            readerAct.Close();
            con.Close();
            dgv_Eve.DataSource = dt;
            dgv_Activities.DataSource = dtAct;
        }

        private void LoadGridData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Event", con);
            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            SqlCommand cmdAct = new SqlCommand("Select * from Activity", con);
            DataTable dtAct = new DataTable();
            SqlDataReader readerAct = cmdAct.ExecuteReader();
            dtAct.Load(readerAct);

            reader.Close();
            con.Close();

            dgv_Eve.DataSource = dt;
            dgv_Activities.DataSource = dtAct;
        }

        private void back_dashboard_Click(object sender, EventArgs e)
        {
            main_form mySecondForm = new main_form();
            this.Hide();
            mySecondForm.ShowDialog();
            this.Show();
        }

        private void Manage_Events_Load_1(object sender, EventArgs e) { }
        private void dgv_Eve_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Btn_add_click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=project;Integrated Security=True;");
            con.Open();
            string insertStr = "INSERT INTO Event VALUES (@Event_ID, @name, @desc, @Start_date, @Finish_date, @Event_Address, @Balance)";
            SqlCommand cmd = new SqlCommand(insertStr, con);
            int id_event,myBalance;
            try
            {
                id_event = int.Parse(text_ID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid event ID number.");
                con.Close();
                return;
            }
            string checkStr = "SELECT COUNT(1) FROM Event WHERE Event_ID = @Event_ID";
            SqlCommand checkCmd = new SqlCommand(checkStr, con);
            checkCmd.Parameters.Add(new SqlParameter("@Event_ID", id_event));

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists == 1)
            {
                MessageBox.Show("This Event ID already exists. Please enter a different ID.", "Event Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }
            try
            {
                myBalance = int.Parse(text_balance.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid Balance value.");
                con.Close();
                return;
            }

            SqlParameter paramID = new SqlParameter("@Event_ID", id_event);
            SqlParameter paramName = new SqlParameter("@name", text_name.Text);
            SqlParameter paramDesc = new SqlParameter("@desc", text_description.Text);
            SqlParameter paramStart = new SqlParameter("@Start_date", dateTimePicker1.Value);
            SqlParameter paramFinish = new SqlParameter("@Finish_date", dateTimePicker2.Value);
            SqlParameter paramAddress = new SqlParameter("@Event_Address", text_address.Text);
            SqlParameter paramBalance = new SqlParameter("@Balance", myBalance);
            cmd.Parameters.Add(paramID);
            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramDesc);
            cmd.Parameters.Add(paramStart);
            cmd.Parameters.Add(paramFinish);
            cmd.Parameters.Add(paramAddress);
            cmd.Parameters.Add(paramBalance);

            cmd.ExecuteNonQuery();
            LoadGridData();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=project;Integrated Security=True;");
            con.Open();
            string insertStr = "DELETE FROM Activity WHERE Event_ID = @Event_ID;" +
                "DELETE FROM Event WHERE Event_ID = @Event_ID;";
            
            SqlCommand cmd = new SqlCommand(insertStr, con);

            int id_event;
            try
            {
                id_event = int.Parse(text_ID.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid event ID number.");
                con.Close();
                return;
            }
            string checkStr = "SELECT COUNT(1) FROM Event WHERE Event_ID = @Event_ID";
            SqlCommand checkCmd = new SqlCommand(checkStr, con);
            checkCmd.Parameters.Add(new SqlParameter("@Event_ID", id_event));

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists == 0)
            {
                MessageBox.Show("This Event ID does not exist. Please enter a different ID.", "Event Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }
            SqlParameter paramID = new SqlParameter("@Event_ID", id_event);
       
            cmd.Parameters.Add(paramID);

            cmd.ExecuteNonQuery();
            LoadGridData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string insertStr = "UPDATE Event SET event_name = @name, event_description = @desc, " +
                           "Start_date = @Start_date, Finish_date = @Finish_date, " +
                           "Event_Address = @Event_Address, Balance = @Balance " +
                           "WHERE Event_ID = @Event_ID";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(insertStr, con);
            int id_event, myBalance;
            try
            {
                id_event = int.Parse(text_ID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid event ID number.");
                con.Close();
                return;
            }
            string checkStr = "SELECT COUNT(1) FROM Event WHERE Event_ID = @Event_ID";
            SqlCommand checkCmd = new SqlCommand(checkStr, con);
            checkCmd.Parameters.Add(new SqlParameter("@Event_ID", id_event));

            int exists = (int)checkCmd.ExecuteScalar();

            if (exists == 0)
            {
                MessageBox.Show("This Event ID does not exist. Please create the Event first, or enter a valid ID.", "Event Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }
            try
            {
                myBalance = int.Parse(text_balance.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid Balance value.");
                con.Close();
                return;
            }

            SqlParameter paramID = new SqlParameter("@Event_ID", id_event);
            SqlParameter paramName = new SqlParameter("@name", text_name.Text);
            SqlParameter paramDesc = new SqlParameter("@desc", text_description.Text);
            SqlParameter paramStart = new SqlParameter("@Start_date", dateTimePicker1.Value);
            SqlParameter paramFinish = new SqlParameter("@Finish_date", dateTimePicker2.Value);
            SqlParameter paramAddress = new SqlParameter("@Event_Address", text_address.Text);
            SqlParameter paramBalance = new SqlParameter("@Balance", myBalance);
            cmd.Parameters.Add(paramID);
            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramDesc);
            cmd.Parameters.Add(paramStart);
            cmd.Parameters.Add(paramFinish);
            cmd.Parameters.Add(paramAddress);
            cmd.Parameters.Add(paramBalance);

            cmd.ExecuteNonQuery();
            LoadGridData();


        }

        private void dgv_Activities_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void btn_add_act_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=project;Integrated Security=True;");
            con.Open();
            int id_event;
            try
            {
                id_event = int.Parse(text_ID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid event ID number.");
                con.Close();
                return;
            }
            string checkStr = "SELECT COUNT(1) FROM Event WHERE Event_ID = @Event_ID";
            SqlCommand checkCmd = new SqlCommand(checkStr, con);
            checkCmd.Parameters.Add(new SqlParameter("@Event_ID", id_event));

            int exists = (int)checkCmd.ExecuteScalar(); 

            if (exists == 0)
            {
                MessageBox.Show("This Event ID does not exist. Please create the Event first, or enter a valid ID.", "Event Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
                return;
            }
            string insertStr = "INSERT INTO Activity (activity_name,Event_ID, start_date, end_date) VALUES (@activity_name, @Event_ID, @start_date, @end_date)";
            SqlCommand cmd = new SqlCommand(insertStr, con);
            SqlParameter paramID = new SqlParameter("@Event_ID", id_event);
            SqlParameter paramStart = new SqlParameter("@start_date", dtp_act_start.Value);
            SqlParameter paramFinish = new SqlParameter("@end_date", dtp_act_end.Value);
            SqlParameter paramName   = new SqlParameter("@activity_name", text_act_name.Text);
            cmd.Parameters.Add(paramID);
            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramStart);
            cmd.Parameters.Add(paramFinish);

            cmd.ExecuteNonQuery();
            LoadGridData();
        }

        private void btn_delete_act_Click(object sender, EventArgs e)
        {
            string insertStr = "DELETE FROM Activity WHERE Event_ID = @Event_ID AND activity_name = @activity_name;";
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=project;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(insertStr, con);
            int id_event;
            try
            {
                id_event = int.Parse(text_ID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid event ID number.");
                con.Close();
                return;
            }
            SqlParameter paramID = new SqlParameter("@Event_ID", id_event);
            SqlParameter paramName = new SqlParameter("@activity_name", text_act_name.Text);
            cmd.Parameters.Add(paramID);
            cmd.Parameters.Add(paramName);
            cmd.ExecuteNonQuery();
            LoadGridData();
        }
    }
}
