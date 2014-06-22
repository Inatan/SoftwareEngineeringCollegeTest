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
    public partial class Redefinição_de_senha : Form
    {
        public Redefinição_de_senha()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRedefinir_Click(object sender, EventArgs e)
        {
            string usuário = textBox_Nome.Text;
            string senha = textBox_SenhaVelha.Text;
            DialogResult dialogResult = MessageBox.Show("Ao encerrar esse processo a senha será redefinida. Você tem certeza que quer editar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Login atual = Login.loginVálido(usuário, senha);
                if (atual != null)
                {
                    if (textBoxSenhaNovaConvirmação.Text == textBoxSenhaNova.Text)
                    {
                        MessageBox.Show("Senha redefinida com sucesso", "Redefinição de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        using (var ctx = new DadosContainer())
                        {
                            int countLogin=ctx.LoginSet.ToList().Count;
                            for (int i=0;i<countLogin;i++)
                                if (ctx.LoginSet.ToList()[i].Usuário == textBox_Nome.Text)
                                {
                                    ctx.LoginSet.ToList()[i].Senha = textBoxSenhaNovaConvirmação.Text;
                                    ctx.SaveChanges();
                                }
                        }
                        this.Close();
                    }
                    else
                        MessageBox.Show("Senha não confirmada corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Usuário não existe ou a senha é inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
