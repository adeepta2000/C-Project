using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Product cup = new Customer_Product();
            cup.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OderProduct_Customer odc = new OderProduct_Customer();
            odc.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            update_profile up = new update_profile();
            up.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ratings_commments rts = new ratings_commments();
            rts.Show();
            this.Hide();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
