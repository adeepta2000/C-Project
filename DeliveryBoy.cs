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
    public partial class DeliveryBoy : Form
    {
        public DeliveryBoy()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeliveryBoy_Profile dbf = new DeliveryBoy_Profile();
            dbf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeliveryBoy_Customer dc = new DeliveryBoy_Customer();
            dc.Show();
            this.Hide();
        }
    }
}
