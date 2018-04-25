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
    public partial class frmfiltered_teacher : Form
    {
        public frmfiltered_teacher()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewSearchRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
            MyServer.Service1 Server = new MyServer.Service1();
            List<MyServer.Teacher> list = Server.Search_Teacher(comboBoxSelectArea.Text).ToList<MyServer.Teacher>();

            BindingSource S = new BindingSource();
            S.DataSource = list;
            dataGridViewSearchRecords.DataSource = S;


        }

        private void comboBoxSSecretQs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnkLogin6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void cmdRegister6_Click(object sender, EventArgs e)
        {
            frmSelectRegister R = new frmSelectRegister();
            this.Hide();
            R.Show();
        }
    }
}
