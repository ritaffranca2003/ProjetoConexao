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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_cliente where cli_id=" + txtId.Text;
            if (con.Executa(sql))
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("NÃO excluído!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                string sql = "insert into tb_cliente values (null, '" +
                    txtNome.Text + "', '" + txtCpf.Text + "', '" +
                    txtCelular.Text + "');";
                if (con.Executa(sql))
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("NÂO cadastrado!");
                }
            }
            else
            {
                string sql = "update tb_cliente set cli_cpf='" + txtCpf.Text +
                    "', cli_nome='" + txtNome.Text + "', cli_celular='" +
                    txtCelular.Text + "' where cli_id=" + txtId.Text;
                if (con.Executa(sql))
                {
                    MessageBox.Show("Atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("NÂO atualizado!");
                }
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dados = con.Retorna("select * from tb_cliente where cli_id=" + txtId.Text);
                txtCpf.Text = dados.Rows[0]["cli_cpf"].ToString();
                txtNome.Text = dados.Rows[0]["cli_nome"].ToString();
                txtCelular.Text = dados.Rows[0]["cli_celular"].ToString();
            }
        }
    }
}
