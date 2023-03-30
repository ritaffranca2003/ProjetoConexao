﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoConexao
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela;

        private void btnProduto_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            tela = new TelaCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();
        }
    }
}
