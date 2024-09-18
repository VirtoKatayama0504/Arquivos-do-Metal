using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos_do_Metal.Model
{
    internal class tabeladeregistro
    {
        public int Codusuario {  get; set; }
        public string Nomeusuario { get; set; }

        public string Senha { get; set; }

        public string Confirmarsenha { get; set; }
        public string Emaildecontato { get; set; }

        public tabeladeregistro(string nomeusuario, string senha, string confirmarsenha, string emaildecontato)
        {
            Nomeusuario = nomeusuario;
            Senha = senha;
            Confirmarsenha = confirmarsenha;
            Emaildecontato = emaildecontato;

        }
    }
}
