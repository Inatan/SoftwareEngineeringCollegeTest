using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Funcionário
    {
        public Funcionário() { }
        public Funcionário(string nome, string carteiraTrab, float salário)
        {
            this.Nome = nome;
            this.CarteiraDeTrabalho = carteiraTrab;
            this.Salário = salário;
        }

    }
}
