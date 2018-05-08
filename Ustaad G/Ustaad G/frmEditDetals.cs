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
    public partial class frmEditDetals : Form
    {
        public frmEditDetals()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            if (txtEName.Text == "" || txtEAge.Text == "" || txtECntctNo.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Please enter the reqiured information");
            }
            else
            {
                bool isFound;
                bool isFoundPass;
                MyServer.Service1 Server = new MyServer.Service1();
                if (chkT.Checked)
                {
                    Server.isUniqueT(txtEName.Text, out isFound, out isFoundPass);
                    if (isFound == true)
                    {
                        Server.EditTeacherDetails(txtPwd.Text, txtEName.Text, txtEAge.Text, txtECntctNo.Text);
                        MessageBox.Show("Your Details are edited");
                        frmLogin L = new frmLogin();
                        this.Hide();
                        L.Show();
                    }
                    else
                    {
                        MessageBox.Show("This userename already exist");
                    }
                }
                else
                {
                    Server.isUniqueS(txtEName.Text, out isFound, out isFoundPass);
                    if (isFound == true)
                    {
                        Server.EditStudentDetails(txtPwd.Text, txtEName.Text, txtEAge.Text, txtECntctNo.Text);
                        MessageBox.Show("Your Details are edited");
                        frmLogin L = new frmLogin();
                        this.Hide();
                        L.Show();
                    }
                    else
                    {
                        MessageBox.Show("This userename already exist");
                    }
                }
                    
            }
                
               
                
            
        }

        private void cmdAsk_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                string password = txtPwd.Text;
                MyServer.Service1 Server = new MyServer.Service1();
                bool isFound;
                bool isFoundPass;

                if (chkT.Checked)
                {
                    Server.isfoundTeacher(password, out isFound, out isFoundPass);
                }
                else
                {
                    Server.isfoundStudent(password, out isFound, out isFoundPass);
                }
                if (isFound == true)
                {
                    MessageBox.Show("Validation Successful");
                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                }
            }
        }

        private void txtECntctNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblPLP_Click(object sender, EventArgs e)
        {

        }

        private void chkT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEAge_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblUstaadG_Click(object sender, EventArgs e)
        {

        }

        private void lnkLogin9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkAbout9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout R = new frmAbout();
            R.Show();
        }

        private void lnkContactUs9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.Clear();
        }

        private void txtEName_Click(object sender, EventArgs e)
        {
            txtEName.Clear();
        }

        private void txtEAge_Click(object sender, EventArgs e)
        {
            txtEAge.Clear();
        }

        private void txtECntctNo_Click(object sender, EventArgs e)
        {
            txtECntctNo.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdHome9_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void cmdAdmin9_Click(object sender, EventArgs e)
        {
            frmAdminPassword L = new frmAdminPassword();
            this.Hide();
            L.Show();
        }

        private void cmdRegister9_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }
    }
}
