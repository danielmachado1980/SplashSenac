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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();
            cliente.Nome = txtNome.Text;
        }

        private void frmCadClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o cadastro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            lstContatos.DataSource = carregarClientes();
            grdClientes.AutoGenerateColumns = false;
            grdClientes.AllowUserToAddRows = false;
            grdClientes.DataSource = carregarClientes();

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "Nome";
            column1.HeaderText = "Nome";
            column1.DataPropertyName = "Nome";
            grdClientes.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Codigo";
            column2.HeaderText = "Código";
            column2.DataPropertyName = "Codigo";
            grdClientes.Columns.Add(column2);
        }

        private List<Clientes> carregarClientes()
        {
            List<Clientes> lstClientes = new List<Clientes>();
            var cliente = new Clientes();
            cliente.Nome = "Daniel Machado";
            lstClientes.Add(cliente);
            cliente = new Clientes();
            cliente.Nome = "Daniel Machado 1";
            lstClientes.Add(cliente);
            cliente = new Clientes();
            cliente.Nome = "Daniel Machado 2";
            lstClientes.Add(cliente);
            return lstClientes;
        }
    }
}
