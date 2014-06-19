using System;
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
                 if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
                comma = false;
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
            string nome = textBox_Nome.Text;
            string carteira = textBox_CarteiraTrabalho.Text;
            float salário = float.Parse(textBox_Salario.Text);
            string usuário = textBox_Usuario.Text;
            string senha = textBox_Senha.Text;
            Login novoFunc = new Login(usuário, senha, Login.TipoDeUsuário.Funcionário);
            novoFunc.gravar();
            Funcionário novo = new Funcionário(nome, carteira, salário, novoFunc);
            novo.gravar();
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
