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
    public partial class Alterar_Dados : Form
    {
        public Alterar_Dados(Cliente cliente)
        {
            textBox_Bairro= new TextBox();
            textBox_CEP = new TextBox();
            textBox_Cidade = new TextBox();
            textBox_CPF_CNPJ = new TextBox();
            textBox_Nome = new TextBox();
            textBox_UF = new TextBox();
            textBox_TelefoneFixo = new TextBox();
            textBox_TelefoneMóvel = new TextBox();
            textBox_Número = new TextBox();
            textBox_Rua = new TextBox();
            string[] telefone = new string[2];
            telefone = cliente.Telefone.Split('/');
            
            InitializeComponent();
            if (cliente != null)
            {
                textBox_Bairro.Text = cliente.Endereço.Bairro;
                textBox_CEP.Text = cliente.Endereço.CEP.ToString();
                textBox_Cidade.Text = cliente.Endereço.Cidade;
                textBox_CPF_CNPJ.Text = cliente.CPF;
                textBox_Nome.Text = cliente.Nome;
                textBox_UF.Text = cliente.Endereço.UF;
                textBox_TelefoneFixo.Text = telefone[0];
                textBox_TelefoneMóvel.Text = telefone[1];
                textBox_Número.Text = cliente.Endereço.Número.ToString();
                textBox_Rua.Text = cliente.Endereço.Rua;

            }
        }

        

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
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

        private void Button_Editar_Click(object sender, EventArgs e)
        {

        }


    }
}
