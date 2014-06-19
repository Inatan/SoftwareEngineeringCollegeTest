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
    public partial class Pesquisa_Veículos : Form
    {
        public Veículo veículoPesquisado = new Veículo() ;
        public Pesquisa_Veículos()
        {
            dataGridView_Veículos = new DataGridView();
            int CountVeículos = Program.veículos.Count;
            
            InitializeComponent();
            for (int i = 0; i < CountVeículos; i++)
            {
                dataGridView_Veículos.Rows.Add();
                dataGridView_Veículos.Rows[i].Cells[0].Value = Program.veículos[i].Modelo.Nome;
                dataGridView_Veículos.Rows[i].Cells[1].Value = Program.veículos[i].Cor;
                dataGridView_Veículos.Rows[i].Cells[2].Value = Program.veículos[i].Ano.ToString();
                dataGridView_Veículos.Rows[i].Cells[3].Value = Program.veículos[i].Quilometragem.ToString();
             //   dataGridView_Veículos.Rows[i].Cells[4].Value = Program.veículos[i].status.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CountVeículos = Program.veículos.Count;
            dataGridView_Veículos.Rows.Clear();
            for (int i = 0; i < CountVeículos; i++)
            {
                if (Program.veículos[i].Modelo.Nome.Contains(textBox_Nome.Text) &&
                    Program.veículos[i].Cor.Contains(textBox_Cor.Text) &&
                    Program.veículos[i].Ano.ToString().Contains(textBox_Ano.Text) &&
                    Program.veículos[i].Quilometragem.ToString().Contains(textBox_Quilometragem.Text)
                    )
                {
                    dataGridView_Veículos.Rows.Add();
                    dataGridView_Veículos.Rows[i].Cells[0].Value = Program.veículos[i].Modelo.Nome;
                    dataGridView_Veículos.Rows[i].Cells[1].Value = Program.veículos[i].Cor;
                    dataGridView_Veículos.Rows[i].Cells[2].Value = Program.veículos[i].Ano.ToString();
                    dataGridView_Veículos.Rows[i].Cells[3].Value = Program.veículos[i].Quilometragem.ToString();
                //    dataGridView_Veículos.Rows[i].Cells[4].Value = Program.veículos[i].status.ToString();
                }
            }
        }

        private void dataGridView_Veículos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex=dataGridView_Veículos.CurrentRow.Index;
            int CountVeículos = Program.veículos.Count;
            for (int i = 0; i < CountVeículos; i++)
            {
                if (dataGridView_Veículos.Rows[RowIndex].Cells[0].Value.ToString() == Program.veículos[i].Modelo.Nome &&
                    dataGridView_Veículos.Rows[RowIndex].Cells[1].Value.ToString() == Program.veículos[i].Cor &&
                    dataGridView_Veículos.Rows[RowIndex].Cells[2].Value.ToString() == Program.veículos[i].Ano.ToString() &&
                    dataGridView_Veículos.Rows[RowIndex].Cells[3].Value.ToString() == Program.veículos[i].Quilometragem.ToString())
                    veículoPesquisado = Program.veículos[i];

                   
                
            }
           // MessageBox.Show(veículoPesquisado.Cor);
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


    }
}
