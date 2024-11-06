using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_do_Metal.Model
{
    internal class tabeladeregistro
    {
        public int Codusuario {  get; set; }
        public string Nomeusuario { get; set; }
        public string Senha { get; set; }
        public string Emaildecontato { get; set; }

        public tabeladeregistro(string nomeusuario, string senha, string emaildecontato)
        {
            Nomeusuario = nomeusuario;
            Senha = senha;
            Emaildecontato = emaildecontato;

        }
        public tabeladeregistro(int Codusuario, string nomeusuario,
            string senha, string emaildecontato) : this(nomeusuario, senha, emaildecontato)
        {
            Codusuario = Codusuario;
        }
    }
}
