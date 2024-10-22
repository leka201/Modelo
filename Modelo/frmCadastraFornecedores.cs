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
    public partial class frmCadastraFornecedores : Form
    {
        public frmCadastraFornecedores()
        {
            InitializeComponent();
        }

        public clFornecedor fornecedor;

        private void frmCadastraFornecedores_Load(object sender, EventArgs e)
        {
            if (fornecedor != null)
            {
                txtID.Text = fornecedor.idfornecedor.ToString();
                txtNome.Text = fornecedor.nome;
                txtCNPJ.Text = fornecedor.cnpj;
                txtCEP.Text = fornecedor.cep;
                txtComplemento.Text = fornecedor.complemento;
                txtBairro.Text = fornecedor.bairro;
                txtEndereco.Text = fornecedor.endereco;
                txtTelefone.Text = fornecedor.telefone;
                txtContato.Text = fornecedor.contato;
                cmbCidade.Text = fornecedor.cidade;
                cmbUF.Text = fornecedor.uf;
                btnSalvar.Text = "Atualizar";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clFornecedor fornecedor = new clFornecedor();
            fornecedor.nome = txtNome.Text;
            fornecedor.cnpj = txtCNPJ.Text;
            fornecedor.cep = txtCEP.Text;
            fornecedor.endereco = txtEndereco.Text;
            fornecedor.complemento = txtComplemento.Text;
            fornecedor.bairro = txtBairro.Text;
            fornecedor.uf = cmbUF.Text;
            fornecedor.cidade = cmbCidade.Text;
            fornecedor.telefone = txtTelefone.Text;

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(fornecedor.Salvar());
            }
            else
            {
                fornecedor.idfornecedor = int.Parse(txtID.Text);
                //fornecedor.Atualizar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
