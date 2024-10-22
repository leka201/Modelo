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
    public partial class frmBuscaCliente : Form
    {
        public frmBuscaCliente()
        {
            InitializeComponent();
        }

        clCliente cliente = new clCliente();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    cliente.nome = txtPesquisa.Text;
                    dgvCliente.DataSource = cliente.PesquisaPorNome();
                }

                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[3].Visible = false;
                dgvCliente.Columns[4].Visible = false;
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[6].Visible = false;
                dgvCliente.Columns[7].Visible = false;
                dgvCliente.Columns[8].Visible = false;

                dgvCliente.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvCliente.SelectedRows;
                cliente.idcliente = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o cliente " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    cliente.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um cliente para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
            DataGridViewSelectedRowCollection linha = dgvCliente.SelectedRows;
            cliente.idcliente = int.Parse(linha[0].Cells[0].Value.ToString());
            cliente.nome = linha[0].Cells[1].Value.ToString();
            cliente.cpf = linha[0].Cells[2].Value.ToString();
            cliente.cep = linha[0].Cells[3].Value.ToString();
            cliente.endereco = linha[0].Cells[4].Value.ToString();
            cliente.complemento = linha[0].Cells[5].Value.ToString();
            cliente.bairro = linha[0].Cells[6].Value.ToString();
            cliente.uf = linha[0].Cells[7].Value.ToString();
            cliente.cidade = linha[0].Cells[8].Value.ToString();
            cliente.telefone = linha[0].Cells[9].Value.ToString();

            frmCadastraCliente formulario = new frmCadastraCliente();
            formulario.cliente = cliente;
            formulario.ShowDialog();
        }
    }
}
