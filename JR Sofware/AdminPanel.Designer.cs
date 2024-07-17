namespace JR_Sofware
{
    partial class AdminPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GetUser = new System.Windows.Forms.Label();
            this.DashboardButon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AdminAddNew = new System.Windows.Forms.Button();
            this.AdminAllRegisters = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new JR_Sofware.Dashboard();
            this.addNew1 = new JR_Sofware.AddNew();
            this.allRegisters1 = new JR_Sofware.AllRegisters();
            this.addOutput1 = new JR_Sofware.AddOutput();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dashboard1);
            this.panel1.Controls.Add(this.addNew1);
            this.panel1.Controls.Add(this.allRegisters1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addOutput1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 633);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DashboardButon);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.AdminAddNew);
            this.panel2.Controls.Add(this.AdminAllRegisters);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 633);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ola como junior";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GetUser);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(22, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 63);
            this.panel3.TabIndex = 4;
            // 
            // GetUser
            // 
            this.GetUser.AutoSize = true;
            this.GetUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetUser.Location = new System.Drawing.Point(68, 20);
            this.GetUser.Name = "GetUser";
            this.GetUser.Size = new System.Drawing.Size(133, 20);
            this.GetUser.TabIndex = 2;
            this.GetUser.Text = "Junior de oliveira";
            // 
            // DashboardButon
            // 
            this.DashboardButon.BackColor = System.Drawing.Color.White;
            this.DashboardButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardButon.FlatAppearance.BorderSize = 0;
            this.DashboardButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButon.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DashboardButon.Image = global::JR_Sofware.Properties.Resources.uim__chart_pie_1;
            this.DashboardButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButon.Location = new System.Drawing.Point(11, 240);
            this.DashboardButon.Name = "DashboardButon";
            this.DashboardButon.Size = new System.Drawing.Size(228, 68);
            this.DashboardButon.TabIndex = 33;
            this.DashboardButon.Text = "Dashboard";
            this.DashboardButon.UseVisualStyleBackColor = false;
            this.DashboardButon.Click += new System.EventHandler(this.DashboardButon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::JR_Sofware.Properties.Resources.gridicons__add_outline_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 68);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add output";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::JR_Sofware.Properties.Resources.download;
            this.pictureBox3.Location = new System.Drawing.Point(31, 497);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // AdminAddNew
            // 
            this.AdminAddNew.BackColor = System.Drawing.Color.White;
            this.AdminAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminAddNew.FlatAppearance.BorderSize = 0;
            this.AdminAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAddNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminAddNew.Image = global::JR_Sofware.Properties.Resources.gridicons__add_outline_1;
            this.AdminAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminAddNew.Location = new System.Drawing.Point(11, 344);
            this.AdminAddNew.Name = "AdminAddNew";
            this.AdminAddNew.Size = new System.Drawing.Size(228, 68);
            this.AdminAddNew.TabIndex = 29;
            this.AdminAddNew.Text = "Add entry";
            this.AdminAddNew.UseVisualStyleBackColor = false;
            this.AdminAddNew.Click += new System.EventHandler(this.AdminAddNew_Click);
            // 
            // AdminAllRegisters
            // 
            this.AdminAllRegisters.BackColor = System.Drawing.Color.White;
            this.AdminAllRegisters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminAllRegisters.FlatAppearance.BorderSize = 0;
            this.AdminAllRegisters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminAllRegisters.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAllRegisters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminAllRegisters.Image = global::JR_Sofware.Properties.Resources.healthicons__register_book_outline_1;
            this.AdminAllRegisters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminAllRegisters.Location = new System.Drawing.Point(11, 292);
            this.AdminAllRegisters.Name = "AdminAllRegisters";
            this.AdminAllRegisters.Size = new System.Drawing.Size(228, 68);
            this.AdminAllRegisters.TabIndex = 28;
            this.AdminAllRegisters.Text = "All resgiters ";
            this.AdminAllRegisters.UseVisualStyleBackColor = false;
            this.AdminAllRegisters.Click += new System.EventHandler(this.AdminAllRegisters_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JR_Sofware.Properties.Resources.Rectangle_8;
            this.pictureBox2.Location = new System.Drawing.Point(9, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JR_Sofware.Properties.Resources.Group;
            this.pictureBox1.Location = new System.Drawing.Point(31, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dashboard1.Location = new System.Drawing.Point(237, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1219, 633);
            this.dashboard1.TabIndex = 4;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // addNew1
            // 
            this.addNew1.Location = new System.Drawing.Point(226, 0);
            this.addNew1.Name = "addNew1";
            this.addNew1.Size = new System.Drawing.Size(1219, 627);
            this.addNew1.TabIndex = 2;
            // 
            // allRegisters1
            // 
            this.allRegisters1.Location = new System.Drawing.Point(226, 0);
            this.allRegisters1.Name = "allRegisters1";
            this.allRegisters1.Size = new System.Drawing.Size(1219, 627);
            this.allRegisters1.TabIndex = 1;
            // 
            // addOutput1
            // 
            this.addOutput1.BackColor = System.Drawing.Color.White;
            this.addOutput1.Location = new System.Drawing.Point(226, 0);
            this.addOutput1.Name = "addOutput1";
            this.addOutput1.Size = new System.Drawing.Size(1219, 627);
            this.addOutput1.TabIndex = 3;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 633);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label GetUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AdminAllRegisters;
        private System.Windows.Forms.Button AdminAddNew;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private AddNew addNew1;
        private AllRegisters allRegisters1;
        private System.Windows.Forms.Button button1;
        private AddOutput addOutput1;
        private Dashboard dashboard1;
        private System.Windows.Forms.Button DashboardButon;
    }
}