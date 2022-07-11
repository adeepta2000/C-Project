using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket_Management_System
{
    public partial class Staff_Staff : Form
    {
        public Staff_Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff stf = new Staff();
            stf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Staff_Staff_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Id, FirstName, LastName, Username, PhoneNumber, JobTitle FROM StaffTb", con);
            SqlDataAdapter sqd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
