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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int startPos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            startPos += 1;
            percentageLvl.Value = startPos;
            string v = startPos + "%";
            percent.Text = v;
            if (percentageLvl.Value == 100)
            {
                percentageLvl.Value = 0;
                timer2.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
