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
    public partial class frmSelectRegister : Form
    {
        public frmSelectRegister()
        {
            InitializeComponent();
        }

        private void cmdRegister5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }

        private void cmdTutor_Click(object sender, EventArgs e)
        {
            frmRegisterTutor RegisterT = new frmRegisterTutor();
            this.Hide();
            RegisterT.Show();
        }

        private void cmdStudent_Click(object sender, EventArgs e)
        {
            frmRegisterStudent RegisterS = new frmRegisterStudent();
            this.Hide();
            RegisterS.Show();
        }
    }
}
