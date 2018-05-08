using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ustaad_G
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lnkLogin10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin R = new frmLogin();
            this.Hide();
            R.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLogin R = new frmLogin();
            this.Hide();
            R.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
