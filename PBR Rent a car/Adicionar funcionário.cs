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
    public partial class Adicionar_funcionário : Form
    {
        private bool comma = false;
        private Funcionário.TipoDeFuncionário função;
        private int size;

        public Adicionar_funcionário()
        {
            InitializeComponent();
        }
        private void apenasLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void apenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void apenasDinheiro(KeyPressEventArgs e)
        {
            if (!comma)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ','))
                {
                    e.Handled = true;
                    comma = true;
                }
            }
            else
                if (size + 2 > textBox_Salario.Text.Length)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;
                }
                else if (!char.IsControl(e.KeyChar))
                    e.Handled = true; 
        }

        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_CarteiraTrabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!textBox_Salario.Text.Contains(','))
            {
                comma = false;
            }
            else
            {
                comma = true;
                size = textBox_Salario.Text.IndexOf(',')+1;
            }
             apenasDinheiro(e);
        }

        private void textBox_Função_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void Adicionar_funcionário_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ao encerrar esse processo os dados serão cadastrados. Você tem certeza que quer editar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBox_Nome.Text == "" || textBox_CarteiraTrabalho.Text == "" || textBox_Salario.Text == "")
                    MessageBox.Show("Por favor digite todos os campos importantes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (textBox_CarteiraTrabalho.Text.Length != textBox_CarteiraTrabalho.MaxLength)
                    MessageBox.Show("Por favor digite o número da carteira de trabalho completo completo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string nome = textBox_Nome.Text;
                    string carteira = textBox_CarteiraTrabalho.Text;
                    float salário = float.Parse(textBox_Salario.Text);
                    string usuário = textBox_Usuario.Text;
                    string senha = textBox_Senha.Text;
                    Login.TipoDeUsuário tipo = função == Funcionário.TipoDeFuncionário.Funcionário ? Login.TipoDeUsuário.Funcionário : Login.TipoDeUsuário.Gerente;
                    Login novoFunc = new Login(usuário, senha, tipo);
                    //novoFunc.gravar();
                    Funcionário novo = new Funcionário(nome, carteira, salário, função, novoFunc);
                    novo.gravar();
                    this.Close();
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                função = Funcionário.TipoDeFuncionário.Funcionário;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                função = Funcionário.TipoDeFuncionário.Gerente;
            }
        }
    }
}
