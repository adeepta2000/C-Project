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
    public partial class update_profile : Form
    {
        public update_profile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("UPDATE CustomerTb2 SET FirstName=@FirstName, LastName=@LastName, Username=@Username, CurrentAddress=@CurrentAddress,  PhoneNumber=@PhoneNumber, EmailAddress=@EmailAddress WHERE Id=@Id", con);


            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Username", textBox3.Text);
            cmd.Parameters.AddWithValue("@CurrentAddress", textBox4.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBox6.Text);
            
            cmd.Parameters.AddWithValue("@EmailAddress", textBox5.Text);




            cmd.ExecuteNonQuery();

            con.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM CustomerTb2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            MessageBox.Show("Successfully Updated");
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void update_profile_Load(object sender, EventArgs e)
        {

        }
    }
}
