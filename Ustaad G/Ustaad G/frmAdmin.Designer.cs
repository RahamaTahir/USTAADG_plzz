﻿namespace Ustaad_G
{
    partial class frmAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewShowAllStudents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkAbout4 = new System.Windows.Forms.LinkLabel();
            this.lblUstaadG = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdHome4 = new System.Windows.Forms.Button();
            this.dataGridViewAllTeachersRecord = new System.Windows.Forms.DataGridView();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAllStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTeachersRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShowAllStudents
            // 
            this.dataGridViewShowAllStudents.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewShowAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAllStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewShowAllStudents.Location = new System.Drawing.Point(24, 467);
            this.dataGridViewShowAllStudents.Name = "dataGridViewShowAllStudents";
            this.dataGridViewShowAllStudents.Size = new System.Drawing.Size(737, 161);
            this.dataGridViewShowAllStudents.TabIndex = 40;
            this.dataGridViewShowAllStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewST_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Delete";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(305, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 39;
            this.label1.Text = "Admin ";
            // 
            // lnkAbout4
            // 
            this.lnkAbout4.ActiveLinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkAbout4.AutoSize = true;
            this.lnkAbout4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lnkAbout4.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lnkAbout4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAbout4.ForeColor = System.Drawing.Color.White;
            this.lnkAbout4.LinkColor = System.Drawing.Color.Transparent;
            this.lnkAbout4.Location = new System.Drawing.Point(610, 48);
            this.lnkAbout4.Name = "lnkAbout4";
            this.lnkAbout4.Size = new System.Drawing.Size(66, 23);
            this.lnkAbout4.TabIndex = 38;
            this.lnkAbout4.TabStop = true;
            this.lnkAbout4.Text = "About";
            this.lnkAbout4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout4_LinkClicked);
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
            this.lblUstaadG.TabIndex = 36;
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
            this.picHome.Size = new System.Drawing.Size(791, 670);
            this.picHome.TabIndex = 35;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdHome4);
            this.panel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 54);
            this.panel1.TabIndex = 44;
            // 
            // cmdHome4
            // 
            this.cmdHome4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdHome4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdHome4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cmdHome4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHome4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHome4.ForeColor = System.Drawing.Color.Transparent;
            this.cmdHome4.Location = new System.Drawing.Point(559, 1);
            this.cmdHome4.Margin = new System.Windows.Forms.Padding(0);
            this.cmdHome4.Name = "cmdHome4";
            this.cmdHome4.Size = new System.Drawing.Size(75, 49);
            this.cmdHome4.TabIndex = 6;
            this.cmdHome4.Text = "Home";
            this.cmdHome4.UseVisualStyleBackColor = true;
            this.cmdHome4.Click += new System.EventHandler(this.cmdHome4_Click_1);
            // 
            // dataGridViewAllTeachersRecord
            // 
            this.dataGridViewAllTeachersRecord.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewAllTeachersRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllTeachersRecord.Location = new System.Drawing.Point(24, 239);
            this.dataGridViewAllTeachersRecord.Name = "dataGridViewAllTeachersRecord";
            this.dataGridViewAllTeachersRecord.Size = new System.Drawing.Size(737, 168);
            this.dataGridViewAllTeachersRecord.TabIndex = 45;
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTeachers.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTeachers.Location = new System.Drawing.Point(29, 194);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(191, 40);
            this.lblTeachers.TabIndex = 46;
            this.lblTeachers.Text = "Teachers";
            this.lblTeachers.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.BackColor = System.Drawing.Color.Gainsboro;
            this.lblStudents.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStudents.Location = new System.Drawing.Point(29, 414);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(184, 40);
            this.lblStudents.TabIndex = 47;
            this.lblStudents.Text = "Students";
            this.lblStudents.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 670);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblTeachers);
            this.Controls.Add(this.dataGridViewAllTeachersRecord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewShowAllStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkAbout4);
            this.Controls.Add(this.lblUstaadG);
            this.Controls.Add(this.picHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAllStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTeachersRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewShowAllStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkAbout4;
        private System.Windows.Forms.Label lblUstaadG;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdHome4;
        private System.Windows.Forms.DataGridView dataGridViewAllTeachersRecord;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}