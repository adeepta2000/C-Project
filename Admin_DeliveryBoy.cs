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
    public partial class Admin_DeliveryBoy : Form
    {
        public Admin_DeliveryBoy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            sq.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO DeliveryBoyTb(Id, FirstName, LastName, Username, PhoneNumber, Password) VALUES (@Id, @FirstName, @LastName, @Username, @PhoneNumber, @Password)", sq);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Username", textBox4.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);
            
            cmd.Parameters.AddWithValue("@Password", textBox6.Text);

            cmd.ExecuteNonQuery();
            sq.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            

            MessageBox.Show("Successfully Inserted");
            BindData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {



                    SqlConnection sq = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
                    sq.Open();

                    SqlCommand cmd = new SqlCommand("DELETE DeliveryBoyTb WHERE Id=@Id", sq);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Username", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);
                    
                    cmd.Parameters.AddWithValue("@Password", textBox6.Text);

                    cmd.ExecuteNonQuery();
                    sq.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                   
                    MessageBox.Show("Successfully Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put your Id");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            sq.Open();

            SqlCommand cmd = new SqlCommand("UPDATE DeliveryBoyTb SET FirstName=@FirstName, LastName=@LastName, Username=@Username,  PhoneNumber=@PhoneNumber, Password=@Password WHERE Id=@Id", sq);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@FirstName", textBox2.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Username", textBox4.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);
           
            cmd.Parameters.AddWithValue("@Password", textBox6.Text);

            cmd.ExecuteNonQuery();
            sq.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            

            MessageBox.Show("Successfully Updated");
            BindData();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM DeliveryBoyTb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM DeliveryBoyTb WHERE Id=@Id", con);

            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM DeliveryBoyTb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_DeliveryBoy_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM DeliveryBoyTb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
