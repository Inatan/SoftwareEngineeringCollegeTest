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
    public partial class Cadastro_Veículo : Form
    {
        
        public Cadastro_Veículo()
        {
            comboBox_Modelo = new ComboBox();
            List<Modelo> modelos = Modelo.todosOsModelos();
            int CountModelo = modelos.Count;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
           
=======

>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======

>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======
           
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
            InitializeComponent();
            for (int i = 0; i < CountModelo; i++)
            {
                List<string> modelo = new List<string>();
                modelo.Add(modelos[i].Fornecedor);
                modelo.Add(modelos[i].Nome);
                comboBox_Modelo.Items.Add(String.Join("/", modelo));
            }
           
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Cadastrar_Click(object sender, EventArgs e)
        {
            string[] modelo = new string[2];
            modelo = comboBox_Modelo.Text.Split('/');
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Veículo novo = new Veículo(textBox_Cor.Text,Convert.ToInt32(textBox_Ano.Text),textBox_Categoria.Text,0,new Modelo(modelo[1],modelo[0]));
=======
            Veículo novo = new Veículo(textBox_Cor.Text, Convert.ToInt32(textBox_Ano.Text), textBox_Categoria.Text, 0, new Modelo(modelo[1], modelo[0]));
>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======
            Veículo novo = new Veículo(textBox_Cor.Text, Convert.ToInt32(textBox_Ano.Text), textBox_Categoria.Text, 0, new Modelo(modelo[1], modelo[0]));
>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======
            Veículo novo = new Veículo(textBox_Cor.Text,Convert.ToInt32(textBox_Ano.Text),textBox_Categoria.Text,0,new Modelo(modelo[1],modelo[0]));
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
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
        private void apenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void textBox_Ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_Cor_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }
        private void Cadastro_Veículo_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void Cadastro_Veículo_Load(object sender, EventArgs e)
        {

        }

        private void Cadastro_Veículo_Load(object sender, EventArgs e)
        {

        }

=======
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
    }
}
