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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Staff_DeliveryBoy std = new Staff_DeliveryBoy();
            std.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff_Product stp = new Staff_Product();
            stp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff_Staff sts = new Staff_Staff();
            sts.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Staff_Customer stc = new Staff_Customer();
            stc.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OrderDetails_Staff ods = new OrderDetails_Staff();
            ods.Show();
            this.Hide();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
