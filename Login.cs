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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change_Password chp = new Change_Password();
            chp.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=SPIDEY-L;Initial Catalog=PROJECT;Integrated Security=True");
            string query = "Select * from CustomerTb2 Where Username ='" + textBox1.Text.Trim() + "'and Password = '" + textBox2.Text.Trim()+ "'";
            string query2 = "Select * from StaffTb Where Username ='" + textBox1.Text.Trim() + "'and Password = '" + textBox2.Text.Trim()+ "'";
            string query3 = "Select * from DeliveryBoyTb Where Username ='" + textBox1.Text.Trim() + "'and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            SqlDataAdapter sdt = new SqlDataAdapter(query2, sqlcon);
            SqlDataAdapter sdp = new SqlDataAdapter(query3, sqlcon);
            DataTable dtbl = new DataTable();
            DataTable dtbl2 = new DataTable();
            DataTable dtbl3 = new DataTable();
            sda.Fill(dtbl);
            sdt.Fill(dtbl2);
            sdp.Fill(dtbl3);

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (dtbl.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successfully and Click ok to Continue", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Customer cus = new Customer();
                    cus.Show();
                    this.Hide();
                }

                else if (dtbl2.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successfully and Click ok to Continue", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Staff sta = new Staff();
                    sta.Show();
                    this.Hide();
                }

                else if (dtbl3.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successfully and Click ok to Continue", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeliveryBoy dba = new DeliveryBoy();
                    dba.Show();
                    this.Hide();
                }


                else if ((this.textBox1.Text == "Admin") && (this.textBox2.Text == "admin"))
                {

                    MessageBox.Show("Login Successfully and Click ok to Continue", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin ad = new Admin();
                    ad.Show();
                    this.Hide();



                }

                else
                {
                    MessageBox.Show("Wrong username or password");

                }

            }


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Enter your User Name !");
            }
            else
            {
                
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please Enter your Password !");
            }
            else
            {
                
                errorProvider2.SetError(textBox2, null);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
