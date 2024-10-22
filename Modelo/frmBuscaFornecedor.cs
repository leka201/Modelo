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
    public partial class frmBuscaFornecedor : Form
    {
        public frmBuscaFornecedor()
        {
            InitializeComponent();
        }

        clFornecedor fornecedor = new clFornecedor();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    fornecedor.nome = txtPesquisa.Text;
                    dgvFornecedor.DataSource = fornecedor.PesquisaPorNome();
                }

                dgvFornecedor.Columns[0].Visible = false;
                dgvFornecedor.Columns[3].Visible = false;
                dgvFornecedor.Columns[4].Visible = false;
                dgvFornecedor.Columns[5].Visible = false;
                dgvFornecedor.Columns[6].Visible = false;
                dgvFornecedor.Columns[7].Visible = false;
                dgvFornecedor.Columns[8].Visible = false;

                dgvFornecedor.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;
                fornecedor.idfornecedor = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o fornecedor " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    fornecedor.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um fornecedor para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;
            fornecedor.idfornecedor = int.Parse(linha[0].Cells[0].Value.ToString());
            fornecedor.nome = linha[0].Cells[1].Value.ToString();
            fornecedor.cnpj = linha[0].Cells[2].Value.ToString();
            fornecedor.cep = linha[0].Cells[3].Value.ToString();
            fornecedor.endereco = linha[0].Cells[4].Value.ToString();
            fornecedor.complemento = linha[0].Cells[5].Value.ToString();
            fornecedor.bairro = linha[0].Cells[6].Value.ToString();
            fornecedor.uf = linha[0].Cells[7].Value.ToString();
            fornecedor.cidade = linha[0].Cells[8].Value.ToString();
            fornecedor.telefone = linha[0].Cells[9].Value.ToString();

            frmCadastraFornecedores formulario = new frmCadastraFornecedores();
            formulario.fornecedor = fornecedor;
            formulario.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
