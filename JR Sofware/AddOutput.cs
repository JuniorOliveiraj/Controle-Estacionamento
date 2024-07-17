using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JR_Sofware.AddOutput;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JR_Sofware
{
    public partial class AddOutput : UserControl
    {
        MySqlConnection connect = new MySqlConnection(@"Server=local.juniorbelem.com;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");
        string totalGasto = "";
        int Idselect = 0;
        string duracao = "";
        private List<RegisterOutputs> registers;

        public AddOutput()
        {
            InitializeComponent();
            InitializeDateTimePicker();
            registers = FetchRegistersFromDatabase();  
        }

        private List<RegisterOutputs> FetchRegistersFromDatabase()
        {
            List<RegisterOutputs> registers = new List<RegisterOutputs>();

            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                comboBox1.Items.Clear();
                connect.Open();
                string query = "SELECT id, register_estacionamento_placa AS 'Placa', register_estacionamento_chegada AS 'Entrada', register_estacionamento_typeVeiculo AS 'typeV' FROM register_estacionamento WHERE register_estacionamento_complet = 0";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RegisterOutputs register = new RegisterOutputs
                    {
                        Id = reader.GetInt32("id"),
                        Placa = reader.GetString("Placa"),
                        Entrada = reader.GetDateTime("Entrada"),
                        TipeV = reader.GetInt32("typeV")
                    };
                    registers.Add(register);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            
            // Definir colunas do DataGridView
           // dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Placa", "Placa");
            dataGridView1.Columns.Add("Entrada", "Entrada");
            dataGridView1.Columns.Add("tipo", "typeV");

            foreach (var register in registers)
            {
                dataGridView1.Rows.Add(register.Placa, register.Entrada.ToString("yyyy-MM-dd HH:mm"), register.TipeV);
                comboBox1.Items.Add(register.Placa);  
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            return registers;
        }

        private void InitializeDateTimePicker()
        {
            dateOutput.Format = DateTimePickerFormat.Custom;
            dateOutput.CustomFormat = "dd/MM/yyyy HH:mm";
            dateOutput.ShowUpDown = true; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal class RegisterOutputs
        {
            public int Id { get; set; }
            public string Placa { get; set; }
            public DateTime Entrada { get; set; }
            public int TipeV { get; set; }

        }

        private void dateRegist_ValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                string selectedPlaca = comboBox1.SelectedItem.ToString();
                var selectedRegister = registers.Find(r => r.Placa == selectedPlaca);

                TimeSpan diferenca = selectedRegister.Entrada - dateOutput.Value;
                double horas = Math.Abs(diferenca.TotalHours);
                double total = horas * (selectedRegister.TipeV == 1 ? 5 : 10);
                string totalFormatado = total.ToString("F2");
                string duracaoFormatada = diferenca.ToString(@"hh\:mm");
                totalGasto = totalFormatado;
                Idselect = selectedRegister.Id;
                ValorAPagar.Text = totalFormatado;
                duracao = duracaoFormatada;

            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlaca = comboBox1.SelectedItem.ToString();
            var selectedRegister = registers.Find(r => r.Placa == selectedPlaca);

                TimeSpan diferenca = selectedRegister.Entrada - dateOutput.Value;
                double horas = Math.Abs(diferenca.TotalHours);
                double total = horas * (selectedRegister.TipeV == 1 ? 5 : 10);
                string totalFormatado = total.ToString("F2");
                string duracaoFormatada = diferenca.ToString(@"hh\:mm");
                ValorAPagar.Text = totalFormatado;
                totalGasto = totalFormatado;
                Idselect = selectedRegister.Id;
                duracao = duracaoFormatada;

        }

        private void AddOutput_Load(object sender, EventArgs e)
        {

        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            registers = FetchRegistersFromDatabase();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || dateOutput.Value == null || numericUpDown1.Value == 0 )
            {
                  if(comboBox1.Text == ""){

                  MessageBox.Show("Selecione uma placa ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dateOutput.Value == null)
                {

                    MessageBox.Show("Selecione uma data de saida  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (numericUpDown1.Value == 0)
                {

                    MessageBox.Show("Selecione o valor pago ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {
                    connect.Open();
                    string query = "UPDATE register_estacionamento " +
                                   "SET register_estacionamento_saida = @DataOutput, " +
                                   "register_estacionamento_duracao = @duracao, " +
                                   "register_estacionamento_preco = @preco, " +
                                   "register_estacionamento_pago = @pago, " +
                                   "register_estacionamento_complet = 1 " +
                                   "WHERE id = @id";




                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@DataOutput", dateOutput.Value);
                        cmd.Parameters.AddWithValue("@duracao", duracao);
                        cmd.Parameters.AddWithValue("@preco", totalGasto);
                        cmd.Parameters.AddWithValue("@pago", numericUpDown1.Value);
                        cmd.Parameters.AddWithValue("@id", Idselect);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Registro realizado com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
