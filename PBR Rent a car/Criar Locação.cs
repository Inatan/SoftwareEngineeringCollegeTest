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
    public partial class Criar_Locação : Form
    {
        Pesquisa_Veículos pVeículo;
        PesquisarCliente pCliente;

        private Login usuárioAtual;

        public void setUsuárioAtual(Login atual)
        {
            this.usuárioAtual = atual;
        }

        int idVeículo;
        int idCliente;

        public Criar_Locação()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxCliente.Items[0].ToString() == "Clique aqui para pesquisar o Cliente")
            {
                List<string> listaNomes = new List<string>();
                string dadosCliente;
                
                pCliente = new PesquisarCliente();
                pCliente.ShowDialog();
                Cliente clientePesquisado = pCliente.clientePesquisado;
                if(pCliente.clientePesquisado != null)
                {
                    using (var ctx = new DadosContainer())
                    {
                        ctx.Attach(pCliente.clientePesquisado);
                        listaNomes.Add(clientePesquisado.Nome);
                        if (clientePesquisado.CPF.Length == 14)
                            listaNomes.Add("CNPJ: " + clientePesquisado.CPF);
                        else
                            listaNomes.Add("CPF: " + clientePesquisado.CPF);
                        listaNomes.Add("Telefones: " + clientePesquisado.Telefone);
                        listaNomes.Add("CEP: " + clientePesquisado.Endereço.CEP);
                        listaNomes.Add(clientePesquisado.Endereço.Cidade);
                        dadosCliente = String.Join(" - ", listaNomes);
                        listBoxCliente.Items.Add(dadosCliente);
                        listBoxCliente.Items.Remove("Clique aqui para pesquisar o Cliente");
                        idCliente = pCliente.clientePesquisado.Id;
                    }
                }
            }
        }

        private void ListBoxVeículo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBoxVeículo.Items[0].ToString() == "Clique aqui para pesquisar o Veículo")
            {
                pVeículo = new Pesquisa_Veículos();
                pVeículo.ShowDialog();
                Veículo veículoPesquisado = pVeículo.veículoPesquisado;
                if (veículoPesquisado != null)
                {
                    List<string> listaNomes = new List<string>();
                    string dadosVeiculo;
                    using (var ctx = new DadosContainer())
                    {
                        ctx.Attach(pVeículo.veículoPesquisado);
                        listaNomes.Add(veículoPesquisado.Modelo.Fornecedor);
                        listaNomes.Add(veículoPesquisado.Modelo.Nome);
                        listaNomes.Add(veículoPesquisado.Cor);
                        listaNomes.Add(veículoPesquisado.Ano.ToString());
                        listaNomes.Add(veículoPesquisado.Quilometragem.ToString() + " Km");
                        dadosVeiculo = String.Join(" - ", listaNomes);
                        
                        ListBoxVeículo.Items.Add(dadosVeiculo);
                        ListBoxVeículo.Items.Remove("Clique aqui para pesquisar o Veículo");
                        idVeículo = veículoPesquisado.Id;
                    }
                }
            }
        }

        private void buttonLocar_Click(object sender, EventArgs e)
        {
            if ((Login.TipoDeUsuário)this.usuárioAtual.Permissão == Login.TipoDeUsuário.Cliente)
            {
                //Colocar lógica do cliente aqui
            }
            else
            {
                using (var ctx = new DadosContainer())
                {
                    Veículo aSerLocado = ctx.VeículoSet.Where(v => v.Id == idVeículo).First();
                    Cliente locador = ctx.ClienteSet.Where(c => c.Id == idCliente).First();
                    ctx.Attach(usuárioAtual);
                    aSerLocado.setLocado(usuárioAtual.Funcionário, locador);
                    ctx.SaveChanges();
                }
                this.Close();
            }
        }

        private void Criar_Locação_Load(object sender, EventArgs e)
        {

        }
    }
}
