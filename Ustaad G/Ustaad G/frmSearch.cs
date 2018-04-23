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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text;
            string password = txtPwd.Text;
            MyServer.Service1 Server = new MyServer.Service1();
            bool isFound;
            bool isFoundPass;
            Server.VerifyByAdmin(username, password, out isFound, out isFoundPass);
      
            if (isFound == true)
            {
                MessageBox.Show("You are verified!");
            }
            else
            {
                MessageBox.Show("You are not verified!!");
            }
        }

        private void cmdRegister3_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }

        private void lnkLogin3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin L = new frmlogin();
            this.Hide();
            L.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUname_Click(object sender, EventArgs e)
        {
            txtUname.Clear();
        }

        private void txtSCity_Click(object sender, EventArgs e)
        {
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.Clear();
        }
    }
}
