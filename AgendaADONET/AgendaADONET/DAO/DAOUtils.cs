using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace AgendaADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            DbConnection conexao = new SqlConnection(@"Server = .\SQLEXPRESS; Database = EstudoCSharp; User Id = sa; Password = 1234;");
            conexao.Open();
            return conexao;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
