using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraCliente formulario = new frmCadastraCliente();
            formulario.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraFornecedores formulario = new frmCadastraFornecedores();
            formulario.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscaCliente formulario = new frmBuscaCliente();
            formulario.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            frmLogin formulario = new frmLogin();
            formulario.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor formulario = new frmBuscaFornecedor();
            formulario.ShowDialog();
        }
    }
}
