using System;
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
        }

        private void carregarClientes()
        {
            List<Clientes> lstClientes = new List<Clientes>();
            var cliente = new Clientes();
            cliente.Nome = "Daniel Machado";
            cliente.CPF = "165.789.465-45";
            lstClientes.Add(cliente);
            cliente = new Clientes();
            cliente.Nome = "Daniel Machado 1";
            cliente.CPF = "165.111.465-45";
            lstClientes.Add(cliente);
            cliente = new Clientes();
            cliente.Nome = "Daniel Machado 2";
            cliente.CPF = "999.789.465-45";
            lstClientes.Add(cliente);
            grdClientes.DataSource = lstClientes;

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
    }
}
