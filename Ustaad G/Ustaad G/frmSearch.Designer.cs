namespace Ustaad_G
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdViewDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.lblPLP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAdmin3 = new System.Windows.Forms.Button();
            this.cmdRegister3 = new System.Windows.Forms.Button();
            this.cmdHome3 = new System.Windows.Forms.Button();
            this.lnkLogin3 = new System.Windows.Forms.LinkLabel();
            this.lnkAbout3 = new System.Windows.Forms.LinkLabel();
            this.lnkContactUs3 = new System.Windows.Forms.LinkLabel();
            this.lblUstaadG = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdViewDetails
            // 
            this.cmdViewDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdViewDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdViewDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdViewDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdViewDetails.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewDetails.ForeColor = System.Drawing.Color.Transparent;
            this.cmdViewDetails.Location = new System.Drawing.Point(272, 389);
            this.cmdViewDetails.Margin = new System.Windows.Forms.Padding(0);
            this.cmdViewDetails.Name = "cmdViewDetails";
            this.cmdViewDetails.Size = new System.Drawing.Size(204, 33);
            this.cmdViewDetails.TabIndex = 43;
            this.cmdViewDetails.Text = "View Details";
            this.cmdViewDetails.UseVisualStyleBackColor = true;
            this.cmdViewDetails.Click += new System.EventHandler(this.cmdViewDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(217, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "View MyAccount ";
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdSearch.BackgroundImage = global::Ustaad_G.Properties.Resources.white_google_web_search_512;
            this.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearch.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.ForeColor = System.Drawing.Color.Transparent;
            this.cmdSearch.Location = new System.Drawing.Point(614, 214);
            this.cmdSearch.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(94, 83);
            this.cmdSearch.TabIndex = 41;
            this.cmdSearch.UseVisualStyleBackColor = false;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLevel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLevel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "A-Levels",
            "O-Levels",
            "Primary",
            "Matric Science Group",
            "Matric Arts Group",
            "FSC-PreEngineering",
            "FSC-PreMedical",
            "ICS",
            "Degree Level"});
            this.comboBoxLevel.Location = new System.Drawing.Point(379, 239);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(197, 33);
            this.comboBoxLevel.TabIndex = 40;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPwd.Location = new System.Drawing.Point(140, 266);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(197, 33);
            this.txtPwd.TabIndex = 39;
            this.txtPwd.Text = "Enter Password";
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPwd.Click += new System.EventHandler(this.txtPwd_Click);
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtUname.Location = new System.Drawing.Point(140, 214);
            this.txtUname.Multiline = true;
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(197, 33);
            this.txtUname.TabIndex = 37;
            this.txtUname.Text = "Enter Username";
            this.txtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUname.Click += new System.EventHandler(this.txtUname_Click);
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            // 
            // lblPLP
            // 
            this.lblPLP.AutoSize = true;
            this.lblPLP.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPLP.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPLP.Location = new System.Drawing.Point(217, 157);
            this.lblPLP.Name = "lblPLP";
            this.lblPLP.Size = new System.Drawing.Size(298, 40);
            this.lblPLP.TabIndex = 36;
            this.lblPLP.Text = "Search a Tutor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdAdmin3);
            this.panel1.Controls.Add(this.cmdRegister3);
            this.panel1.Controls.Add(this.cmdHome3);
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 54);
            this.panel1.TabIndex = 35;
            // 
            // cmdAdmin3
            // 
            this.cmdAdmin3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAdmin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAdmin3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAdmin3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAdmin3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdAdmin3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdmin3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdmin3.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAdmin3.Location = new System.Drawing.Point(5, -1);
            this.cmdAdmin3.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAdmin3.Name = "cmdAdmin3";
            this.cmdAdmin3.Size = new System.Drawing.Size(109, 49);
            this.cmdAdmin3.TabIndex = 11;
            this.cmdAdmin3.Text = "Admin";
            this.cmdAdmin3.UseVisualStyleBackColor = true;
            this.cmdAdmin3.Click += new System.EventHandler(this.cmdAdmin3_Click);
            // 
            // cmdRegister3
            // 
            this.cmdRegister3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegister3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdRegister3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegister3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegister3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdRegister3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegister3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegister3.ForeColor = System.Drawing.Color.Transparent;
            this.cmdRegister3.Location = new System.Drawing.Point(570, 1);
            this.cmdRegister3.Margin = new System.Windows.Forms.Padding(0);
            this.cmdRegister3.Name = "cmdRegister3";
            this.cmdRegister3.Size = new System.Drawing.Size(128, 49);
            this.cmdRegister3.TabIndex = 8;
            this.cmdRegister3.Text = "Register";
            this.cmdRegister3.UseVisualStyleBackColor = true;
            this.cmdRegister3.Click += new System.EventHandler(this.cmdRegister3_Click);
            // 
            // cmdHome3
            // 
            this.cmdHome3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHome3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdHome3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHome3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome3.ForeColor = System.Drawing.Color.Transparent;
            this.cmdHome3.Location = new System.Drawing.Point(502, 1);
            this.cmdHome3.Margin = new System.Windows.Forms.Padding(0);
            this.cmdHome3.Name = "cmdHome3";
            this.cmdHome3.Size = new System.Drawing.Size(75, 49);
            this.cmdHome3.TabIndex = 6;
            this.cmdHome3.Text = "Home";
            this.cmdHome3.UseVisualStyleBackColor = true;
            this.cmdHome3.Click += new System.EventHandler(this.cmdHome3_Click);
            // 
            // lnkLogin3
            // 
            this.lnkLogin3.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogin3.AutoSize = true;
            this.lnkLogin3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkLogin3.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkLogin3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogin3.ForeColor = System.Drawing.Color.White;
            this.lnkLogin3.LinkColor = System.Drawing.Color.Transparent;
            this.lnkLogin3.Location = new System.Drawing.Point(684, 48);
            this.lnkLogin3.Name = "lnkLogin3";
            this.lnkLogin3.Size = new System.Drawing.Size(63, 23);
            this.lnkLogin3.TabIndex = 34;
            this.lnkLogin3.TabStop = true;
            this.lnkLogin3.Text = "Login";
            this.lnkLogin3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin3_LinkClicked);
            // 
            // lnkAbout3
            // 
            this.lnkAbout3.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkAbout3.AutoSize = true;
            this.lnkAbout3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkAbout3.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkAbout3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAbout3.ForeColor = System.Drawing.Color.White;
            this.lnkAbout3.LinkColor = System.Drawing.Color.Transparent;
            this.lnkAbout3.Location = new System.Drawing.Point(610, 48);
            this.lnkAbout3.Name = "lnkAbout3";
            this.lnkAbout3.Size = new System.Drawing.Size(66, 23);
            this.lnkAbout3.TabIndex = 33;
            this.lnkAbout3.TabStop = true;
            this.lnkAbout3.Text = "About";
            // 
            // lnkContactUs3
            // 
            this.lnkContactUs3.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkContactUs3.AutoSize = true;
            this.lnkContactUs3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkContactUs3.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkContactUs3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkContactUs3.ForeColor = System.Drawing.Color.White;
            this.lnkContactUs3.LinkColor = System.Drawing.Color.Transparent;
            this.lnkContactUs3.Location = new System.Drawing.Point(494, 48);
            this.lnkContactUs3.Name = "lnkContactUs3";
            this.lnkContactUs3.Size = new System.Drawing.Size(106, 23);
            this.lnkContactUs3.TabIndex = 32;
            this.lnkContactUs3.TabStop = true;
            this.lnkContactUs3.Text = "ContactUs";
            // 
            // lblUstaadG
            // 
            this.lblUstaadG.AutoSize = true;
            this.lblUstaadG.BackColor = System.Drawing.Color.Gainsboro;
            this.lblUstaadG.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUstaadG.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUstaadG.Location = new System.Drawing.Point(26, 15);
            this.lblUstaadG.Name = "lblUstaadG";
            this.lblUstaadG.Size = new System.Drawing.Size(256, 55);
            this.lblUstaadG.TabIndex = 31;
            this.lblUstaadG.Text = "Ustaad G";
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.BackgroundImage = global::Ustaad_G.Properties.Resources.bigstock_Apple_on_School_Books_with_cop_14086715;
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHome.Location = new System.Drawing.Point(0, 0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(791, 454);
            this.picHome.TabIndex = 30;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(12, 422);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 23);
            this.linkLabel1.TabIndex = 44;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Close";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 454);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmdViewDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblPLP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnkLogin3);
            this.Controls.Add(this.lnkAbout3);
            this.Controls.Add(this.lnkContactUs3);
            this.Controls.Add(this.lblUstaadG);
            this.Controls.Add(this.picHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdViewDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label lblPLP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdAdmin3;
        private System.Windows.Forms.Button cmdRegister3;
        private System.Windows.Forms.Button cmdHome3;
        private System.Windows.Forms.LinkLabel lnkLogin3;
        private System.Windows.Forms.LinkLabel lnkAbout3;
        private System.Windows.Forms.LinkLabel lnkContactUs3;
        private System.Windows.Forms.Label lblUstaadG;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}