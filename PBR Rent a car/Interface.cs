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
        public Interface()
        {
            InitializeComponent();
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

    }
}
