﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivos_do_Metal.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "\nNome De Usuario: " + nomeusuario.Text +
                "\nSenha: " + senha.Text +
                "\nEmail: " + email.Text,
                "\nOK: ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );


        }

       
    }
}
