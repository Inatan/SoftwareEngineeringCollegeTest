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
    public partial class Cadastro_Modelo : Form
    {
        public Cadastro_Modelo()
        {
            InitializeComponent();
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Cadastrar_Click(object sender, EventArgs e)
        {
            Modelo novo = new Modelo(textBox_Nome.Text, textBox_Fornecedor.Text);
            novo.gravar();
            this.Close();
        }

        private void apenasLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void apenasRotulos(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasRotulos(e);
        }

        private void textBox_Fornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);

        }

        private void Cadastro_Modelo_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void Cadastro_Modelo_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Modelo_Load(object sender, EventArgs e)
        {

        }

=======
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
    }
}
