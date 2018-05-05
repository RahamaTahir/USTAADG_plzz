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
    public partial class studentDetails : Form
    {
        public studentDetails()
        {
            InitializeComponent();
            name.Text = myUtil.std_loggedin.Username;
            number.Text = myUtil.std_loggedin.Contact_no;
            age.Text = myUtil.std_loggedin.Age;
            gender.Text = myUtil.std_loggedin.Gender;
            Account.Text = myUtil.std_loggedin.Account;
            cmdReceive.Hide();
        }

        public studentDetails(string role)
        {
            InitializeComponent();
            dataGridViewSearchRecords.Hide();
            cmdShowSelected.Hide();
            cmdPay.Hide();
            name.Text = myUtil.teacher_loggedIn.Username;
            number.Text = myUtil.teacher_loggedIn.Contact_no;
            age.Text = myUtil.teacher_loggedIn.Age;
            gender.Text = myUtil.teacher_loggedIn.Gender;
            Account.Text = myUtil.std_loggedin.Account;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FeedBack fb = new FeedBack();
            fb.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BindingSource s = new BindingSource();
            s.DataSource = frmfiltered_teacher.Steachers;
            dataGridViewSearchRecords.DataSource = s;

            dataGridViewSearchRecords.Columns.Remove("account_no");
            dataGridViewSearchRecords.Columns.Remove("cPassword");
            dataGridViewSearchRecords.Columns.Remove("password");
            dataGridViewSearchRecords.Columns.Remove("answer");
            dataGridViewSearchRecords.Columns.Remove("secret_Question");

        }

        private void dataGridViewSearchRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdHome6_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            this.Hide();
            f.Show();
        }

        private void cmdRegister6_Click(object sender, EventArgs e)
        {
            frmSelectRegister fs = new frmSelectRegister();
            this.Hide();
            fs.Show();
        }

        private void lnkLogin6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin fl = new frmLogin();
            this.Hide();
            fl.Show();
        }

        private void lblUstaadG_Click(object sender, EventArgs e)
        {

        }

        private void cmdEditDetails_Click(object sender, EventArgs e)
        {
            frmEditDetals R = new frmEditDetals();
            this.Hide();
            R.Show();
        }
    }
}
