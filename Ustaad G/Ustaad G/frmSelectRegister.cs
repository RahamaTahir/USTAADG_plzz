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
    public partial class frmSelectRegister : Form
    {
        public frmSelectRegister()
        {
            InitializeComponent();
        }
        private static frmSelectRegister select_frm;
        public static frmSelectRegister GetInstance()
        {
            if (select_frm == null)
            {
                select_frm = new frmSelectRegister();
            }
            return select_frm;
        }

        private void lnkAbout1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //frmAboutUs About = new frmAboutUs();
            //About.Show();
        }

        private void cmdHome5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form1 Home = new Form1();
            //Home.Show();
        }

        private void lnkLogin5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin L = new frmlogin();
            this.Hide();
            L.Show();
        }

        private void lnkContactUs5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Hide();
            //frmAboutUs About = new frmAboutUs();
            //About.Show();
        }

        private void cmdRegister5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmSelectRegister SelectR = new frmSelectRegister();
            //SelectR.Show();
        }

        private void cmdAdmin5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmAdmin Admin = new frmAdmin();
            //Admin.Show();
        }

        private void cmdTutor_Click(object sender, EventArgs e)
        {
            frmRegisterTutor RegisterT = new frmRegisterTutor();
            this.Hide();
            RegisterT.Show();
        }

        private void cmdStudent_Click(object sender, EventArgs e)
        {
            frmStudentRegister RegisterS = new frmStudentRegister();
            this.Hide();
            RegisterS.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
