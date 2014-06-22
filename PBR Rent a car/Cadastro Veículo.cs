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
    public partial class Cadastro_Veículo : Form
    {
        public Cadastro_Veículo()
        {
            comboBox_Modelo = new ComboBox();
            List<Modelo> modelos = Modelo.todosOsModelos();
            int CountModelo = modelos.Count;
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
            Modelo selecionado;
            Veículo novo;
            DialogResult dialogResult = MessageBox.Show("Ao encerrar esse processo os dados serão cadastrados. Você tem certeza que quer editar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                if (textBox_Cor.Text == "" || textBox_Ano.Text == "" || textBox_Categoria.Text == "")
                    MessageBox.Show("Por favor digite todos os campos importantes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToInt32(textBox_Ano.Text) > DateTime.Now.Year )
                    MessageBox.Show("Por favor saia do futuro, digite um ano coerente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToInt32(textBox_Ano.Text) < 1807)
                    MessageBox.Show("O carro nem foi inventado nessa época. Por favor digite um ano coerente,", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    using (var ctx = new DadosContainer())
                    {
                        var mnome = modelo[1];
                        var mfornecedor = modelo[0];
                        selecionado = ctx.ModeloSet.Where(m => m.Nome == mnome && m.Fornecedor == mfornecedor).FirstOrDefault();
                        novo = new Veículo(textBox_Cor.Text, Convert.ToInt32(textBox_Ano.Text), textBox_Categoria.Text, 0, selecionado);
                        ctx.SaveChanges();
                    }
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

        public int DataTime { get; set; }
    }
}
