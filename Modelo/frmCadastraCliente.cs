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
    public partial class frmCadastraCliente : Form
    {
        public frmCadastraCliente()
        {
            InitializeComponent();
        }

        public clCliente cliente;

        private void frmCadastraCliente_Load(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                txtID.Text = cliente.idcliente.ToString();
                txtNome.Text = cliente.nome;
                txtCPF.Text = cliente.cpf;
                txtCEP.Text = cliente.cep;
                txtComplemento.Text = cliente.complemento;
                txtBairro.Text = cliente.bairro;
                txtEndereco.Text = cliente.endereco;
                txtTelefone.Text = cliente.telefone;
                cmbCidade.Text = cliente.cidade;
                cmbUF.Text = cliente.uf;
                btnSalvar.Text = "Atualizar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clCliente cliente = new clCliente();
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCPF.Text;
            cliente.cep = txtCEP.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.complemento = txtComplemento.Text;
            cliente.bairro = txtBairro.Text;
            cliente.uf = cmbUF.Text;
            cliente.cidade = cmbCidade.Text;
            cliente.telefone = txtTelefone.Text;

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(cliente.Salvar());
            }
            else
            {
                cliente.idcliente = int.Parse(txtID.Text);
                cliente.Atualizar();
            }

        }
    }
}
