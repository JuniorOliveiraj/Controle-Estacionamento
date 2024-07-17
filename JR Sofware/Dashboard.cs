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
    public partial class Dashboard : UserControl
    {
        MySqlConnection connect = new MySqlConnection(@"Server=100.64.64.223;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");
        private List<dashBoardData> registers;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private List<dashBoardData> atualizarDados()
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
            
            try
            {
                registers = new List<dashBoardData>();
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    //cmd.Parameters.AddWithValue("@month", dateFilter.Value.Month);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dashBoardData register = new dashBoardData
                        {
                            TotalEntrada  = reader.GetDouble("TotalEntrada"),
                            TotalMes = reader.GetDouble("TotalMes"),

                        };

                        registers.Add(register);
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
            return registers;
        }

        internal class dashBoardData
        {
            public double TotalEntrada { get; set; }
            public double TotalMes { get; set; }

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
