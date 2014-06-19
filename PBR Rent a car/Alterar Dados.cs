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
        public Alterar_Dados()
        {
            InitializeComponent();
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


    }
}
