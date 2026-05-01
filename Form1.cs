using System;
using System.Windows.Forms;

namespace greed
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Events mySecondForm = new Manage_Events();
            this.Hide();
            mySecondForm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Assist_Beneficiaries_Click(object sender, EventArgs e)
        {
            Manage_Beneficiaries mySecondForm = new Manage_Beneficiaries();
            this.Hide();
            mySecondForm.ShowDialog();
            this.Show();
        }

        private void btn_Volunteer_Hub_Click(object sender, EventArgs e)
        {
            Manage_Volunteers mySecondForm = new Manage_Volunteers();
            this.Hide();
            mySecondForm.ShowDialog();
            this.Show();
        }

        private void btn_Manage_Staff_Click(object sender, EventArgs e)
        {
            Manage_Employees mySecondForm = new Manage_Employees();
            this.Hide();
            mySecondForm.ShowDialog();
            this.Show();
        }

        private void btn_Process_Donations_Click(object sender, EventArgs e)
        {
            Manage_Donations mySecondForm = new Manage_Donations();
            this.Hide();
            mySecondForm.ShowDialog();
            this.Show();
        }
    }
}
