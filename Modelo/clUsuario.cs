using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Modelo
{
    class clUsuario
    {

        // atributos
        public int idusuario;
        public string login;
        public string senha;

        conectaBD BD = new conectaBD();

        public DataTable EfetuarLogin()
        {
            try
            {
                BD._sql = "SELECT * FROM USUARIO " +
                         " WHERE LOGIN LIKE '" + login + "' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
