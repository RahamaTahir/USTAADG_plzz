﻿namespace Ustaad_G
{
    partial class frmfiltered_teacher
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAdmin6 = new System.Windows.Forms.Button();
            this.cmdAccount = new System.Windows.Forms.Button();
            this.cmdHome6 = new System.Windows.Forms.Button();
            this.dataGridViewSearchRecords = new System.Windows.Forms.DataGridView();
            this.lblUstaadG = new System.Windows.Forms.Label();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.lnkAbout6 = new System.Windows.Forms.LinkLabel();
            this.lblPLP = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.comboBoxSelectArea = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdAdmin6);
            this.panel1.Controls.Add(this.cmdAccount);
            this.panel1.Controls.Add(this.cmdHome6);
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-2, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 54);
            this.panel1.TabIndex = 55;
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
            this.cmdAdmin6.Location = new System.Drawing.Point(5, -1);
            this.cmdAdmin6.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAdmin6.Name = "cmdAdmin6";
            this.cmdAdmin6.Size = new System.Drawing.Size(109, 49);
            this.cmdAdmin6.TabIndex = 11;
            this.cmdAdmin6.Text = "Admin";
            this.cmdAdmin6.UseVisualStyleBackColor = true;
            this.cmdAdmin6.Click += new System.EventHandler(this.cmdAdmin6_Click);
            // 
            // cmdAccount
            // 
            this.cmdAccount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAccount.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAccount.ForeColor = System.Drawing.Color.Transparent;
            this.cmdAccount.Location = new System.Drawing.Point(570, 1);
            this.cmdAccount.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAccount.Name = "cmdAccount";
            this.cmdAccount.Size = new System.Drawing.Size(128, 49);
            this.cmdAccount.TabIndex = 8;
            this.cmdAccount.Text = " Account";
            this.cmdAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAccount.UseVisualStyleBackColor = true;
            this.cmdAccount.Click += new System.EventHandler(this.cmdRegister6_Click);
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
            this.cmdHome6.Location = new System.Drawing.Point(502, 1);
            this.cmdHome6.Margin = new System.Windows.Forms.Padding(0);
            this.cmdHome6.Name = "cmdHome6";
            this.cmdHome6.Size = new System.Drawing.Size(75, 49);
            this.cmdHome6.TabIndex = 6;
            this.cmdHome6.Text = "Home";
            this.cmdHome6.UseVisualStyleBackColor = true;
            this.cmdHome6.Click += new System.EventHandler(this.cmdHome6_Click);
            // 
            // dataGridViewSearchRecords
            // 
            this.dataGridViewSearchRecords.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewSearchRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchRecords.Location = new System.Drawing.Point(19, 220);
            this.dataGridViewSearchRecords.Name = "dataGridViewSearchRecords";
            this.dataGridViewSearchRecords.Size = new System.Drawing.Size(737, 231);
            this.dataGridViewSearchRecords.TabIndex = 60;
            this.dataGridViewSearchRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchRecords_CellContentClick);
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
            this.lblUstaadG.TabIndex = 54;
            this.lblUstaadG.Text = "Ustaad G";
            // 
            // cmdSelect
            // 
            this.cmdSelect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdSelect.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSelect.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.ForeColor = System.Drawing.Color.Transparent;
            this.cmdSelect.Location = new System.Drawing.Point(606, 466);
            this.cmdSelect.Margin = new System.Windows.Forms.Padding(0);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(121, 36);
            this.cmdSelect.TabIndex = 61;
            this.cmdSelect.Text = "Select";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
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
            this.lnkAbout6.Location = new System.Drawing.Point(673, 48);
            this.lnkAbout6.Name = "lnkAbout6";
            this.lnkAbout6.Size = new System.Drawing.Size(66, 23);
            this.lnkAbout6.TabIndex = 58;
            this.lnkAbout6.TabStop = true;
            this.lnkAbout6.Text = "About";
            this.lnkAbout6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout6_LinkClicked);
            // 
            // lblPLP
            // 
            this.lblPLP.AutoSize = true;
            this.lblPLP.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPLP.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPLP.Location = new System.Drawing.Point(12, 156);
            this.lblPLP.Name = "lblPLP";
            this.lblPLP.Size = new System.Drawing.Size(295, 40);
            this.lblPLP.TabIndex = 56;
            this.lblPLP.Text = "Search Results";
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.BackgroundImage = global::Ustaad_G.Properties.Resources.bigstock_Apple_on_School_Books_with_cop_14086715;
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHome.Location = new System.Drawing.Point(0, 0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(791, 521);
            this.picHome.TabIndex = 53;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // comboBoxSelectArea
            // 
            this.comboBoxSelectArea.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxSelectArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSelectArea.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectArea.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxSelectArea.FormattingEnabled = true;
            this.comboBoxSelectArea.Items.AddRange(new object[] {
            "Model Town, Lahore",
            "Johar Town, Lahore",
            "Defence, Lahore",
            "Shadrha, Lahore",
            "Dandoth, Chitral",
            "Model Town, Gujranwala"});
            this.comboBoxSelectArea.Location = new System.Drawing.Point(359, 163);
            this.comboBoxSelectArea.Name = "comboBoxSelectArea";
            this.comboBoxSelectArea.Size = new System.Drawing.Size(230, 33);
            this.comboBoxSelectArea.TabIndex = 65;
            this.comboBoxSelectArea.SelectedIndexChanged += new System.EventHandler(this.comboBoxSSecretQs_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.Transparent;
            this.Search.Location = new System.Drawing.Point(614, 162);
            this.Search.Margin = new System.Windows.Forms.Padding(0);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(137, 36);
            this.Search.TabIndex = 66;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // frmfiltered_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 521);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.comboBoxSelectArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSearchRecords);
            this.Controls.Add(this.lblUstaadG);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.lnkAbout6);
            this.Controls.Add(this.lblPLP);
            this.Controls.Add(this.picHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmfiltered_teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmfiltered_teacher";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdHome6;
        private System.Windows.Forms.DataGridView dataGridViewSearchRecords;
        private System.Windows.Forms.Label lblUstaadG;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.LinkLabel lnkAbout6;
        private System.Windows.Forms.Label lblPLP;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.ComboBox comboBoxSelectArea;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button cmdAdmin6;
        private System.Windows.Forms.Button cmdAccount;
    }
}