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
    public partial class Pesquisar_Funcionário : Form
    {
        private bool comma = false;
        Adicionar_funcionário aFuncionário;
        
        public Pesquisar_Funcionário()
        {
            dataGridView_Funcionários = new DataGridView();
            InitializeComponent();
            using (var ctx = new DadosContainer())
            {
                var funcionários = ctx.FuncionárioSet.ToList();
                int CountFuncionário = funcionários.Count;
                for (int i = 0; i < CountFuncionário; i++)
                {
                    dataGridView_Funcionários.Rows.Add();
                    dataGridView_Funcionários.Rows[i].Cells[0].Value = funcionários[i].Nome;
                    dataGridView_Funcionários.Rows[i].Cells[1].Value = funcionários[i].CarteiraDeTrabalho;

                    dataGridView_Funcionários.Rows[i].Cells[3].Value = String.Format("{0,0:0.00}", funcionários[i].Salário);
                    if (funcionários[i].Função == 1)
                    {
                        dataGridView_Funcionários.Rows[i].Cells[2].Value = "Gerente";
                    }
                    else
                        dataGridView_Funcionários.Rows[i].Cells[2].Value = "Funcinário";
                }
            }
        }


        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            aFuncionário = new Adicionar_funcionário();
            aFuncionário.ShowDialog();
            buttonAtualizar_Click(sender, e);
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
        private void apenasDinheiro(KeyPressEventArgs e)
        {
            if (!comma)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ','))
                {
                    e.Handled = true;
                    comma = true;
                }
            }
            else
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
        }



        private void textBox_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBox_CarteiraTrabalho_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void textBox_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!textBox_Salario.Text.Contains(','))
                comma = false;
            apenasDinheiro(e);
        }

        private void textBox_Função_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            dataGridView_Funcionários.Rows.Clear();
            using (var ctx = new DadosContainer())
            {
                var funcionários = ctx.FuncionárioSet.ToList();
                int CountFuncionários = funcionários.Count;
                int salário = 0;
                int j = 0;
                for (int i = 0; i < CountFuncionários; i++)
                {
                   if(textBox_Salario.Text!="")
                       salário=Convert.ToInt32(textBox_Salario.Text);

                    if (funcionários[i].Nome.Contains(textBox_Nome.Text) &&
                        funcionários[i].CarteiraDeTrabalho.Contains(textBox_CarteiraTrabalho.Text) &&
                        (funcionários[i].Salário > salário) &&
                        ((checkBoxFuncionário.Checked) && (funcionários[i].Função == 0))
                        )
                    {
                        dataGridView_Funcionários.Rows.Add();
                        dataGridView_Funcionários.Rows[j].Cells[0].Value = funcionários[i].Nome;
                        dataGridView_Funcionários.Rows[j].Cells[1].Value = funcionários[i].CarteiraDeTrabalho;
                        dataGridView_Funcionários.Rows[j].Cells[2].Value = "Funcionário";
                        dataGridView_Funcionários.Rows[j].Cells[3].Value = String.Format("{0,0:0.00}", funcionários[i].Salário); 
                        j++;

                    }
                    
                    else if (funcionários[i].Nome.Contains(textBox_Nome.Text) &&
                        funcionários[i].CarteiraDeTrabalho.Contains(textBox_CarteiraTrabalho.Text) &&
                        (funcionários[i].Salário > salário)&&
                        ((checkBoxGerente.Checked) && (funcionários[i].Função == 1))
                        )
                    {
                        dataGridView_Funcionários.Rows.Add();
                        dataGridView_Funcionários.Rows[j].Cells[0].Value = funcionários[i].Nome;
                        dataGridView_Funcionários.Rows[j].Cells[1].Value = funcionários[i].CarteiraDeTrabalho;
                        dataGridView_Funcionários.Rows[j].Cells[2].Value = "Gerente";
                        dataGridView_Funcionários.Rows[j].Cells[3].Value = String.Format("{0,0:0.00}", funcionários[i].Salário); 
                        j++;
                    }
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView_Funcionários.CurrentRow.Index;

            using (var ctx = new DadosContainer())
            {
                var funcionários = ctx.FuncionárioSet.ToList();
                int CountFuncionários = funcionários.Count;


                for (int i = 0; i < CountFuncionários; i++)
                    if (dataGridView_Funcionários.Rows[RowIndex].Cells[0].Value.ToString().Contains(funcionários[i].Nome) && dataGridView_Funcionários.Rows[RowIndex].Cells[1].Value.ToString().Contains(funcionários[i].CarteiraDeTrabalho.ToString()) && dataGridView_Funcionários.Rows[RowIndex].Cells[3].Value.ToString().Contains(funcionários[i].Salário.ToString()))
                    {
                        Editar_Funcionário eFuncionário = new Editar_Funcionário(funcionários[i]);
                        eFuncionário.ShowDialog();
                        buttonAtualizar_Click(sender, e);
                    }

            }
        }


    }
}
