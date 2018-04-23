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
    public partial class frmStudentRegister : Form
    {
        public frmStudentRegister()
        {
            InitializeComponent();
        }

        private void txtSpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdHome8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 Home = new Form1();
            //Home.Show();
        }

        private void lnkLogin8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin L = new frmlogin();
            this.Hide();
            L.Show();
        }

        private void lnkContactUs8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //frmAboutUs About = new frmAboutUs();
            //About.Show();
        }

        private void lnkAbout8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //frmAboutUs About = new frmAboutUs();
            //About.Show();
        }

        private void cmdRegister8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }

        private void cmdAdmin8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmAdmin Admin = new frmAdmin();
            //Admin.Show();
        }

        private void cmdSRegister_Click(object sender, EventArgs e)
        {
            MyServer.Service1 Server = new MyServer.Service1();

            if (txtSName.Text == "" || txtSpassword.Text == "")
            {
                MessageBox.Show("Invalid Register Attempt");
            }
            else
            {
                Server.AddStudent(txtSName.Text, txtSage.Text, comboBoxSSecretQs.Text, txtSSecretAnswer.Text, txtSNo.Text, txtSpassword.Text, txtSCPassword.Text);
                MessageBox.Show("You have been registered");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmStudentRegister_Click(object sender, EventArgs e)
        {

        }

        private void txtSName_Click(object sender, EventArgs e)
        {
            txtSName.Clear();
        }

        private void txtSNo_Click(object sender, EventArgs e)
        {
            txtSNo.Clear();
        }

        private void txtSage_Click(object sender, EventArgs e)
        {
            txtSage.Clear();
        }

        private void txtSpassword_Click(object sender, EventArgs e)
        {
            txtSpassword.Clear();
        }

        private void txtSCPassword_Click(object sender, EventArgs e)
        {
            txtSCPassword.Clear();
        }

        private void txtSSecretAnswer_Click(object sender, EventArgs e)
        {
            txtSSecretAnswer.Clear();
        }
    }
}
