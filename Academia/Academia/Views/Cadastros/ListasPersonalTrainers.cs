﻿using System;
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
    public partial class ListasPersonalTrainers : Form
    {
        public ListasPersonalTrainers()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new CadastroPersonalTrainer().Show();
        }
    }
}
