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
        private static SqlConnection banco;
        private static string ConnectionString = @"Data Source=DESKTOP-UC14HQT; Initial Catalog=receitas2;User ID=sa;Password=123456";
        public DAO()
        {
            CriandoConexao();
        }
        private void CriandoConexao()
        {

            banco = new SqlConnection(ConnectionString);
        }

        public static List<OrgaoLucrativos> OrgaosLucrativos()
        {
            string lucrativos = "select top(5) * from mais_lucrativos()";
            List<OrgaoLucrativos> valores = new List<OrgaoLucrativos>();

            using (SqlConnection banco = new SqlConnection(ConnectionString))
            {
                banco.Open();

                SqlCommand comando = new SqlCommand(lucrativos, banco);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrgaoLucrativos orgao = new OrgaoLucrativos()
                        {
                            codigo = reader.GetInt32(1),
                            nome = reader.GetString(2),
                            valor = reader.GetDecimal(0)
                        };
                        valores.Add(orgao);
                    }
                }

            }
            return valores;
        }
    }
    
}
