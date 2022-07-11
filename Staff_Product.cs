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
    public partial class Staff_Product : Form
    {
        public Staff_Product()
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO ProductTb2(Id, Name, Price, Catagory) VALUES (@Id, @Name, @Price, @Catagory)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", textBox3.Text);
            cmd.Parameters.AddWithValue("@Catagory", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Successfully Inserted");
            BindData();
        }

        private void Staff_Product_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE ProductTb2 SET Name=@Name, Price=@Price, Catagory=@Catagory WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Price", textBox3.Text);
            cmd.Parameters.AddWithValue("@Catagory", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Successfully Edited");
            BindData();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {



                    SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE ProductTb2 WHERE Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Catagory", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show("Successfully Deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Put your Product Id");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb2 WHERE Id=@Id", con);

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

            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
