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
    public partial class frmRegisterTutor : Form
    {
        public frmRegisterTutor()
        {
            InitializeComponent();
        }
        private static frmRegisterTutor RegisterT_frm;
        public static frmRegisterTutor GetInstance()
        {
            if (RegisterT_frm == null)
            {
                RegisterT_frm = new frmRegisterTutor();
            }
            return RegisterT_frm;
        }

        private void cmdHome2_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
            //this.Hide();
            //Form1 Home = new Form1();
            //Home.Show();
        }

        private void lnkLogin2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void lnkContactUs2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //frmAboutUs About = new frmAboutUs();
            //About.Show();
        }

        private void lnkAbout2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ///this.Hide();
            //frmAboutUs About = new frmAboutUs();
            //About.Show();
        }

        private void cmdRegister2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }

        private void cmdAdmin2_Click(object sender, EventArgs e)
        {
            frmAdminPassword L = new frmAdminPassword();
            this.Hide();
            L.Show();
        }

        private void cmdTRegister_Click(object sender, EventArgs e)
        {
            if (txtTName.Text == "" || txtTpassword.Text == "" || txtTNo.Text == "" || txtTage.Text =="" || combogenderT.Text =="" || comboBoxSelectArea.Text =="" || txtTSubject.Text == "" || comboBoxTLevel.Text =="" || txtRange.Text =="" || txtTCPassword.Text =="" || comboBoxSecretQs.Text =="" || txtSecretAnswer.Text =="" || txtTiming.Text =="" )
            {
                MessageBox.Show("please enter all the required information to register");
               
            }
            else if (!chkBTerms.Checked)
            {
                MessageBox.Show("You have to accept the terms and conditions to register yourself!");
            }
            else
            {
                MyServer.Service1 Server = new MyServer.Service1();

                if (txtTpassword.Text == txtTCPassword.Text)
                { 
                    Server.AddTeacher(combogenderT.Text , txtTName.Text, txtTage.Text, comboBoxSecretQs.Text, txtSecretAnswer.Text, txtTNo.Text, txtTpassword.Text, txtTCPassword.Text, txtTSubject.Text, comboBoxTLevel.Text, txtTiming.Text, comboBoxSelectArea.Text, txtRange.Text);
                    MessageBox.Show("You have been registered");
                    frmLogin f = new frmLogin();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your password and confirm password should be same");
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void cmdTRegister_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void txtTName_Click(object sender, EventArgs e)
        {
            txtTName.Clear();
        }

        private void txtTNo_Click(object sender, EventArgs e)
        {
            txtTNo.Clear();
        }

        private void txtTage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTage_Click(object sender, EventArgs e)
        {
            txtTage.Clear();
        }

        private void txtTSubject_Click(object sender, EventArgs e)
        {
            txtTSubject.Clear();
        }

        private void txtTiming_Click(object sender, EventArgs e)
        {
            txtTiming.Clear();
        }

        private void txtRange_Click(object sender, EventArgs e)
        {
            txtRange.Clear();
        }

        private void txtTpassword_Click(object sender, EventArgs e)
        {
            txtTpassword.Clear();
        }

        private void txtTCPassword_Click(object sender, EventArgs e)
        {
            txtTCPassword.Clear();
        }

        private void txtSecretAnswer_Click(object sender, EventArgs e)
        {
            txtSecretAnswer.Clear();
        }

        private void txtTName_TextChanged(object sender, EventArgs e)
        {

        }

        private void combogenderT_Click(object sender, EventArgs e)
        {
            combogenderT.ResetText();
        }

        private void comboBoxSelectArea_Click(object sender, EventArgs e)
        {
            comboBoxSelectArea.ResetText();
        }

        private void comboBoxTLevel_Click(object sender, EventArgs e)
        {
            comboBoxTLevel.ResetText();
        }

        private void comboBoxSecretQs_Click(object sender, EventArgs e)
        {
            comboBoxSecretQs.ResetText();
        }
    }
}
