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
    public partial class Pesquisa_Veículos : Form
    {
        public Veículo veículoPesquisado = new Veículo() ;
        public Pesquisa_Veículos()
        {
            dataGridView_Veículos = new DataGridView();
            InitializeComponent();
            using (var ctx = new DadosContainer())
            {
                var veículos = ctx.VeículoSet.ToList();
                int CountVeículos = veículos.Count;
                for (int i = 0; i < CountVeículos; i++)
                {
                    dataGridView_Veículos.Rows.Add();
                    dataGridView_Veículos.Rows[i].Cells[0].Value = veículos[i].Modelo.Nome;
                    dataGridView_Veículos.Rows[i].Cells[1].Value = veículos[i].Cor;
                    dataGridView_Veículos.Rows[i].Cells[2].Value = veículos[i].Ano.ToString();
                    dataGridView_Veículos.Rows[i].Cells[3].Value = veículos[i].Quilometragem.ToString();
                    dataGridView_Veículos.Rows[i].Cells[4].Value = veículos[i].status;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_Veículos.Rows.Clear();
            using (var ctx = new DadosContainer())
            {
                var veículos = ctx.VeículoSet.ToList();
                int CountVeículos = veículos.Count;
                for (int i = 0; i < CountVeículos; i++)
                {
                    if (veículos[i].Modelo.Nome.Contains(textBox_Nome.Text) &&
                        veículos[i].Cor.Contains(textBox_Cor.Text) &&
                        veículos[i].Ano.ToString().Contains(textBox_Ano.Text) &&
                        (textBox_Ano.Text == "" ||
                        veículos[i].Quilometragem <= (int.Parse(textBox_Quilometragem.Text)))
                        )
                    {
                        dataGridView_Veículos.Rows.Add();
                        dataGridView_Veículos.Rows[i].Cells[0].Value = veículos[i].Modelo.Nome;
                        dataGridView_Veículos.Rows[i].Cells[1].Value = veículos[i].Cor;
                        dataGridView_Veículos.Rows[i].Cells[2].Value = veículos[i].Ano.ToString();
                        dataGridView_Veículos.Rows[i].Cells[3].Value = veículos[i].Quilometragem.ToString();
                        dataGridView_Veículos.Rows[i].Cells[4].Value = veículos[i].status;
                    }
                }
            }
        }

        private void dataGridView_Veículos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex=dataGridView_Veículos.CurrentRow.Index;
            using (var ctx = new DadosContainer())
            {
                var veículos = ctx.VeículoSet.ToList();
                int CountVeículos = veículos.Count;
                for (int i = 0; i < CountVeículos; i++)
                {
                    if (dataGridView_Veículos.Rows[RowIndex].Cells[0].Value.ToString() == veículos[i].Modelo.Nome &&
                        dataGridView_Veículos.Rows[RowIndex].Cells[1].Value.ToString() == veículos[i].Cor &&
                        dataGridView_Veículos.Rows[RowIndex].Cells[2].Value.ToString() == veículos[i].Ano.ToString() &&
                        dataGridView_Veículos.Rows[RowIndex].Cells[3].Value.ToString() == veículos[i].Quilometragem.ToString())
                        veículoPesquisado = veículos[i];
                }
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

        private void textBox_Quilometragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_Ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_Fornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_Cor_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void Pesquisa_Veículos_Load(object sender, EventArgs e)
        {

        }
    }
}
