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
    public partial class Product_Admin : Form
    {
        public Product_Admin()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            idtextBox.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            nametxtbox.Text = "";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
                con.Open();

                
            SqlCommand cmd = new SqlCommand("INSERT INTO ProductTb2(Id, Name, Price, Catagory) VALUES (@Id, @Name, @Price, @Catagory)", con);
           
            cmd.Parameters.AddWithValue("@Id", int.Parse(idtextBox.Text));
            cmd.Parameters.AddWithValue("@Name", nametxtbox.Text);
                cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                cmd.Parameters.AddWithValue("@Catagory", textBox4.Text);

                cmd.ExecuteNonQuery();

           

           
            con.Close();
            idtextBox.Text = "";
            nametxtbox.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Successfully Inserted");
                BindData();
            
            
            
        }
        

        private void Product_Admin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            idtextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE ProductTb2 SET Name=@Name, Price=@Price, Catagory=@Catagory WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", int.Parse(idtextBox.Text));
                cmd.Parameters.AddWithValue("@Name", nametxtbox.Text);
                cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                cmd.Parameters.AddWithValue("@Catagory", textBox4.Text);
                
                cmd.ExecuteNonQuery();
                con.Close();
            idtextBox.Text = "";
            nametxtbox.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (idtextBox.Text != "")
            {
                if (MessageBox.Show("Are you sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {



                    SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE ProductTb2 WHERE Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(idtextBox.Text));
                    cmd.Parameters.AddWithValue("@Name", nametxtbox.Text);
                    cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Catagory", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    idtextBox.Text = "";
                    nametxtbox.Text = "";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTb2 WHERE Id=@Id", con);

            cmd.Parameters.AddWithValue("@Id", int.Parse(idtextBox.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idtextBox_Enter(object sender, EventArgs e)
        {
            idtextBox.Text = "";
        }

        private void button5_Click_1(object sender, EventArgs e)
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
