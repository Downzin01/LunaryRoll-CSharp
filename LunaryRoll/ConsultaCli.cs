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

namespace LunaryRoll
{
    public partial class ConsultaCli : Form
    {
        public ConsultaCli()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
			string connectionString = "Server=localhost; Port=3306; Database=db_lunaryroll; Uid=root; Pwd=;";

			try
			{
				using (MySqlConnection consulta = new MySqlConnection(connectionString))
				{
					consulta.Open();

					string listagem = "SELECT nome, telefone, rua, casa, complemento, cpf, data_nasc, email FROM tb_pessoas";

					using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
					{

						MySqlDataReader reader = cmd.ExecuteReader();

						DataTable dadosCli = new DataTable();
						dadosCli.Load(reader);

						dgvClientes.DataSource = dadosCli;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao listar os Clientes: " + ex.Message);
			}
		}

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
			if (dgvClientes.SelectedRows.Count > 0)
			{
				int CliID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id"].Value);

				DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse Cliente da lista? (esse processo é irreversível)", "Confimar Exclusão", MessageBoxButtons.YesNo);

				if (result == DialogResult.Yes)
				{
					string connectionString = "Server=localhost; Port=3306; Database=db_lunaryroll; Uid=root; Pwd=;";

					try
					{
						using (MySqlConnection consulta = new MySqlConnection(connectionString))
						{
							consulta.Open();

							string listagem = "DELETE FROM tb_pessoas WHERE id = @id";

							using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
							{
								cmd.Parameters.AddWithValue("id", CliID);

								int rowsAffected = cmd.ExecuteNonQuery();

								if (rowsAffected > 0)
								{
									MessageBox.Show("Cliente excluido com sucesso!");
								}
								else
								{
									MessageBox.Show("Erro ao excluir cliente");
								}
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Erro: " + ex.Message);
					}
				}
				else
				{
					MessageBox.Show("Por Favor, selecione um cliente para excluir-lo");
				}
			}
		}
    }
}

