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
    public partial class Admin : Form
    {
        
        public Admin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Admin_Enter(object sender, EventArgs e)
        {
           
        }

        private void sidebar_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void sidebar_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void sidebar_AutoSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product_Admin pro = new Product_Admin();
            pro.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            OrderDetails ods = new OrderDetails();
            ods.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_staff ads = new Admin_staff();
            ads.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Customer adc = new Admin_Customer();
            adc.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_DeliveryBoy adb = new Admin_DeliveryBoy();
            adb.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
