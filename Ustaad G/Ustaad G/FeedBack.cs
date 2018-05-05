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
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ratings = "0";
            if (radioButton1.Checked)
            {
                ratings = "1";
            }else if (radioButton2.Checked)
            {
                ratings = "2";
            }else if (radioButton3.Checked)
            {
                ratings = "3";
            }else if (radioButton4.Checked)
            {
                ratings = "4";
            }
            else if(radioButton5.Checked)
            {
                ratings = "5";
            }
            MyServer.Service1 Server = new MyServer.Service1();
            Server.addRating(ratings);
            MessageBox.Show("Thank you for your response. It would be helpful for us :D");
            this.Hide();
        }
    }
}
