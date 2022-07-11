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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
            
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            sq.Open();

            SqlCommand cmd = new SqlCommand("UPDATE CustomerTb2 SET Password=@Password WHERE Id=@Id", sq);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
           

            cmd.ExecuteNonQuery();
            sq.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            
           


            MessageBox.Show("Successfully Updated");
            BindData();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT Password FROM CustomerTb2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
