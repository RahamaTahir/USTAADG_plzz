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
        }

        public studentDetails(string role)
        {
            InitializeComponent();
            dataGridViewSearchRecords.Hide();
            name.Text = myUtil.teacher_loggedIn.Username;
            number.Text = myUtil.teacher_loggedIn.Contact_no;
            age.Text = myUtil.teacher_loggedIn.Age;
            gender.Text = myUtil.teacher_loggedIn.Gender;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FeedBack fb = new FeedBack();
            fb.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
