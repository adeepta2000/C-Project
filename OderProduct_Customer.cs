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
    
    public partial class OderProduct_Customer : Form
    {
        public OderProduct_Customer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
        

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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void OderProduct_Customer_Load(object sender, EventArgs e)
        {
            GetProductInformation();
        }

         void GetProductInformation()
        {

            SqlCommand cmd = new SqlCommand("Select * from ProductTb2", con);

            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            con.Open();
            

            SqlCommand cmd2 = new SqlCommand("INSERT INTO OrderDetails2(P_Id, Price, Quantity) VALUES (@P_Id, @Price, @Quantity)", con);

            cmd2.Parameters.AddWithValue("@P_Id", int.Parse(textBox1.Text));
            cmd2.Parameters.AddWithValue("@Price", int.Parse(textBox2.Text));
            cmd2.Parameters.AddWithValue("@Quantity", int.Parse(textBox3.Text));
            
            

            cmd2.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            SqlCommand cmd1 = new SqlCommand("SELECT * FROM OrderDetails2", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;



            MessageBox.Show("Successfully Inserted");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buy b = new Buy();
            b.Show();
            this.Hide();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int order_id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["O_Id"].Value);
            con.Open();
            
            SqlCommand sc = new SqlCommand("Delete OrderDetails2 Where O_Id = '" + order_id + "'", con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your product is removed.");
            LoadData();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }
        void LoadData()
        {
            con.Open();
            SqlCommand c = new SqlCommand("select * from OrderDetails2", con);
            SqlDataAdapter d = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
    }
}
