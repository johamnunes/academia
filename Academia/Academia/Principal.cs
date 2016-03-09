using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Views.Cadastros;

namespace Academia
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListaAlunos().Show();
        }

        private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListaAtividades().Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListaContas().Show();
        }

        private void históricosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListaHistoricos().Show();
        }

        private void personaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListasPersonalTrainers().Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListasUsuarios().Show();
        }
    }
}
