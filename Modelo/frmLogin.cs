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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        clUsuario usuario = new clUsuario();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            usuario.login = txtLogin.Text;
            DataTable dt = usuario.EfetuarLogin();

            if (dt.Rows.Count > 0)
            {
                string senha = dt.Rows[0]["senha"].ToString();
                if (txtSenha.Text == senha)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro, senha inválida", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Erro, login inválido", "Dados inválidos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; 
                e.SuppressKeyPress = true; // REMOVE O SOM DA TECLA ENTER
                btnLogin_Click(null,null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aplication.Exit();
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
