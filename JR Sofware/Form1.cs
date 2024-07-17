using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace JR_Sofware
{
    public partial class Form1 : Form
    {
        MySqlConnection connect = new MySqlConnection(@"Server=100.64.64.223;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(loginUsername.Text == "" || loginPasswd.Text == "")
            {
                //MessageBox.Show("Complete todos os campos de login", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdminPanel adm = new AdminPanel();
                adm.Show();
                this.Hide();
                return;
            }
            else
            {
                try
                {
                    connect.Open();
                    string checkLogin = "SELECT COUNT(ID) FROM users_C WHERE users_C_name = @username AND users_C_passwd = @passwd";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkLogin, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@username", loginUsername.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@passwd", loginPasswd.Text.Trim());
                        int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                           // MessageBox.Show($"Login bem sucedido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminPanel adm = new AdminPanel();
                            adm.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show($"Dados de Login incorretos", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            loginPasswd.PasswordChar = loginShowPasswd.Checked ? '\0' : '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formSinginGo_Click(object sender, EventArgs e)
        {
           
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
