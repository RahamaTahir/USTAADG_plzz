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

       
        private static frmSearch search_frm;
        public static frmSearch GetInstance()
        {
            if (search_frm == null)
            {
                search_frm = new frmSearch();
            }
            return search_frm;
        }
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text == "" || txtUname.Text == "" || comboBoxLevel.Text == "")
            {
                MessageBox.Show("All the required information should be entered :(");
            }
            else
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
                    frmfiltered_teacher R = new frmfiltered_teacher();
                    this.Hide();
                    R.Show();
                }
                else
                {
                    MessageBox.Show("You are not verified either your password or username is incorrect *_* ");
                }
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
            frmLogin L = new frmLogin();
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

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.Clear();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSCity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmdViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void cmdAdmin3_Click(object sender, EventArgs e)
        {
            frmAdminPassword L = new frmAdminPassword();
            this.Hide();
            L.Show();
        }

        private void cmdHome3_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentDetails sd = new studentDetails();
            sd.Show();
        }

        private void comboBoxLevel_Click(object sender, EventArgs e)
        {
            comboBoxLevel.ResetText();
        }

        private void lnkAbout3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout R = new frmAbout();
            R.Show();
        }
    }
}
