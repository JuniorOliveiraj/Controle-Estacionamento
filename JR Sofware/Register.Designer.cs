namespace JR_Sofware
{
    partial class Register
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
            this.formLoginGo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerShowPasswd = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerPasswd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.formLoginGo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.registerShowPasswd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.registerPasswd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.registerUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 602);
            this.panel1.TabIndex = 1;
            // 
            // formLoginGo
            // 
            this.formLoginGo.AutoSize = true;
            this.formLoginGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formLoginGo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLoginGo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.formLoginGo.Location = new System.Drawing.Point(739, 505);
            this.formLoginGo.Name = "formLoginGo";
            this.formLoginGo.Size = new System.Drawing.Size(43, 19);
            this.formLoginGo.TabIndex = 29;
            this.formLoginGo.Text = "Login";
            this.formLoginGo.Click += new System.EventHandler(this.formLoginGo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Already have an account?";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButton.Location = new System.Drawing.Point(496, 438);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(466, 44);
            this.registerButton.TabIndex = 27;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerShowPasswd
            // 
            this.registerShowPasswd.AutoSize = true;
            this.registerShowPasswd.Location = new System.Drawing.Point(861, 382);
            this.registerShowPasswd.Name = "registerShowPasswd";
            this.registerShowPasswd.Size = new System.Drawing.Size(101, 17);
            this.registerShowPasswd.TabIndex = 26;
            this.registerShowPasswd.Text = "Show password";
            this.registerShowPasswd.UseVisualStyleBackColor = true;
            this.registerShowPasswd.CheckedChanged += new System.EventHandler(this.registerShowPasswd_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password*";
            // 
            // registerPasswd
            // 
            this.registerPasswd.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswd.Location = new System.Drawing.Point(496, 319);
            this.registerPasswd.Multiline = true;
            this.registerPasswd.Name = "registerPasswd";
            this.registerPasswd.PasswordChar = '*';
            this.registerPasswd.Size = new System.Drawing.Size(466, 44);
            this.registerPasswd.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Username*";
            // 
            // registerUsername
            // 
            this.registerUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsername.Location = new System.Drawing.Point(496, 232);
            this.registerUsername.Multiline = true;
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(466, 44);
            this.registerUsername.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Free forever. No credit card needed.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Get started to JR Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 602);
            this.panel2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "effectively with Portifolio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JR_Sofware.Properties.Resources.illustration_register;
            this.pictureBox1.Location = new System.Drawing.Point(12, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage the job more";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 602);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label formLoginGo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.CheckBox registerShowPasswd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registerPasswd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}