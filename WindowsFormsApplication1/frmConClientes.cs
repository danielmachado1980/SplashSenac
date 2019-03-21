﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Entidades;

namespace WindowsFormsApplication1
{
    public partial class frmConClientes : Form
    {
        public frmConClientes()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Carregar os dados do banco
            carregarClientes();
            //var frVendas = new frmConVendas();
            //frVendas.MdiParent = this.ParentForm;
            //frVendas.Show();
        }

        private void carregarClientes()
        {
            List<Clientes> lstClientes = new List<Clientes>();
            var cliente = new Clientes();
            cliente.Nome = "Daniel Machado";
            cliente.CPF = "165.789.465-45";
            cliente.Codigo = 1;
            lstClientes.Add(cliente);
            cliente = new Clientes();
            cliente.Nome = "Daniel Machado 1";
            cliente.CPF = "165.111.465-45";
            cliente.Codigo = 2;
            lstClientes.Add(cliente);
            cliente = new Clientes();
            cliente.Nome = "Daniel Machado 2";
            cliente.CPF = "999.789.465-45";
            cliente.Codigo = 3;
            lstClientes.Add(cliente);
            grdClientes.DataSource = lstClientes;

            int rowindex = grdClientes.CurrentRow.Index;
            //MessageBox.Show(rowindex.ToString());
            txtCodigo.Text = grdClientes.Rows[rowindex].Cells[2].Value.ToString();
        }

        private void frmConClientes_Load(object sender, EventArgs e)
        {
            configurarGrid();
        }

        private void configurarGrid()
        {
            grdClientes.AutoGenerateColumns = false;
            grdClientes.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Nome";
            column1.HeaderText = "Nome";
            column1.DataPropertyName = "Nome";
            grdClientes.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "CPF";
            column2.HeaderText = "CPF";
            column2.DataPropertyName = "CPF";
            grdClientes.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Codigo";
            column3.HeaderText = "Código";
            column3.DataPropertyName = "Codigo";
            column3.Visible = false;
            grdClientes.Columns.Add(column3);

        }

        private void grdClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCodigo.Text = grdClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
