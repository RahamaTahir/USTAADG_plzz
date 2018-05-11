namespace Ustaad_G
{
    partial class frmTermsAndConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTermsAndConditions));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblPLP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(20, 182);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(753, 243);
            this.richTextBox1.TabIndex = 92;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-2, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 54);
            this.panel2.TabIndex = 91;
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
            this.linkLabel1.Location = new System.Drawing.Point(694, 427);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 23);
            this.linkLabel1.TabIndex = 93;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Close";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPLP
            // 
            this.lblPLP.AutoSize = true;
            this.lblPLP.BackColor = System.Drawing.Color.Gainsboro;
            this.lblPLP.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPLP.Location = new System.Drawing.Point(35, 134);
            this.lblPLP.Name = "lblPLP";
            this.lblPLP.Size = new System.Drawing.Size(438, 40);
            this.lblPLP.TabIndex = 96;
            this.lblPLP.Text = "Terms And Conditions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 55);
            this.label1.TabIndex = 97;
            this.label1.Text = "Ustaad G";
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
            this.picHome.TabIndex = 86;
            this.picHome.TabStop = false;
            // 
            // frmTermsAndConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 454);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblPLP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTermsAndConditions";
            this.Text = "frmTermsAndConditions";
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblPLP;
        private System.Windows.Forms.Label label1;
    }
}