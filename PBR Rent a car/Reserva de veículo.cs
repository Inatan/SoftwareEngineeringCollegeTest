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
    public partial class Reserva_de_veículo : Form
    {
        Pesquisa_Veículos pVeículo;
        PesquisarCliente pCliente;

        private Login usuárioAtual;

        public void setUsuárioAtual(Login atual)
        {
            this.usuárioAtual = atual;
        }

        int idCliente;
        int idVeículo;

        public Reserva_de_veículo(Login atual)
        {
            setUsuárioAtual(atual);
            InitializeComponent();
            if (usuárioAtual.getPermissão() == Login.TipoDeUsuário.Cliente)
            {
                List<string> listaNomes = new List<string>();
                string dadosCliente;
                Cliente usuárioCliente;
                using (var ctx = new DadosContainer())
                {
                    ctx.Attach(usuárioAtual);
                    ctx.Attach(usuárioAtual.Cliente);
                    usuárioCliente = usuárioAtual.Cliente;
                    listaNomes.Add(usuárioCliente.Nome);
                    if (usuárioAtual.Cliente.CPF.Length == 14)
                        listaNomes.Add("CNPJ: " + usuárioCliente.CPF);
                    else
                        listaNomes.Add("CPF: " + usuárioCliente.CPF);
                    listaNomes.Add("Telefones: " + usuárioCliente.Telefone);
                    listaNomes.Add("CEP: " + usuárioCliente.Endereço.CEP);
                    listaNomes.Add(usuárioCliente.Endereço.Cidade);
                    dadosCliente = String.Join(" - ", listaNomes);
                    listBoxCliente.Items.Add(dadosCliente);
                    listBoxCliente.Items.Remove("Clique aqui para pesquisar o Cliente");
                    idCliente = usuárioCliente.Id;
                }
            }
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxVeículo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.ListBoxVeículo.Items[0].ToString() == "Clique aqui para pesquisar o veículo")
            {
                pVeículo = new Pesquisa_Veículos();
                pVeículo.ShowDialog();
                if (pVeículo.veículoPesquisado != null)
                {
                    List<string> listaNomes= new List<string>();
                    string dadosVeiculo;
                    using (var ctx = new DadosContainer())
                    {
                        ctx.Attach(pVeículo.veículoPesquisado);
                        listaNomes.Add(pVeículo.veículoPesquisado.Modelo.Fornecedor);
                        listaNomes.Add(pVeículo.veículoPesquisado.Modelo.Nome);
                        listaNomes.Add(pVeículo.veículoPesquisado.Cor);
                        listaNomes.Add(pVeículo.veículoPesquisado.Ano.ToString());
                        listaNomes.Add(pVeículo.veículoPesquisado.Quilometragem.ToString() + " Km");
                        dadosVeiculo = String.Join(" - ", listaNomes);
                        ListBoxVeículo.Items.Remove("Clique aqui para pesquisar o veículo");
                        ListBoxVeículo.Items.Add(dadosVeiculo);
                        idVeículo = pVeículo.veículoPesquisado.Id;
                    }
                }
            }
        }

        private void Button_Reservar_Click(object sender, EventArgs e)
        {
            using (var ctx = new DadosContainer())
            {
                if ((Login.TipoDeUsuário)usuárioAtual.Permissão == Login.TipoDeUsuário.Cliente)
                {
                    //Lógica do cliente aqui
                }
                else
                {
                    try
                    {
                        Veículo aSerReservado = ctx.VeículoSet.Where(v => v.Id == idVeículo).First();
                        Cliente reservador = ctx.ClienteSet.Where(c => c.Id == idCliente).First();
                        ctx.Attach(usuárioAtual);
                        Reserva reserva = new Reserva(aSerReservado, int.Parse(comboBoxDia.Text), int.Parse(comboBoxMês.Text),
                            int.Parse(comboBoxAno.Text), int.Parse(comboBoxHora.Text), int.Parse(comboBoxMinuto.Text),
                            reservador, usuárioAtual.Funcionário);
                        aSerReservado.setLocado(usuárioAtual.Funcionário, reservador,
                            new DateTime(int.Parse(comboBoxAno.Text), int.Parse(comboBoxMês.Text), int.Parse(comboBoxDia.Text), 
                             int.Parse(comboBoxHora.Text), int.Parse(comboBoxMinuto.Text), 0));
                        MessageBox.Show("A reserva foi realizada com sucesso");
                    }
                    catch
                    {
                        MessageBox.Show("Cliente ou Veículo não encontrado(s) tente novamente");
                    }
                }
                ctx.SaveChanges();
            }
        }

        private void listBoxCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.listBoxCliente.Items[0].ToString() == "Clique aqui para pesquisar o Cliente")
            {
                pCliente = new PesquisarCliente();
                pCliente.ShowDialog();
                if (pCliente.clientePesquisado != null)
                {
                    //Interface bonita aqui.
                    idCliente = pCliente.clientePesquisado.Id;
                }
            }
        }

        private void Reserva_de_veículo_Load(object sender, EventArgs e)
        {

        }
    }
}
