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
    public partial class Cadastro_Cliente : Form
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Cadastrar_Click(object sender, EventArgs e)
        {
            using (var ctx = new DadosContainer())
            {
                var novoLogin = new Login(textBox_Usuario.Text, textBox_Senha.Text, Login.TipoDeUsuário.Cliente);
                var moraAqui = new Endereço(textBox_UF.Text, textBox_Cidade.Text, textBox_Bairro.Text, textBox_Rua.Text, Convert.ToInt32(textBox_Número.Text), Convert.ToInt32(textBox_CEP.Text));
                var novo = new Cliente(textBox_Nome.Text, textBox_CPF_CNPJ.Text, textBox_TelefoneFixo.Text, textBox_TelefoneMóvel.Text, moraAqui, novoLogin);
                ctx.AddToClienteSet(novo);
                ctx.SaveChanges();
            }
            this.Close();
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


        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_CPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_TelefoneFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_TelefoneMóvel_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_UF_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_Cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_CEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_Bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_Rua_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_Número_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void radioButtonCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCPF.Checked)
            {
                textBox_CPF_CNPJ.MaxLength = 11;
                textBox_CPF_CNPJ.Text = "";
            }
        }

        private void radioButtonCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCNPJ.Checked)
            {
                textBox_CPF_CNPJ.Text = "";
                textBox_CPF_CNPJ.MaxLength = 14;
            }
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }


    }
}
