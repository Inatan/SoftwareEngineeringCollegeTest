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
    public partial class Emissão_de_Relatório : Form
    {
        public Emissão_de_Relatório()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.comboBoxDia.Enabled)
            {
                this.comboBoxDia.Enabled = true;
                this.comboBoxMês.Enabled = true;
                this.comboBoxAno.Enabled = true;
            }
            else
            {
                this.comboBoxDia.Enabled = false;
                this.comboBoxMês.Enabled = false;
                this.comboBoxAno.Enabled = false;
            }

        }

    }
}
