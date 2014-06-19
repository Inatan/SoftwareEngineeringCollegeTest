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

        public Reserva_de_veículo()
        {
            InitializeComponent();
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

                    listaNomes.Add(pVeículo.veículoPesquisado.Modelo.Fornecedor);
                    listaNomes.Add(pVeículo.veículoPesquisado.Modelo.Nome);
                    listaNomes.Add(pVeículo.veículoPesquisado.Cor);
                    listaNomes.Add(pVeículo.veículoPesquisado.Ano.ToString());
                    listaNomes.Add(pVeículo.veículoPesquisado.Quilometragem.ToString() + " Km");
                    dadosVeiculo= String.Join(" - ",listaNomes);
                    ListBoxVeículo.Items.Remove("Clique aqui para pesquisar o veículo");
                    ListBoxVeículo.Items.Add(dadosVeiculo);
                }
            }
        }

        private void Button_Reservar_Click(object sender, EventArgs e)
        {
            Cliente cProcurado = new Cliente();
            Veículo vProcurado= new Veículo();
            List<Cliente> clientes = Cliente.todosOsClientes();
            int countReserva= clientes.Count;
            for (int i=0; i < countReserva; i++)
             //   if (Program.clientes[i].Nome == textBox_Nome_Cliente.Text.ToString())
              //      cProcurado = Program.clientes[i];
            if(pVeículo !=null)
                vProcurado = pVeículo.veículoPesquisado;
            if (cProcurado.Nome == null || vProcurado== null)
                MessageBox.Show("Cliente ou Veículo não encontrado(s) tente novamente");
            else
            {
        //        Program.reservas.Add(new Reserva(vProcurado, Convert.ToInt32(textBox_Dia.Text), Convert.ToInt32(textBox_Mês.Text), Convert.ToInt32(textBox_Ano.Text), Convert.ToInt32(textBox_Hora.Text), Convert.ToInt32(textBox_Minuto.Text), cProcurado));
                MessageBox.Show("Sua reserva foi realizada com sucesso, espere a permissão do administrador");
        //        vProcurado.setLocado();   
            }        
            
        }
    }
}
