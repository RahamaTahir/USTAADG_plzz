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
    public partial class frmLogin : Form
    {
        private Panel panel1;
        private Button cmdAdmin6;
        private Button cmdRegister6;
        private Button cmdHome6;
        private Label lblUstaadG1;
        private LinkLabel lnkContactUs6;
        private LinkLabel lnkAbout6;
        private LinkLabel lnkLogin6;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox picHome;
        private Panel panel7;
        private Panel panel8;
        private Panel panel5;
        private TextBox txtusername;
        private Button cmdLogin;
        private Panel panel9;
        private TextBox txtpassword;
        private CheckBox checkBox1;
        private Panel panel3;
        private Panel panel10;
        private Panel panel6;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblUstaadG_Click(object sender, EventArgs e)
        {

        }

        private void cmdStudent_Click(object sender, EventArgs e)
        {

        }

        private void cmdTutor_Click(object sender, EventArgs e)
        {

        }

        private void lblPLP_Click(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void lnkContactUs5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkAbout5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkLogin5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAdmin6 = new System.Windows.Forms.Button();
            this.cmdRegister6 = new System.Windows.Forms.Button();
            this.cmdHome6 = new System.Windows.Forms.Button();
            this.lblUstaadG1 = new System.Windows.Forms.Label();
            this.lnkContactUs6 = new System.Windows.Forms.LinkLabel();
            this.lnkAbout6 = new System.Windows.Forms.LinkLabel();
            this.lnkLogin6 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdAdmin6);
            this.panel1.Controls.Add(this.cmdRegister6);
            this.panel1.Controls.Add(this.cmdHome6);
            this.panel1.Controls.Add(this.lnkLogin6);
            this.panel1.Controls.Add(this.lnkContactUs6);
            this.panel1.Controls.Add(this.lnkAbout6);
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 54);
            this.panel1.TabIndex = 16;
            // 
            // cmdAdmin6
            // 
            this.cmdAdmin6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAdmin6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAdmin6.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAdmin6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAdmin6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdAdmin6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdmin6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdmin6.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAdmin6.Location = new System.Drawing.Point(1, 1);
            this.cmdAdmin6.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAdmin6.Name = "cmdAdmin6";
            this.cmdAdmin6.Size = new System.Drawing.Size(104, 49);
            this.cmdAdmin6.TabIndex = 11;
            this.cmdAdmin6.Text = "Admin";
            this.cmdAdmin6.UseVisualStyleBackColor = true;
            // 
            // cmdRegister6
            // 
            this.cmdRegister6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegister6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdRegister6.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegister6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegister6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdRegister6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegister6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegister6.ForeColor = System.Drawing.Color.Transparent;
            this.cmdRegister6.Location = new System.Drawing.Point(682, 0);
            this.cmdRegister6.Margin = new System.Windows.Forms.Padding(0);
            this.cmdRegister6.Name = "cmdRegister6";
            this.cmdRegister6.Size = new System.Drawing.Size(110, 49);
            this.cmdRegister6.TabIndex = 8;
            this.cmdRegister6.Text = "Register";
            this.cmdRegister6.UseVisualStyleBackColor = true;
            // 
            // cmdHome6
            // 
            this.cmdHome6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHome6.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdHome6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHome6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome6.ForeColor = System.Drawing.Color.Transparent;
            this.cmdHome6.Location = new System.Drawing.Point(617, 1);
            this.cmdHome6.Margin = new System.Windows.Forms.Padding(0);
            this.cmdHome6.Name = "cmdHome6";
            this.cmdHome6.Size = new System.Drawing.Size(75, 49);
            this.cmdHome6.TabIndex = 6;
            this.cmdHome6.Text = "Home";
            this.cmdHome6.UseVisualStyleBackColor = true;
            this.cmdHome6.Click += new System.EventHandler(this.cmdHome5_Click);
            // 
            // lblUstaadG1
            // 
            this.lblUstaadG1.AutoSize = true;
            this.lblUstaadG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUstaadG1.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUstaadG1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUstaadG1.Location = new System.Drawing.Point(2, 7);
            this.lblUstaadG1.Name = "lblUstaadG1";
            this.lblUstaadG1.Size = new System.Drawing.Size(197, 42);
            this.lblUstaadG1.TabIndex = 20;
            this.lblUstaadG1.Text = "Ustaad G";
            // 
            // lnkContactUs6
            // 
            this.lnkContactUs6.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkContactUs6.AutoSize = true;
            this.lnkContactUs6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkContactUs6.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkContactUs6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkContactUs6.ForeColor = System.Drawing.Color.White;
            this.lnkContactUs6.LinkColor = System.Drawing.Color.Transparent;
            this.lnkContactUs6.Location = new System.Drawing.Point(345, 15);
            this.lnkContactUs6.Name = "lnkContactUs6";
            this.lnkContactUs6.Size = new System.Drawing.Size(106, 23);
            this.lnkContactUs6.TabIndex = 19;
            this.lnkContactUs6.TabStop = true;
            this.lnkContactUs6.Text = "ContactUs";
            // 
            // lnkAbout6
            // 
            this.lnkAbout6.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkAbout6.AutoSize = true;
            this.lnkAbout6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkAbout6.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkAbout6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAbout6.ForeColor = System.Drawing.Color.White;
            this.lnkAbout6.LinkColor = System.Drawing.Color.Transparent;
            this.lnkAbout6.Location = new System.Drawing.Point(464, 14);
            this.lnkAbout6.Name = "lnkAbout6";
            this.lnkAbout6.Size = new System.Drawing.Size(66, 23);
            this.lnkAbout6.TabIndex = 18;
            this.lnkAbout6.TabStop = true;
            this.lnkAbout6.Text = "About";
            // 
            // lnkLogin6
            // 
            this.lnkLogin6.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogin6.AutoSize = true;
            this.lnkLogin6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogin6.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkLogin6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogin6.ForeColor = System.Drawing.Color.White;
            this.lnkLogin6.LinkColor = System.Drawing.Color.Transparent;
            this.lnkLogin6.Location = new System.Drawing.Point(548, 14);
            this.lnkLogin6.Name = "lnkLogin6";
            this.lnkLogin6.Size = new System.Drawing.Size(63, 23);
            this.lnkLogin6.TabIndex = 17;
            this.lnkLogin6.TabStop = true;
            this.lnkLogin6.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 52);
            this.panel2.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(295, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 52);
            this.panel4.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(292, 201);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 79);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Location = new System.Drawing.Point(37, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 48);
            this.panel7.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.Location = new System.Drawing.Point(37, 114);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 49);
            this.panel8.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.txtusername);
            this.panel5.Location = new System.Drawing.Point(40, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 49);
            this.panel5.TabIndex = 25;
            // 
            // cmdLogin
            // 
            this.cmdLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.Color.Transparent;
            this.cmdLogin.Location = new System.Drawing.Point(37, 197);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(0);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(378, 49);
            this.cmdLogin.TabIndex = 23;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdStudent_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel9.Controls.Add(this.txtpassword);
            this.panel9.Location = new System.Drawing.Point(40, 114);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(378, 49);
            this.panel9.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(37, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Is Teacher";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.cmdLogin);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Location = new System.Drawing.Point(295, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 275);
            this.panel3.TabIndex = 25;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Location = new System.Drawing.Point(0, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(451, 79);
            this.panel10.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(62, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Login Form";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.LightGray;
            this.txtusername.Location = new System.Drawing.Point(20, 13);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(170, 24);
            this.txtusername.TabIndex = 27;
            this.txtusername.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtpassword.Location = new System.Drawing.Point(21, 12);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(170, 24);
            this.txtpassword.TabIndex = 27;
            this.txtpassword.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ustaad_G.Properties.Resources.lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(6, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.BackgroundImage = global::Ustaad_G.Properties.Resources.bigstock_Apple_on_School_Books_with_cop_14086715;
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHome.Location = new System.Drawing.Point(0, 52);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(791, 437);
            this.picHome.TabIndex = 15;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ustaad_G.Properties.Resources.Cancel_128;
            this.pictureBox1.Location = new System.Drawing.Point(746, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(791, 489);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUstaadG1);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmdHome5_Click(object sender, EventArgs e)
        {

        }

        private void picHome_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdStudent_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
