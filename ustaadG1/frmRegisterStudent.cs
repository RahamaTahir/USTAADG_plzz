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
    public partial class frmRegisterStudent : Form
    {
        public frmRegisterStudent()
        {
            InitializeComponent();
        }

        private void cmdRegister8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
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
    }
}
