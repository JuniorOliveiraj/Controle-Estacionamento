using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JR_Sofware
{
    public partial class AddNew : UserControl
    {
        MySqlConnection connect = new MySqlConnection(@"Server=local.juniorbelem.com;Port=3000;Database=bd-oliveira;Uid=root;Pwd=Oliveira1012/0;");

        public AddNew()
        {
            InitializeComponent();
            InitializeDateTimePicker();

        }
        private void InitializeDateTimePicker()
        {
            dateRegist.Format = DateTimePickerFormat.Custom;
            dateRegist.CustomFormat = "dd/MM/yyyy HH:mm";
            dateRegist.ShowUpDown = true; // Mostra o controle de hora para cima/baixo
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registerUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCarro_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMoto.Enabled = !checkBoxCarro.Checked;
            checkBoxMoto.Checked = false;

            valorPorHora.Text = checkBoxMoto.Checked ? "$5.00" : checkBoxCarro.Checked ? "$10.00" : "$00.00";
            

        }

        private void checkBoxMoto_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBoxCarro.Enabled = !checkBoxMoto.Checked;
            checkBoxCarro.Checked = false;
            valorPorHora.Text = checkBoxMoto.Checked ? "$5.00" : checkBoxCarro.Checked ? "$10.00" : "$00.00";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            

            if (PlacaVeiculo.Text == "" || dateRegist.Value == null)
            {
                if (PlacaVeiculo.Text == "")
                {
                    MessageBox.Show("Voce deve adicionar uma placa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dateRegist.Value == null)
                {
                    MessageBox.Show("Data do registro não pode estar vasia ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Selecione o veiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //  MessageBox.Show("Nenhum dado registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open(); 
                    string query = "INSERT INTO register_estacionamento (register_estacionamento_placa, register_estacionamento_chegada, register_estacionamento_complet, register_estacionamento_typeVeiculo )  VALUES (@placa, @time, 0,@typeV )";


                    
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@placa", PlacaVeiculo.Text);
                        cmd.Parameters.AddWithValue("@time", dateRegist.Value);
                        cmd.Parameters.AddWithValue("@@typeV", checkBoxMoto.Checked ? 1 : 0);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Registro realizado com sucesso! {dateRegist.Value} {PlacaVeiculo.Text.Trim()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private DateTimePicker timePicker;

        private void dateRegist_ValueChanged(object sender, EventArgs e)
        {
 

        }

    }
}
