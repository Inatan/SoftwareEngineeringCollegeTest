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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRedefinirSenha_Click(object sender, EventArgs e)
        {
            Redefinição_de_senha Redefinição = new Redefinição_de_senha();
            Redefinição.ShowDialog();
        }

    }
}
