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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        private static frmlogin login_frm;
        public static frmlogin GetInstance()
        {
            if (login_frm == null)
            {
                login_frm = new frmlogin();
            }
            return login_frm;
        }
        private void cmdRegister_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            MyServer.Service1 Server = new MyServer.Service1();
            bool isFound;
            bool isFoundPass;
            if (chkT.Checked)
            {
                Server.verifyteacher(username, password, out isFound, out isFoundPass);
            }

            else
            {
                Server.verifyStudent(username, password, out isFound, out isFoundPass);
            }
            if (isFound == true)
            {
                MessageBox.Show("Login Successfully!");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lnkResetPassowrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPassword ResetPassword = new frmResetPassword();
            this.Hide();
            ResetPassword.Show();
        }
    }
}
