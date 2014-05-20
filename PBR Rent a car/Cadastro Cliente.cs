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
            Program.clientes.Add(new Cliente(textBox_Nome.Text,textBox_CPF_CNPJ.Text,textBox_TelefoneFixo.Text,textBox_TelefoneMóvel.Text, new Endereço(textBox_UF.Text,textBox_Cidade.Text,textBox_Bairro.Text,textBox_Rua.Text,Convert.ToInt32(textBox_Número.Text),Convert.ToInt32(textBox_CEP.Text))));
            this.Close();
        }
    }
}
