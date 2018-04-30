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
    public partial class frmNewPassword : Form
    {
        private PictureBox pictureBox2;
        private Panel panel8;
        private Panel panel4;
        private TextBox txtResetForm;
        private PictureBox pictureBox1;
        private Panel panel10;
        private Panel panel9;
        private Panel panel6;
        private TextBox txtPassword;
        private Panel panel5;
        private TextBox txtCPassword;
        private Button cmdReset;
        private Panel panel7;
        private Panel panel3;
        private Label lblUstaadG;
        private Button cmdAdmin5;
        private Button cmdRegister5;
        private Button cmdHome5;
        private LinkLabel lnkContactUs5;
        private LinkLabel lnkLogin5;
        private LinkLabel lnkAbout5;
        private Panel panel1;
        private Panel panel2;
        private PictureBox picHome;

        string this_username;
        string this_role;
        MyServer.Service1 Server = new MyServer.Service1();

        public frmNewPassword()
        {
            InitializeComponent();
        }

        public frmNewPassword(string username, string role)
        {
            InitializeComponent();
            this_role = role;
            this_username = username;
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void cmdRegister5_Click(object sender, EventArgs e)
        {
            frmSelectRegister f = new frmSelectRegister();
            f.Show();
            this.Show();
        }

        private void lnkLogin5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
            if (txtCPassword.Text == "" || txtCPassword.Text == "Confirm Password")
            {
                txtCPassword.Text = "Confirm Password";
            }
        }

        private void txtCPassword_Click(object sender, EventArgs e)
        {
            if (txtCPassword.Text == "Confirm Password")
            {
                txtCPassword.Text = "";
            }
            if (txtPassword.Text == "" || txtPassword.Text == "Password")
            {
                txtCPassword.Text = "";
            }
        }

        private void picHome_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            if (txtCPassword.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("please enter all required information!");
            }
            else
            {
                if (txtPassword.Text == txtCPassword.Text)
                {
                    if (this_role == "Teacher")
                    {
                        Server.NewPasswordT(this_username, txtPassword.Text);
                    }
                    else
                    {
                        Server.NewPasswordS(this_username, txtPassword.Text);
                    }
                    MessageBox.Show("Your Password Has Been Reset");
                    frmLogin L = new frmLogin();
                    this.Hide();
                    L.Show();
                }
                else
                {
                    MessageBox.Show("Your password and confirm password should be same :)");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void txtCPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
