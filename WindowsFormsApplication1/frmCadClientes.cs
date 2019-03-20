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
        private List<Contatos> lstContatos = new List<Contatos>();

        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.DataNascimento = txtDataNascimento.Value;
            cliente.lstContatos = this.lstContatos;

            //Mando para o BD - Salvar Dados
        }

        private void frmCadClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o cadastro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            
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
    }
}
