﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBR_Rent_a_car
{
    public partial class CadastroLogin : Form
    {
        public CadastroLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRedefinirSenha_Click(object sender, EventArgs e)
        {
            Redefinição_de_senha Redefinição = new Redefinição_de_senha();
            Redefinição.ShowDialog();
        }

        private void CadastroLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuário = textBox_Nome.Text;
            string senha = textBox_Senha.Text;
            Login atual = Login.loginVálido(usuário, senha);
            if (atual != null)
            {
                if (atual.getPermissão() == Login.TipoDeUsuário.Cliente)
                {
                    new InterfaceCliente().ShowDialog();
                    this.Close();
                }
                else if (atual.getPermissão() == Login.TipoDeUsuário.Funcionário)
                {
                    new Interface().ShowDialog();
                    this.Close();
                }
                else
                {
                    //Tela para gerentes?
                }
            } 
            else
            {
                //Colocar alguma tela dizendo que login/senha são inválidos!!!
            }
        }

    }
}
