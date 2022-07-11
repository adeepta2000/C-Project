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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cu = new Customer();
            cu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OderProduct_Customer oc = new OderProduct_Customer();
            oc.Show();
            this.Hide();
        }
    }
}
