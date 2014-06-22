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
    public partial class Devolução_de_Veículo : Form
    {
        public int quilometragem = 0;
        public bool lida = false;

        public Devolução_de_Veículo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void textBoxQuilometragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeros(e);
        }

        private void Devolução_de_Veículo_Load(object sender, EventArgs e)
        {

        }

        private void buttonPago_Click(object sender, EventArgs e)
        {
            quilometragem = int.Parse(textBoxQuilometragem.Text);
            lida = true;
            this.Close();
        }

    }
}
