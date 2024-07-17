using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JR_Sofware
{
    public partial class Dashboard : UserControl
    {
        //MySqlConnection connect = new MySqlConnection(@"Server=100.64.64.223;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");
        MySqlConnection connect = new MySqlConnection(@"Server=local.juniorbelem.com;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");
        private List<dashBoardData> registers;
        private List<ChartsData> chartsDs;
        public Dashboard()
        {
            InitializeComponent();
            atualizarDados();
            atualizarChart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private List<ChartsData> atualizarChart()
        {

            string queryChart = "SELECT YEAR(register_estacionamento_saida) AS ano, SUM(IF(MONTH(register_estacionamento_saida) = 1, " +
                                "COALESCE(register_estacionamento_pago, 0), 0)) AS Jan,     " +
                                "SUM(IF(MONTH(register_estacionamento_saida) = 2, " +
                                "COALESCE(register_estacionamento_pago, 0), 0)) AS Fev,   " +
                                "SUM(IF(MONTH(register_estacionamento_saida) = 3, " +
                                "COALESCE(register_estacionamento_pago, 0), 0)) AS Mar,    " +
                                "SUM(IF(MONTH(register_estacionamento_saida) = 4," +
                                " COALESCE(register_estacionamento_pago, 0), 0)) AS Abr,   " +
                                " SUM(IF(MONTH(register_estacionamento_saida) = 5," +
                                " COALESCE(register_estacionamento_pago, 0), 0)) AS Mai,   " +
                                " SUM(IF(MONTH(register_estacionamento_saida) = 6," +
                                " COALESCE(register_estacionamento_pago, 0), 0)) AS Jun,   " +
                                " SUM(IF(MONTH(register_estacionamento_saida) = 7, " +
                                "COALESCE(register_estacionamento_pago, 0), 0)) AS Jul " +
                                "FROM    register_estacionamento WHERE     register_estacionamento_saida IS NOT NULL    " +
                                " AND register_estacionamento_saida >= DATE_SUB(CURDATE(), INTERVAL 7 MONTH) GROUP BY  ano ORDER BY ano DESC;";
            chartsDs = new List<ChartsData>();
            try
            {
                connect.Open();
                using (MySqlCommand cmd = new MySqlCommand(queryChart, connect))
                {
                    //cmd.Parameters.AddWithValue("@month", dateFilter.Value.Month);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ChartsData register = new ChartsData
                        {
                            Ano = reader.GetDouble("ano"),
                            Jan = reader.GetDouble("Jan"),
                            Fev = reader.GetDouble("Fev"),
                            Mar = reader.GetDouble("Mar"),
                            Abr = reader.GetDouble("Abr"),
                            Mai = reader.GetDouble("Mai"),
                            Jun = reader.GetDouble("Jun"),
                            Jul = reader.GetDouble("Jul"),

                        };

                        chartsDs.Add(register);
                    }
                }
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                ChartArea chartArea = new ChartArea();
                chart1.ChartAreas.Add(chartArea);

                Series series = new Series
                {
                    Name = "Gastos mensais",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Column
                };

                chart1.Series.Add(series);
                foreach (var data in chartsDs)
                {
                    series.Points.AddXY("Jan " + data.Ano, data.Jan);
                    series.Points.AddXY("Feb " + data.Ano, data.Fev);
                    series.Points.AddXY("Mar " + data.Ano, data.Mar);
                    series.Points.AddXY("Apr " + data.Ano, data.Abr);
                    series.Points.AddXY("May " + data.Ano, data.Mai);
                    series.Points.AddXY("Jun " + data.Ano, data.Jun);
                    series.Points.AddXY("Jul " + data.Ano, data.Jul);
                }

                chart1.Invalidate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            return chartsDs;

        }

        private List<dashBoardData> atualizarDados()
        {

            string query = "select SUM(register_estacionamento_pago) AS 'TotalMes', SUM(register_estacionamento_complet) AS 'TotalEntrada' FROM register_estacionamento WHERE MONTH(register_estacionamento_chegada) = MONTH(CURRENT_DATE())";

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
                            TotalEntrada = reader.GetDouble("TotalEntrada"),
                            TotalMes = reader.GetDouble("TotalMes"),

                        };

                        registers.Add(register);
                    }
                }
                label5.Text = $"${registers[0].TotalMes.ToString()}";
                label3.Text = registers[0].TotalEntrada.ToString();







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
        internal class ChartsData
        {
            public double Ano { get; set; }
            public double Jan { get; set; }
            public double Fev { get; set; }
            public double Mar { get; set; }
            public double Abr { get; set; }
            public double Mai { get; set; }
            public double Jun { get; set; }
            public double Jul { get; set; }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            atualizarDados();
            atualizarChart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
