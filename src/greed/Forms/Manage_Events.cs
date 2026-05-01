using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace greed
{
    public partial class Manage_Events : Form
    {
        private const string ConnectionString = "Server=localhost\\SQLEXPRESS;Database=project;Trusted_Connection=True;";

        public Manage_Events()
        {
            InitializeComponent();
            LoadGridData();
        }

        private void LoadGridData()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Event]", con);
            DataTable dt = new DataTable();
            
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            reader.Close();
            con.Close();

            dgv_Eve.DataSource = dt;
        }

        private void back_dashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Manage_Events_Load_1(object sender, EventArgs e) { }
        private void dgv_Eve_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Btn_add_click(object sender, EventArgs e)
        {
            string insertStr = "INSERT INTO [Event] VALUES (@Event_ID, @name, @desc, @Start_date, @Finish_date, @Event_Address, @Balance)";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertStr, con);


            SqlParameter paramID = new SqlParameter("@Event_ID", int.Parse(text_ID.Text));
            SqlParameter paramName = new SqlParameter("@name", text_name.Text);
            SqlParameter paramDesc = new SqlParameter("@desc", text_description.Text);
            SqlParameter paramStart = new SqlParameter("@Start_date", dateTimePicker1.Value);
            SqlParameter paramFinish = new SqlParameter("@Finish_date", dateTimePicker2.Value);
            SqlParameter paramAddress = new SqlParameter("@Event_Address", text_address.Text);
            SqlParameter paramBalance = new SqlParameter("@Balance", int.Parse(text_balance.Text));
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
            string insertStr = "DELETE FROM [Event] WHERE Event_ID = @Event_ID";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertStr, con);


            SqlParameter paramID = new SqlParameter("@Event_ID", int.Parse(text_ID.Text));
       
            cmd.Parameters.Add(paramID);

            cmd.ExecuteNonQuery();
            LoadGridData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string insertStr = "UPDATE [Event] SET event_name = @name, event_description = @desc, " +
                           "Start_date = @Start_date, Finish_date = @Finish_date, " +
                           "Event_Address = @Event_Address, Balance = @Balance " +
                           "WHERE Event_ID = @Event_ID";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertStr, con);


            SqlParameter paramID = new SqlParameter("@Event_ID", int.Parse(text_ID.Text));
            SqlParameter paramName = new SqlParameter("@name", text_name.Text);
            SqlParameter paramDesc = new SqlParameter("@desc", text_description.Text);
            SqlParameter paramStart = new SqlParameter("@Start_date", dateTimePicker1.Value);
            SqlParameter paramFinish = new SqlParameter("@Finish_date", dateTimePicker2.Value);
            SqlParameter paramAddress = new SqlParameter("@Event_Address", text_address.Text);
            SqlParameter paramBalance = new SqlParameter("@Balance", int.Parse(text_balance.Text));
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
    }
}
