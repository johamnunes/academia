using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Views.Cadastros
{
    public partial class CadastroHistorico : Form
    {
        public CadastroHistorico()
        {
            InitializeComponent();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtHistorico.Text = "";
            cbConta.SelectedIndex = -1;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
