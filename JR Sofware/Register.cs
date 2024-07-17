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
    public partial class Register : Form
    {

        MySqlConnection connect = new MySqlConnection(@"Server=local.juniorbelem.com;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (registerUsername.Text == "" || registerPasswd.Text == "")
            {
                MessageBox.Show("Complete todos os campos de login", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    // Verifica se o usuário já existe
                    string checkUser = "SELECT COUNT(ID) FROM users_C WHERE users_C_name = @username";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkUser, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@username", registerUsername.Text);
                        int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Usuário já existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                    }

                    // Se o usuário não existir,
                    string query = "INSERT INTO users_C (users_C_name, users_C_passwd, users_C_register) VALUES (@username, @password, NOW())";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", registerUsername.Text);
                        cmd.Parameters.AddWithValue("@password", registerPasswd.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro realizado com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
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

        private void formLoginGo_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();   
            form.Show();
            this.Hide();
        }

        private void registerShowPasswd_CheckedChanged(object sender, EventArgs e)
        {
            registerPasswd.PasswordChar = registerShowPasswd.Checked ? '\0' : '*';
        }
    }
}
