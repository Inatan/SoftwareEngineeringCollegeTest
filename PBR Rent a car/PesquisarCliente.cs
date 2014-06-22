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
    public partial class PesquisarCliente : Form
    {
        public Cliente clientePesquisado;

        public PesquisarCliente()
        {
            dataGridView_Clientes = new DataGridView();
            InitializeComponent();
            using (var ctx = new DadosContainer())
            {
                var clientes = ctx.ClienteSet.ToList();
                int CountClientes = clientes.Count;
                for (int i = 0; i < CountClientes; i++)
                {
                    dataGridView_Clientes.Rows.Add();
                    dataGridView_Clientes.Rows[i].Cells[0].Value = clientes[i].Nome;
                    dataGridView_Clientes.Rows[i].Cells[1].Value = clientes[i].CPF;
                    dataGridView_Clientes.Rows[i].Cells[2].Value = clientes[i].Endereço.CEP;
                    dataGridView_Clientes.Rows[i].Cells[3].Value = clientes[i].Endereço.ToString();
                    dataGridView_Clientes.Rows[i].Cells[4].Value = clientes[i].Telefone;
                    dataGridView_Clientes.Rows[i].Cells[5].Value = clientes[i].Id;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_Clientes.Rows.Clear();
            using (var ctx = new DadosContainer())
            {
                var clientes = ctx.ClienteSet.ToList();
                int CountClientes = clientes.Count;
                for (int i = 0; i < CountClientes; i++)
                {
                    if( clientes[i].Nome.Contains(textBox_Nome.Text) &&
                        clientes[i].CPF.Contains(textBox_CPF_CNPJ.Text) &&
                        clientes[i].Endereço.CEP.ToString().Contains(textBox_CEP.Text) &&
                        clientes[i].Endereço.Bairro.Contains(textBox_Bairro.Text) &&
                        clientes[i].Endereço.Rua.Contains(textBox_Rua.Text) &&
                        clientes[i].Endereço.Número.ToString().Contains(textBox_Número.Text) &&
                        clientes[i].Endereço.Cidade.Contains(textBox_Cidade.Text) &&
                        clientes[i].Endereço.UF.Contains(textBox_UF.Text)
                        )
                    {
                        dataGridView_Clientes.Rows.Add();
                        dataGridView_Clientes.Rows[i].Cells[0].Value = clientes[i].Nome;
                        dataGridView_Clientes.Rows[i].Cells[1].Value = clientes[i].CPF;
                        dataGridView_Clientes.Rows[i].Cells[2].Value = clientes[i].Endereço.CEP;
                        dataGridView_Clientes.Rows[i].Cells[3].Value = clientes[i].Endereço.ToString();
                        dataGridView_Clientes.Rows[i].Cells[4].Value = clientes[i].Telefone;
                        dataGridView_Clientes.Rows[i].Cells[5].Value = clientes[i].Id;
                    }
                }
            }
        }

        private void PesquisarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
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

        private void buttonAlterarDados_Click(object sender, EventArgs e)
        {
            
            int RowIndex=dataGridView_Clientes.CurrentRow.Index;
            
            using (var ctx = new DadosContainer())
            {
                var clientes = ctx.ClienteSet.ToList();


                for (int i=0; i < clientes.Count; i++)
                    if (dataGridView_Clientes.Rows[RowIndex].Cells[0].Value.ToString().Contains(clientes[i].Nome) && dataGridView_Clientes.Rows[RowIndex].Cells[1].Value.ToString().Contains(clientes[i].CPF.ToString()) && dataGridView_Clientes.Rows[RowIndex].Cells[2].Value.ToString().Contains(clientes[i].Endereço.CEP.ToString()))
                    {
                        Alterar_Dados aDados = new Alterar_Dados(clientes[i]);
                        aDados.ShowDialog();
                        button1_Click(sender, e);
                    }
                
            }
        }

        private void dataGridView_Clientes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = dataGridView_Clientes.CurrentRow.Index;
            int id = int.Parse(dataGridView_Clientes.Rows[RowIndex].Cells[5].Value.ToString());
            using (var ctx = new DadosContainer())
            {
                var selecionado = ctx.ClienteSet.Where(c => c.Id == id).First();
                clientePesquisado = selecionado;
            }
            this.Close();
        }
    }
}
