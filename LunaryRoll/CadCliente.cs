using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunaryRoll
{
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastroCli_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=db_lunaryroll; Uid=root; Pwd=;";


            string query = "INSERT INTO tb_pessoas (nome, telefone, rua, casa, complemento, cpf, data_nasc, email) VALUES (@nome, @telefone, @rua, @casa, @complemento, @cpf, @data_nasc, @email)";


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBoxNome.Text);
                        comando.Parameters.AddWithValue("@telefone", maskedTextBoxTel.Text);
                        comando.Parameters.AddWithValue("@@rua", textBoxRua.Text);
                        comando.Parameters.AddWithValue("@casa", textBoxCasa.Text);
                        comando.Parameters.AddWithValue("@complemento", textBoxComplemento.Text);
                        comando.Parameters.AddWithValue("@cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@data_nasc", maskedTextBoxData.Text);
                        comando.Parameters.AddWithValue("@email", textBoxEmail.Text);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Informações do Cliente inseridos com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            maskedTextBoxTel.Text = "";
            textBoxRua.Text = "";
            textBoxCasa.Text = "";
            textBoxComplemento.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxData.Text = "";
            textBoxEmail.Text = "";
        }
    }
}