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
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
            //this.Hide();
            //Form1 Home = new Form1();
            //Home.Show();
        }

        private void lnkLogin8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin L = new frmLogin();
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
            frmAbout R = new frmAbout();
            R.Show();
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
            frmAdminPassword L = new frmAdminPassword();
            this.Hide();
            L.Show();
            //this.Hide();
            //frmAdmin Admin = new frmAdmin();
            //Admin.Show();
        }

        private void cmdSRegister_Click(object sender, EventArgs e)
        {
            MyServer.Service1 Server = new MyServer.Service1();
            if (txtRange.Text == "" || comboBoxSelectArea.Text == "" || txttiming.Text == "" || txtSName.Text == "" || txtSpassword.Text == "" || txtSNo.Text == "" || txtSage.Text == "" || txtSCPassword.Text == "" || comboBoxSSecretQs.Text == "" || txtSSecretAnswer.Text == "" || txtCreditcard.Text== "" || comboGender.Text== "")
            {

                MessageBox.Show("please enter all the required information to register");
            }
            else if (!chkBSTerms.Checked)
            {
                MessageBox.Show("You have to accept the terms and conditions to register yourself!");
            }
            else
            {
                bool isFound;
                bool isFoundPass;

                if (txtSpassword.Text == txtSCPassword.Text)
                {
                    Server.isUniqueS(txtSName.Text, out isFound, out isFoundPass);
                    if (isFound == true)
                    {
                        Server.AddStudent( txtSName.Text, txtSage.Text, comboBoxSSecretQs.Text, txtSSecretAnswer.Text, txtSNo.Text, txtSpassword.Text, txtSCPassword.Text , comboGender.Text , txtRange.Text , comboBoxSelectArea.Text, txttiming.Text);
                        MessageBox.Show("You have been registered");
                        frmLogin L = new frmLogin();
                        this.Hide();
                        L.Show();
                        //frmLogin L = new frmLogin();
                        //this.Hide();
                        //L.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username is not unique");
                    }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
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

        private void comboGender_Click(object sender, EventArgs e)
        {
            comboGender.ResetText();
        }

        private void txtCreditcard_Click(object sender, EventArgs e)
        {
            txtCreditcard.Clear();
        }

        private void comboBoxSSecretQs_Click(object sender, EventArgs e)
        {
            comboBoxSSecretQs.ResetText();
        }

        private void txtRange_Click(object sender, EventArgs e)
        {
            txtRange.Clear();
        }

        private void comboBoxSelectArea_Click(object sender, EventArgs e)
        {
            comboBoxSelectArea.ResetText();
        }

        private void txttiming_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttiming_Click(object sender, EventArgs e)
        {
            txttiming.Clear();
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void lnklblSTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTermsAndConditions L = new frmTermsAndConditions();
            L.Show();
        }
    }
}
