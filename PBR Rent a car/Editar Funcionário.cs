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
    public partial class Editar_Funcionário : Form
    {
        private bool comma = false;
        private int size;
        private int idCliente;
        
        public Editar_Funcionário(Funcionário funcionário)
        {
            textBox_Nome = new TextBox();
            textBox_CarteiraTrabalho = new TextBox();
            textBox_Salario = new TextBox();
            idCliente = funcionário.Id;
            InitializeComponent();
            if (funcionário != null)
            {
                textBox_Nome.Text = funcionário.Nome;
                textBox_CarteiraTrabalho.Text = funcionário.CarteiraDeTrabalho.ToString();
                textBox_Salario.Text = String.Format("{0,0:0.00}", funcionário.Salário);
                if (funcionário.Login.Permissão == 1)
                {
                    radioButtonFuncionário.Checked = true;
                }
                else
                    radioButtonGerente.Checked=true;
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
                if(size+2 > textBox_Salario.Text.Length)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        e.Handled = true;
                }
                    else  if (!char.IsControl(e.KeyChar))
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
            {
                comma = false;
            }
            else
            {
                comma = true;
                size = textBox_Salario.Text.IndexOf(',')+1;
            }
            apenasDinheiro(e);
        }

        private void textBox_Função_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ao encerrar esse processo os dados serão editados. Você tem certeza que quer editar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (textBox_Nome.Text == "" || textBox_CarteiraTrabalho.Text == ""|| textBox_Salario.Text == "")
                    MessageBox.Show("Por favor digite todos os campos importantes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (textBox_CarteiraTrabalho.Text.Length != textBox_CarteiraTrabalho.MaxLength)
                    MessageBox.Show("Por favor digite o número da carteira de trabalho completo completo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else using (var ctx = new DadosContainer())
                    {
                        for (int i = 0; i < ctx.FuncionárioSet.ToList().Count; i++)
                        {
                            if (ctx.FuncionárioSet.ToList()[i].Id == this.idCliente)
                            {
                                ctx.FuncionárioSet.ToList()[i].Nome = textBox_Nome.Text;
                                ctx.FuncionárioSet.ToList()[i].CarteiraDeTrabalho = textBox_CarteiraTrabalho.Text;
                                ctx.FuncionárioSet.ToList()[i].Salário = float.Parse(textBox_Salario.Text.Replace('.',','));
                                if (radioButtonGerente.Checked )
                                    ctx.FuncionárioSet.ToList()[i].Função= (byte) Funcionário.TipoDeFuncionário.Gerente;
                                else
                                    ctx.FuncionárioSet.ToList()[i].Função = (byte)Funcionário.TipoDeFuncionário.Funcionário;
                            }
                        }
                        ctx.SaveChanges();
                    }
                this.Close();
            }
        }


    }
}
