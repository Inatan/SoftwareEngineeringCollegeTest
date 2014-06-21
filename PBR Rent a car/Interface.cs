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
    public partial class Interface : Form
    {
        Cadastro_Modelo cModelo;
        Cadastro_Veículo cVeículo;
        Cadastro_Cliente cCliente;
        Reserva_de_veículo rVeículo;
        Pesquisa_Veículos pVeículo;
        PesquisarCliente pClientes;
        Pesquisa_Manutenção pManutenção;
        Pesquisar_Locações pLocações;
        Criar_Locação lVeículo;
        Adicionar_funcionário cFuncionário;
        Pesquisar_Funcionário pFuncionário;
        Emissão_de_Relatório eRelatório;

        private Login usuárioAtual;

        public Interface()
        {
            InitializeComponent();
        }

        public void setUsuárioAtual(Login atual)
        {
            this.usuárioAtual = atual;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cModelo = new Cadastro_Modelo();
            cModelo.ShowDialog();
        }

        private void Button_Cadastrar_Veículo_Click(object sender, EventArgs e)
        {
            cVeículo = new Cadastro_Veículo();
            cVeículo.ShowDialog();
        }

        private void Button_Cadastrar_Cliente_Click(object sender, EventArgs e)
        {
            cCliente = new Cadastro_Cliente();
            cCliente.ShowDialog();
        }

        private void Button_Reservar_Veículo_Click(object sender, EventArgs e)
        {
            rVeículo = new Reserva_de_veículo();
            rVeículo.ShowDialog();
        }

        private void Button_Pesquisar_Veículo_Click(object sender, EventArgs e)
        {
            pVeículo = new Pesquisa_Veículos();
            pVeículo.ShowDialog();
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cCliente = new Cadastro_Cliente();
            cCliente.ShowDialog();
        }

        private void cadastrarModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cModelo = new Cadastro_Modelo();
            cModelo.ShowDialog();
        }

        private void cadastrarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVeículo = new Cadastro_Veículo();
            cVeículo.ShowDialog();
        }

        private void pesquisarVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pVeículo = new Pesquisa_Veículos();
            pVeículo.ShowDialog();
        }

        private void reservarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVeículo = new Reserva_de_veículo();
            rVeículo.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreAEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PBR_Rent_a_Car About = new PBR_Rent_a_Car();
            About.ShowDialog();
        }

        private void buttonPesquisarClientes_Click(object sender, EventArgs e)
        {
            pClientes = new PesquisarCliente();
            pClientes.ShowDialog();
        }

        private void buttonPesquisarManutenções_Click(object sender, EventArgs e)
        {
            pManutenção = new Pesquisa_Manutenção();
            pManutenção.ShowDialog();
        }

        private void retornarVeículoDaManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pManutenção = new Pesquisa_Manutenção();
            pManutenção.ShowDialog();
        }

        private void buttonPesquisarLocação_Click(object sender, EventArgs e)
        {
            pLocações = new Pesquisar_Locações();
            pLocações.ShowDialog();
        }

        private void pesquisarLocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pLocações = new Pesquisar_Locações();
            pLocações.ShowDialog();
        }

        private void pesquisarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pClientes = new PesquisarCliente();
            pClientes.ShowDialog();
        }

        private void locarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lVeículo = new Criar_Locação();
            lVeículo.ShowDialog();
        }

        private void buttonLocarVeículo_Click(object sender, EventArgs e)
        {
            lVeículo = new Criar_Locação();
            lVeículo.ShowDialog();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuárioAtual.getPermissão() == Login.TipoDeUsuário.Gerente)
            {
                cFuncionário = new Adicionar_funcionário();
                cFuncionário.ShowDialog();
            }
            else new SemPermissão().ShowDialog();
        }

        private void emitirRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuárioAtual.getPermissão() == Login.TipoDeUsuário.Gerente)
            {
                eRelatório = new Emissão_de_Relatório();
                eRelatório.ShowDialog();
            }
            else new SemPermissão().ShowDialog();
        }

        private void pesquisarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFuncionário = new Pesquisar_Funcionário();
            pFuncionário.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLogin login = new CadastroLogin();
            this.Close();
            login.ShowDialog();
        }

        private void Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
