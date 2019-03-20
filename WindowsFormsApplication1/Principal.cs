using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCadClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja realmente encerrar o programa?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;    
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmConClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmConVendas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
