using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Relatório
    {
        public List<Histórico> históricos {get;private set;}

        Relatório(List<Histórico> históricos)
        {
            this.históricos = históricos;
        }

    }
}
