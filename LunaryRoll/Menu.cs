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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadCli_Click(object sender, EventArgs e)
        {
            CadCliente form = new CadCliente();
            form.ShowDialog();
        }

        private void buttonPesquisarCli_Click(object sender, EventArgs e)
        {
            ConsultaCli form = new ConsultaCli();
            form.ShowDialog();
        }
    }
}
