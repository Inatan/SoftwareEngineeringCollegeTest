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
        Pesquisa_Veículo pVeículo;

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
                pVeículo = new Pesquisa_Veículo();
                pVeículo.ShowDialog();
            }
        }
    }
}
