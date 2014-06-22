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
        private string option = "";

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
            if (radioButtonPeriodo.Checked) option = "período";
        }

        private void Emissão_de_Relatório_Load(object sender, EventArgs e)
        {

        }

        private void buttonEmitir_Click(object sender, EventArgs e)
        {
            DateTime data = new DateTime();
            switch (option)
            {
                case "dia":
                    data = DateTime.Today;
                    break;
                case "semana":
                    data = DateTime.Today;
                    break;
                case "mes":
                    data = DateTime.Today;
                    break;
                case "ano":
                    data = DateTime.Today;
                    break;
                case "período":
                    data = new DateTime(int.Parse(comboBoxAno.SelectedItem.ToString()), int.Parse(comboBoxMês.SelectedItem.ToString()),
                        int.Parse(comboBoxDia.SelectedItem.ToString()));
                    break;
            }
            Relatório.singleton().gerarRelatório(option, data);
            MessageBox.Show("O documento relatório.pdf com as informações desejadas foi gerado no diretório atual.");
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) option = "dia";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) option = "semana";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) option = "mes";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) option = "ano";
        }

    }
}
