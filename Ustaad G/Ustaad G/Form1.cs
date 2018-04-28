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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private static frmLogin Login_frm;
        public static frmLogin GetInstance()
        {
            if (Login_frm == null)
            {
                Login_frm = new frmLogin();
            }
            return Login_frm;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdRegister5_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }

        private void cmdLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            MyServer.Service1 Server = new MyServer.Service1();
            bool isFound;
            bool isFoundPass;
            if (checkBox1.Checked)
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
                frmSearch search = new frmSearch();
                this.Hide();
                search.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username" )
            {
                txtUsername.Text = "" ;
            }
            if(txtPassword.Text == "" || txtPassword.Text == "Password")
            {
                txtPassword.Text = "Password";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" )
            {
                txtPassword.Text = "" ;
            }
            if(txtUsername.Text == "" || txtUsername.Text == "Username")
            {
                txtUsername.Text = "Username";
            }
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmResetPassword f = new frmResetPassword();
            f.Show();
            this.Hide();
        }

        private void cmdAdmin5_Click(object sender, EventArgs e)
        {
            frmAdmin L = new frmAdmin();
            this.Hide();
            L.Show();
        }

        private void cmdHome5_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }
    }
 }


