using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class DeliveryBoy_Profile : Form
    {
        public DeliveryBoy_Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeliveryBoy db = new DeliveryBoy();
            db.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("UPDATE DeliveryBoyTb SET FirstName=@FirstName, LastName=@LastName, Username=@Username,  PhoneNumber=@PhoneNumber WHERE Id=@Id", con);


            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Username", textBox4.Text);

            cmd.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM DeliveryBoyTb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


            MessageBox.Show("Successfully Updated");
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
    }
}
