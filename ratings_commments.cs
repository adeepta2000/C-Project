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
    public partial class ratings_commments : Form
    {
        public ratings_commments()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Five_Star fis = new Five_Star();
            fis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Five_Star fis = new Five_Star();
            fis.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Five_Star fis = new Five_Star();
            fis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Five_Star fis = new Five_Star();
            fis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Five_Star fis = new Five_Star();
            fis.Show();
            this.Hide();
        }

        private void ratings_commments_Load(object sender, EventArgs e)
        {

        }
    }
}
