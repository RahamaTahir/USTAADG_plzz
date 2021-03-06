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
    public partial class frmfiltered_teacher : Form
    {
        public static List<MyServer.Teacher> list;
        public static List<MyServer.Teacher> Steachers;

        static DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
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
            comboBoxSelectArea.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBoxSelectArea.Text == "")
            {
                MessageBox.Show("Please select the area *_*");
            }
            else
            {
                MyServer.Service1 Server = new MyServer.Service1();
                list = Server.Search_Teacher(comboBoxSelectArea.Text).ToList<MyServer.Teacher>();
                if (list.Count == 0)
                {
                    MessageBox.Show("No teachers found in the given area");
                }
                else
                {

                    if (comboBoxSelectArea.Text != " ")
                    {
                        DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
                        c.ValueType = typeof(bool);
                        c.Name = "Chk";
                        c.HeaderText = "Select";


                        BindingSource S = new BindingSource();
                        S.DataSource = list;
                        dataGridViewSearchRecords.DataSource = S;
                        dataGridViewSearchRecords.Columns.Add(c);

                        dataGridViewSearchRecords.Columns.Remove("account_no");
                        dataGridViewSearchRecords.Columns.Remove("cPassword");
                        dataGridViewSearchRecords.Columns.Remove("password");
                        dataGridViewSearchRecords.Columns.Remove("answer");
                        dataGridViewSearchRecords.Columns.Remove("secret_Question");
                        dataGridViewSearchRecords.Columns.Remove("Account");
                        dataGridViewSearchRecords.Columns.Remove("Id");
                        dataGridViewSearchRecords.Columns.Remove("IdSpecified");
                        dataGridViewSearchRecords.Columns.Remove("Paid");
                        dataGridViewSearchRecords.Columns.Remove("PaidSpecified");
                        dataGridViewSearchRecords.Columns.Remove("receive");
                        dataGridViewSearchRecords.Columns.Remove("receiveSpecified");
                        
                    }
                }
            }
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
            this.Hide();
            studentDetails sd = new studentDetails();
            sd.Show();
        }

        private void cmdAdmin6_Click(object sender, EventArgs e)
        {
            frmAdminPassword L = new frmAdminPassword();
            this.Hide();
            L.Show();



        }

        private void cmdHome6_Click(object sender, EventArgs e)
        {
            frmLogin L = new frmLogin();
            this.Hide();
            L.Show();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            bool isfound = false;
            bool x = true;
            int i = 0;
            MyServer.Service1 Server = new MyServer.Service1();
            foreach (DataGridViewRow row in dataGridViewSearchRecords.Rows)
            {
                if (Convert.ToBoolean(row.Cells[9].Value))
                {
                    MyServer.Student std = Server.selected_teachers_st(list.ElementAt(i).Id, x, myUtil.std_loggedin);
                    myUtil.std_loggedin = std;
                    Steachers = Server.selected_teachers(list.ElementAt(i)).ToList<MyServer.Teacher>();
                    MessageBox.Show("Teacher Selected");
                    isfound = true;

                }
                i++;
            }
            if (isfound == true)
            {
                studentDetails sd = new studentDetails();
                this.Hide();
                sd.Show();
            }
            else
            {
                MessageBox.Show("Please select teacher first!");
            }

        }

        private void lnkAbout6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAbout R = new frmAbout();
            R.Show();
        }
    }
}
