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
            if (txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("All the required information should be filled :|");
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                MyServer.Service1 Server = new MyServer.Service1();

                MyServer.Teacher teacherFound = null;
                MyServer.Student studentFound = null;

                

                if (checkBox1.Checked)
                {

                    teacherFound = Server.verifyteacher(username, password);
                }

                else
                {
                    studentFound = Server.verifyStudent(username, password);
                }
                if (teacherFound != null || studentFound != null)
                {
                    if (checkBox1.Checked)
                    {
                        myUtil.loggedin_user_role = "Teacher";
                        myUtil.teacher_loggedIn = teacherFound;

                        studentDetails sD = new studentDetails("Teacher");
                        sD.Show();
                    }
                    else
                    {
                        myUtil.loggedin_user_role = "Student";
                        myUtil.std_loggedin = studentFound;
                        MessageBox.Show("Login Successfully!");
                        frmSearch search = new frmSearch();
                        search.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
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
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Enter Username @ _ @");
            }
            else
            {
                string username = txtUsername.Text;
                MyServer.Service1 Server = new MyServer.Service1();
                bool isFound;
                bool isFoundPass;

                if (checkBox1.Checked)
                {
                    Server.isfoundT(username, out isFound, out isFoundPass);

                }
                else
                {
                    Server.isfoundS(username, out isFound, out isFoundPass);
                }
                if (isFound == true)
                {
                    frmResetPassword f = new frmResetPassword();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                }
            }
        }

        private void cmdAdmin5_Click(object sender, EventArgs e)
        {
            frmAdminPassword L = new frmAdminPassword();
            this.Hide();
            L.Show();
        }

        private void cmdHome5_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void lnkLogin5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void cmdrating_Click(object sender, EventArgs e)
        {
            MyServer.Service1 Server = new MyServer.Service1();
            cmdrating.Text = Server.Calculate_rating();
            if(cmdrating.Text == "1")
            {
                cmdrating.Text = "1 *";
            }
            else if (cmdrating.Text == "2")
            {
                cmdrating.Text = "2 **";
            }
            else if (cmdrating.Text == "3")
            {
                cmdrating.Text = "3 ***";
            }
            else if (cmdrating.Text == "4")
            {
                cmdrating.Text = "4 ****";
            }
            else if(cmdrating.Text == "5")
            {
                cmdrating.Text = "5 *****";
            }
        }
    }
 }


