﻿using System;
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
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }
        private static frmResetPassword Reset_frm;
        public static frmResetPassword GetInstance()
        {
            if (Reset_frm == null)
            {
                Reset_frm = new frmResetPassword();
            }
            return Reset_frm;
        }
        private void cmdRegister9_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }

        private void lnkLogin9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            if (txtResetName.Text == "" || txtAnswerReset.Text == "" || comboBoxSecretQs.Text == "")
            {
                MessageBox.Show("All the required information should be entered! -_-");
            }
            else
            {
                string username = txtResetName.Text;
                string answer = txtAnswerReset.Text;
                string Question = comboBoxSecretQs.Text;
                MyServer.Service1 Server = new MyServer.Service1();
                bool isFound;
                bool isFoundPass;

                if (chkT.Checked)
                {
                    Server.ResetPasswordT(username, Question, answer, out isFound, out isFoundPass);
                }
                else
                {
                    Server.ResetPasswordS(username, Question, answer, out isFound, out isFoundPass);
                }
                if (isFound == true)
                {
                    frmNewPassword frm;
                    if (chkT.Checked)
                    {
                        frm = new frmNewPassword(username, "Teacher");
                    }
                    else
                    {
                        frm = new frmNewPassword(username, "Student");
                    }
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Answer!");
                }
            }
        }

        private void cmdAsk_Click(object sender, EventArgs e)
        {
            string username = txtResetName.Text;
            MyServer.Service1 Server = new MyServer.Service1();
            bool isFound;
            bool isFoundPass;

            if (chkT.Checked)
            {
                Server.isfoundT(username, out isFound, out isFoundPass);
            }
            else
            {
                Server.isfoundS(username,  out isFound, out isFoundPass);
            }
            if (isFound == true)
            {
                MessageBox.Show("Validation Successful");
            }
            else
            {
                MessageBox.Show("Validation Failed!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void cmdAdmin9_Click(object sender, EventArgs e)
        {
            frmAdminPassword L = new frmAdminPassword();
            this.Hide();
            L.Show();
        }

        private void cmdHome9_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void comboBoxSecretQs_Click(object sender, EventArgs e)
        {
            comboBoxSecretQs.ResetText();
        }

        private void txtResetName_Click(object sender, EventArgs e)
        {
            txtResetName.Clear();
        }

        private void txtAnswerReset_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAnswerReset_Click(object sender, EventArgs e)
        {
            txtAnswerReset.Clear();
        }

        private void lnkAbout9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout R = new frmAbout();
            R.Show();
        }
    }
}
