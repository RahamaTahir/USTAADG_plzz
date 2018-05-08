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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void cmdHome4_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MyServer.Service1 Server = new MyServer.Service1();
            List<MyServer.Teacher> list = Server.ShowAllTeachers().ToList<MyServer.Teacher>();

            BindingSource S = new BindingSource();
            S.DataSource = list;
            dataGridViewAllTeachersRecord.DataSource = S;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MyServer.Service1 Server = new MyServer.Service1();
            List<MyServer.Student> Slist = Server.ShowAllStudents().ToList<MyServer.Student>();

            BindingSource S = new BindingSource();
            S.DataSource = Slist;
            dataGridViewShowAllStudents.DataSource = S;
        }

        private void dataGridViewST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MyServer.Service1 Server = new MyServer.Service1();
            Server.deleteStudent(e.RowIndex.ToString());
            List<MyServer.Student> Slist = Server.ShowAllStudents().ToList<MyServer.Student>();

            BindingSource S = new BindingSource();
            S.DataSource = Slist;
            dataGridViewShowAllStudents.DataSource = S;
        }

        private void cmdHome4_Click_1(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void cmdRegister4_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void cmdVerify_Click(object sender, EventArgs e)
        {

        }

        private void lnkAbout4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout R = new frmAbout();
            R.Show();
        }
    }
}
