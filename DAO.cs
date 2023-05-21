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
        public static List<OrgaosLucros> OrgaosLucrativos()
        {
            string select = "select top(5) o.nome,l.soma_valor_realizado " +
                "from orgaos_mais_lucrativos() l " +
                "Inner join orgao o on o.codigo = l.codigo_orgao " +
                "order by l.soma_valor_realizado desc ";
            List<OrgaosLucros> lucros = new List<OrgaosLucros>();

            using (SqlConnection banco = new SqlConnection(ConnectionString))
            {
                banco.Open();

                SqlCommand comando = new SqlCommand(select, banco);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrgaosLucros lucro = new OrgaosLucros()
                        {
                            Nome = reader.GetString(0),
                            Valor = reader.GetDecimal(1)
                        };
                        lucros.Add(lucro);
                    }
                }
            }
            return lucros;
        }
        public static List<MaioresReceitas> MaioresReceitas()
        {
            string lucrativos = "select top(5) * from mais_lucrativos()";
            List<MaioresReceitas> valores = new List<MaioresReceitas>();

            using (SqlConnection banco = new SqlConnection(ConnectionString))
            {
                banco.Open();

                SqlCommand comando = new SqlCommand(lucrativos, banco);

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MaioresReceitas orgao = new MaioresReceitas()
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
        public static List<MaioresPrejuizos> MaioresPrejuizos()
        {

        }
    }
    
}
