using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Funcionário
    {
        public string nome { get; private set; }
        public string carteiraTrab { get; private set; }
        public float salário { get; private set; }

        public Funcionário(string nome, string carteiraTrab, float salário)
        {
            this.nome = nome;
            this.carteiraTrab = carteiraTrab;
            this.salário = salário;
        }

    }
}
