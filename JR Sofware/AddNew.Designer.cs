namespace JR_Sofware
{
    partial class AddNew
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.valorPorHora = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.checkBoxMoto = new System.Windows.Forms.CheckBox();
            this.checkBoxCarro = new System.Windows.Forms.CheckBox();
            this.dateRegist = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PlacaVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 627);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::JR_Sofware.Properties.Resources.Background_Shadow;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.valorPorHora);
            this.panel2.Controls.Add(this.registerButton);
            this.panel2.Controls.Add(this.checkBoxMoto);
            this.panel2.Controls.Add(this.checkBoxCarro);
            this.panel2.Controls.Add(this.dateRegist);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PlacaVeiculo);
            this.panel2.Location = new System.Drawing.Point(193, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 405);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Departure date";
            // 
            // valorPorHora
            // 
            this.valorPorHora.AutoSize = true;
            this.valorPorHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorPorHora.Location = new System.Drawing.Point(538, 234);
            this.valorPorHora.Name = "valorPorHora";
            this.valorPorHora.Size = new System.Drawing.Size(52, 19);
            this.valorPorHora.TabIndex = 32;
            this.valorPorHora.Text = "$10.00";
            this.valorPorHora.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButton.Location = new System.Drawing.Point(539, 301);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(122, 38);
            this.registerButton.TabIndex = 31;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // checkBoxMoto
            // 
            this.checkBoxMoto.AutoSize = true;
            this.checkBoxMoto.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMoto.Location = new System.Drawing.Point(220, 232);
            this.checkBoxMoto.Name = "checkBoxMoto";
            this.checkBoxMoto.Size = new System.Drawing.Size(111, 24);
            this.checkBoxMoto.TabIndex = 30;
            this.checkBoxMoto.Text = "motorcycle";
            this.checkBoxMoto.UseVisualStyleBackColor = true;
            this.checkBoxMoto.CheckedChanged += new System.EventHandler(this.checkBoxMoto_CheckedChanged);
            // 
            // checkBoxCarro
            // 
            this.checkBoxCarro.AutoSize = true;
            this.checkBoxCarro.Checked = true;
            this.checkBoxCarro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarro.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarro.Location = new System.Drawing.Point(124, 232);
            this.checkBoxCarro.Name = "checkBoxCarro";
            this.checkBoxCarro.Size = new System.Drawing.Size(50, 24);
            this.checkBoxCarro.TabIndex = 29;
            this.checkBoxCarro.Text = "car";
            this.checkBoxCarro.UseVisualStyleBackColor = true;
            this.checkBoxCarro.CheckedChanged += new System.EventHandler(this.checkBoxCarro_CheckedChanged);
            // 
            // dateRegist
            // 
            this.dateRegist.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRegist.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRegist.Location = new System.Drawing.Point(124, 179);
            this.dateRegist.Name = "dateRegist";
            this.dateRegist.Size = new System.Drawing.Size(466, 28);
            this.dateRegist.TabIndex = 28;
            this.dateRegist.ValueChanged += new System.EventHandler(this.dateRegist_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "license plate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PlacaVeiculo
            // 
            this.PlacaVeiculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacaVeiculo.Location = new System.Drawing.Point(124, 85);
            this.PlacaVeiculo.Multiline = true;
            this.PlacaVeiculo.Name = "PlacaVeiculo";
            this.PlacaVeiculo.Size = new System.Drawing.Size(466, 44);
            this.PlacaVeiculo.TabIndex = 26;
            this.PlacaVeiculo.TextChanged += new System.EventHandler(this.registerUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Register entry";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Add vehicle input,";
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddNew";
            this.Size = new System.Drawing.Size(1219, 627);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlacaVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateRegist;
        private System.Windows.Forms.CheckBox checkBoxMoto;
        private System.Windows.Forms.CheckBox checkBoxCarro;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label valorPorHora;
        private System.Windows.Forms.Label label1;
    }
}
