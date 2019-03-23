﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Entidades;

namespace WindowsFormsApplication1
{
    public partial class frmCadClientes : Form
    {
        private List<Contatos> lstContatos = new List<Contatos>();
        private Clientes clienteSelecionado;

        public frmCadClientes()
        {
            InitializeComponent();
        }

        public frmCadClientes(Clientes clienteSelecionado)
        {
            InitializeComponent();
            this.clienteSelecionado = clienteSelecionado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.DataNascimento = txtDataNascimento.Value;

            //Mando para o BD - Salvar Dados
            if (!ValidadorCPF.eValido(cliente.CPF))
            {
                MessageBox.Show("CPF inválido. ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                MessageBox.Show("CPF válido. ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmCadClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Deseja realmente fechar o cadastro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            //    e.Cancel = true;
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
            {
                txtNome.Text = clienteSelecionado.Nome;
                txtCPF.Text = clienteSelecionado.CPF;
                txtDataNascimento.Value = clienteSelecionado.DataNascimento;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstBoxContatos.DataSource = null;
            var contato = new Contatos();
            contato.telefones = txtContato.Text;
            lstContatos.Add(contato);
            lstBoxContatos.DataSource = lstContatos;
            txtContato.Text = "";
        }

        internal void atualizaCliente(Clientes clienteSelecionado)
        {
            txtNome.Text = clienteSelecionado.Nome;
            txtCPF.Text = clienteSelecionado.CPF;
            txtDataNascimento.Value = clienteSelecionado.DataNascimento;
        }
    }
}
