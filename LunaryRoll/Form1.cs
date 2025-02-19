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
    public partial class buttonMostrarSenha : Form
    {
        bool VerSenhaTxt = false;
        private string usuarioCorreto = "admLunar";
        private string senhaCorreta = "senhaFoda123";

        public buttonMostrarSenha()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = inputUsuario.Text;
            string senha = inputSenha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                mensagemLogin.Text = "Login efetuado com sucesso";
                mensagemLogin.ForeColor = Color.GreenYellow;
                Menu form = new Menu();
                form.ShowDialog();
            } else
            {
                mensagemLogin.Text = "Usuário ou senha estão inválidas";
                mensagemLogin.ForeColor= Color.OrangeRed;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputUsuario.Text = "";
            inputSenha.Text = "";
            inputUsuario.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                inputSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                imagemOlho.Image = LunaryRoll.Properties.Resources.olho;
 
            }
            else
            {
                inputSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                imagemOlho.Image = LunaryRoll.Properties.Resources.fechar_o_olho;
            }
        }

        private void mensagemLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void inputSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
