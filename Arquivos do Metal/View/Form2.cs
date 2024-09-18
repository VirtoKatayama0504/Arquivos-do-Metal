using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivos_do_Metal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        

        

        private void login_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
              "\nNome de Usuário: " + user.Text +
              "\nSenha: " + pass.Text,
              "\nErr",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
              );
        }

        private void registro_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
                "\nNome de Usuário: " + nomeusuario.Text +
                "\nSenha: " + senha.Text +
                "\nConfirmação de Senha: " + confirmar.Text +
                "\nE-Mail para Contato: " + email.Text,
                "\nErr",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
