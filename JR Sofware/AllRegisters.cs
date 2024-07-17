using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JR_Sofware
{
    public partial class AllRegisters : UserControl
    {
        MySqlConnection connect = new MySqlConnection(@"Server=100.64.64.223;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");
        private List<RegistersAll> registers;
        public AllRegisters()
        {
            InitializeComponent();
            atualizarDados();
            dateFilter.Format = DateTimePickerFormat.Custom;
            dateFilter.CustomFormat = "yyyy-MM";
            dateFilter.ShowUpDown = true;




        }

        private void ConfigureDataGridView()
        {
            
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            //dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Placa", "Placa");
            dataGridView1.Columns.Add("Entrada", "Registration Date");
            dataGridView1.Columns.Add("saida", "saida");
            dataGridView1.Columns.Add("duracao", "duracao");
            dataGridView1.Columns.Add("preco", "preco");
            dataGridView1.Columns.Add("pago", "pago");
        }

        private List<RegistersAll> atualizarDados()
        {

            string query = "SELECT " +
                            "id," +
                            "register_estacionamento_placa AS 'Placa', " +
                            "register_estacionamento_chegada AS 'Entrada', " +
                            "register_estacionamento_saida AS 'saida', " +
                            "register_estacionamento_duracao AS 'duracao', " +
                            "register_estacionamento_preco AS 'preco', " +
                            "register_estacionamento_pago AS 'pago'  " +
                            "FROM  register_estacionamento  WHERE  register_estacionamento_complet = 1  AND MONTH(register_estacionamento_chegada) = @month";
            ConfigureDataGridView();
            try
            {
                registers = new List<RegistersAll>(); 
                connect.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@month", dateFilter.Value.Month);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RegistersAll register = new RegistersAll
                        {
                            Id = reader.GetInt32("Id"),
                            Placa = reader.GetString("Placa"),
                            Entrada = reader.GetDateTime("Entrada"),
                            saida = reader.GetDateTime("saida"),
                            duracao = reader.GetTimeSpan("duracao"),
                            preco = reader.GetDouble("preco"),
                            pago = reader.GetDouble("pago")
                        };

                        registers.Add(register);
                    }
                }
                

                foreach (var register in registers)
                {
                    dataGridView1.Rows.Add(register.Id, register.Placa, register.Entrada.ToString("yyyy-MM-dd hh\\:mm"), register.saida.ToString("yyyy-MM-dd hh\\:mm"), register.duracao.ToString("hh\\:mm"), register.preco.ToString(), register.pago.ToString());
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
            return registers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateFilter_ValueChanged(object sender, EventArgs e)
        {
            atualizarDados();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            atualizarDados();
        }
    }
}
