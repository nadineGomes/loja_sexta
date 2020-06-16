using System.Data;
using MySql.Data.MySqlClient;

namespace AppWeb.Repositorio
{
    public class Conexao : IConexao
    {
        public IDbConnection AbrirConexao()
        {
           using(MySqlConnection conn = new MySqlConnection("Server=ngomes.mysql.database.azure.com; Port=3306; Database={loja_facul}; Uid=nadine@ngomes; Pwd={qw27ki5f@}; SslMode=Preferred;"))
           {
               conn.Open();
               return conn;
           }
        }
    }
}