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
            //this.Hide();
            //Form1 Home = new Form1();
            //Home.Show();
        }

        private void lnkLogin2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin L = new frmlogin();
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
            //this.Hide();
            //frmAdmin Admin = new frmAdmin();
            //Admin.Show();
        }

        private void cmdTRegister_Click(object sender, EventArgs e)
        {
            if (txtTName.Text == "" || txtTpassword.Text == "")
            {
                MessageBox.Show("Invalid Register Attempt");
            }
            else
            {
                MyServer.Service1 Server = new MyServer.Service1();

                if (txtTName.Text == "" || txtTpassword.Text == "")
                {
                    MessageBox.Show("Invalid Register Attempt");
                }
                else
                {
                    Server.AddTeacher(txtTName.Text, txtTage.Text, comboBoxSecretQs.Text, txtSecretAnswer.Text, txtTNo.Text, txtTpassword.Text, txtTCPassword.Text, txtTSubject.Text, comboBoxTLevel.Text, txtTiming.Text, txtTCity.Text, txtRange.Text);
                    MessageBox.Show("You have been registered");
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
    }
}
