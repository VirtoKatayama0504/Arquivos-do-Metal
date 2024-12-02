using Arquivos_do_Metal.Controller;
using Arquivos_do_Metal.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_do_Metal
{
    internal class tabeladeregistroDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        
        public tabeladeregistroDAO() 
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(tabeladeregistro prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            tabeladeregistro VALUES 
            (@nome, @senha, @email)";

            Command.Parameters.AddWithValue("@nome", prop.Nomeusuario);
            Command.Parameters.AddWithValue("@senha", prop.Senha);
            Command.Parameters.AddWithValue("@email", prop.Emaildecontato);


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }


        public void Update(tabeladeregistro prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE tabeladeregistro SET 
            nome = @nome,
            senha = @senha,
            email = @email,
            WHERE codusuario = @code";

            Command.Parameters.AddWithValue("@code", prop.Codusuario);
            Command.Parameters.AddWithValue("@nome", prop.Nomeusuario);
            Command.Parameters.AddWithValue("@senha", prop.Senha);
            Command.Parameters.AddWithValue("@email", prop.Emaildecontato);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização de " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int codusuario)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM tabeladeregistro
            WHERE codusuario = @code";
            Command.Parameters.AddWithValue("@code", codusuario);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "imóvel no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<tabeladeregistro> ListAllProperties()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM tabeladeregistro";

            List<tabeladeregistro> props = new List<tabeladeregistro>(); 
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

               
                while (rd.Read())
                {
                    tabeladeregistro prop = new tabeladeregistro(
                        (int)rd["codusuario"],
                        (string)rd["nome"],
                        (string)rd["senha"],
                        (string)rd["email"]
                        );
                    props.Add(prop);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de imóveis no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return props;
        }
    }
}
