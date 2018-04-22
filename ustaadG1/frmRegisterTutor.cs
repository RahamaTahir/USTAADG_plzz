using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ustaadG1
{
    public partial class frmRegisterTutor : Form
    {
        public frmRegisterTutor()
        {
            InitializeComponent();
        }

        private void cmdRegister2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
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
    }
}
