﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBR_Rent_a_car
{
    public partial class InterfaceCliente : Form
    {
        Pesquisa_Veículos pVeículo;
        Reserva_de_veículo rVeículo;
        Alterar_Dados aDados;
        Criar_Locação locação;

        public InterfaceCliente()
        {
            InitializeComponent();
        }

        private void sobreAEmpresaToolStripMenuSobre_Click(object sender, EventArgs e)
        {
            PBR_Rent_a_Car About = new PBR_Rent_a_Car();
            About.ShowDialog();
        }

        private void pesquisarVeículosToolStripPesquisa_Click(object sender, EventArgs e)
        {
            pVeículo = new Pesquisa_Veículos();
            pVeículo.ShowDialog();
        }

        private void reservarVeículoToolStripMenuReserve_Click(object sender, EventArgs e)
        {
            rVeículo = new Reserva_de_veículo();
            rVeículo.ShowDialog();
        }

        private void alterarDadosToolStripMenuAlterar_Click(object sender, EventArgs e)
        {
            aDados = new Alterar_Dados();
            aDados.ShowDialog();
        }

        private void locarVeículoToolStripMenuLocar_Click(object sender, EventArgs e)
        {
            locação = new Criar_Locação();
            locação.ShowDialog();
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            aDados = new Alterar_Dados();
            aDados.ShowDialog();
        }

        private void buttonLocar_Click(object sender, EventArgs e)
        {
            locação = new Criar_Locação();
            locação.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InterfaceCliente_Load(object sender, EventArgs e)
        {

        }
    }
}