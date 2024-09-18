using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_do_Metal.Controller
{
    internal class Connection
    {
        private SqlConnection conexao1;
        private string DataBase = "PR2CJ3021971BDMetalArquives";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection()
        {
            string stringconnection = @"Data Source" + Server
            + "; Initial Catalog = " + DataBase
            + "; User Id = " + Username
            + ";Password = " + Password
            + ";Encrypt = false";

            conexao1 = new SqlConnection(stringconnection);
            conexao1.Open();

        }

        public void CloseConnection()
        {
            if (conexao1.State == System.Data.ConnectionState.Open) {
                conexao1.Close();
            } 
        
        }
        
        public SqlConnection ReturnConnection()
        {
            return conexao1;
        }

    }
}
