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
        public Devolução_de_Veículo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apenasLetras(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void textBoxQuilometragem_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

    }
}
