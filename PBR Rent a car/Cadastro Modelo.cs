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
            DialogResult dialogResult = MessageBox.Show("Ao encerrar esse processo os dados serão cadastrados. Você tem certeza que quer editar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                if (textBox_Nome.Text == "" || textBox_Fornecedor.Text == "")
                    MessageBox.Show("Por favor digite todos os campos importantes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Modelo novo = new Modelo(textBox_Nome.Text, textBox_Fornecedor.Text);
                    novo.gravar();
                    this.Close();
                }
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
    }
}
