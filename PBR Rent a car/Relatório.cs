using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Relatório
    {
        public List<Histórico> históricos {get;private set;}

        public Relatório() { }
        Relatório(List<Histórico> históricos)
        {
            this.históricos = históricos;
        }

    }
}
