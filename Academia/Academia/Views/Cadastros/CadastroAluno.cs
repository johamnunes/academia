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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtApelido.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtCompl.Text = "";
            txtCEP.Text = "";
            cbEstado.SelectedIndex = -1;
            mtxtTelefone.Text = "";
            mtxtTelEmergencia.Text = "";
            cbSexo.SelectedIndex = -1;
            txtObs.Text = "";
            dtNasc.Value = DateTime.Now;
            dtNasc.Value = DateTime.Today;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
