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
            List<Veículo> veículos = Veículo.todosOsVeículos();
            dataGridView_Veículos = new DataGridView();
            int CountVeículos = veículos.Count;
            
            InitializeComponent();
            for (int i = 0; i < CountVeículos; i++)
            {
                dataGridView_Veículos.Rows.Add();
                dataGridView_Veículos.Rows[i].Cells[0].Value = veículos[i].Modelo.Nome;
                dataGridView_Veículos.Rows[i].Cells[1].Value = veículos[i].Cor;
                dataGridView_Veículos.Rows[i].Cells[2].Value = veículos[i].Ano.ToString();
                dataGridView_Veículos.Rows[i].Cells[3].Value = veículos[i].Quilometragem.ToString();
             //   dataGridView_Veículos.Rows[i].Cells[4].Value = Program.veículos[i].status.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Veículo> veículos = Veículo.todosOsVeículos();
            int CountVeículos = veículos.Count;
            dataGridView_Veículos.Rows.Clear();
            for (int i = 0; i < CountVeículos; i++)
            {
                if (veículos[i].Modelo.Nome.Contains(textBox_Nome.Text) &&
                    veículos[i].Cor.Contains(textBox_Cor.Text) &&
                    veículos[i].Ano.ToString().Contains(textBox_Ano.Text) &&
                    veículos[i].Quilometragem.ToString().Contains(textBox_Quilometragem.Text)
                    )
                {
                    dataGridView_Veículos.Rows.Add();
                    dataGridView_Veículos.Rows[i].Cells[0].Value = veículos[i].Modelo.Nome;
                    dataGridView_Veículos.Rows[i].Cells[1].Value = veículos[i].Cor;
                    dataGridView_Veículos.Rows[i].Cells[2].Value = veículos[i].Ano.ToString();
                    dataGridView_Veículos.Rows[i].Cells[3].Value = veículos[i].Quilometragem.ToString();
                //    dataGridView_Veículos.Rows[i].Cells[4].Value = Program.veículos[i].status.ToString();
                }
            }
        }

        private void dataGridView_Veículos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Veículo> veículos = Veículo.todosOsVeículos();
            int RowIndex=dataGridView_Veículos.CurrentRow.Index;
            int CountVeículos = veículos.Count;
            for (int i = 0; i < CountVeículos; i++)
            {
                if (dataGridView_Veículos.Rows[RowIndex].Cells[0].Value.ToString() == veículos[i].Modelo.Nome &&
                    dataGridView_Veículos.Rows[RowIndex].Cells[1].Value.ToString() == veículos[i].Cor &&
                    dataGridView_Veículos.Rows[RowIndex].Cells[2].Value.ToString() == veículos[i].Ano.ToString() &&
                    dataGridView_Veículos.Rows[RowIndex].Cells[3].Value.ToString() == veículos[i].Quilometragem.ToString())
                    veículoPesquisado = veículos[i];

                   
                
            }
           // MessageBox.Show(veículoPesquisado.Cor);
            this.Close();
        }

        private void Pesquisa_Veículos_Load(object sender, EventArgs e)
        {

        }

    }
}
