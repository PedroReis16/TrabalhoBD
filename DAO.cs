using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBD
{
    public class DAO
    {
        SqlConnection banco;

        public DAO()
        {
            CriandoConexao();
        }
        private void CriandoConexao()
        {
            string ConnectionString = @"Data Source=DESKTOP-UC14HQT; Initial Catalog=receitas2;User ID=sa;Password=123456";
            banco = new SqlConnection(ConnectionString);
        }
    }
}
