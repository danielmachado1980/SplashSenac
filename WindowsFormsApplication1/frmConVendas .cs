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
    public partial class frmConVendas : Form
    {
        public frmConVendas()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Carregar os dados do banco
            carregarVendas();
        }

        private void carregarVendas()
        {
            //Define colunas
            lstviewVendas.Columns.Add("Nome do Cliente", 100);
            lstviewVendas.Columns.Add("Valor da Compra", 100);

            var item = new ListViewItem();
            item.Text = "Daniel Machado 1";
            item.SubItems.Add("1000");
            lstviewVendas.Items.Add(item);

            item = new ListViewItem();
            item.Text = "Daniel Machado 2";
            item.SubItems.Add("10000");
            lstviewVendas.Items.Add(item);

        }

        private void frmConClientes_Load(object sender, EventArgs e)
        {
            //configurarGrid();
        }

        private void configurarGrid()
        {
            //Define colunas
            lstviewVendas.Columns.Add("Nome do Cliente");
            lstviewVendas.Columns.Add("Valor da Compra");
        }
    }
}
