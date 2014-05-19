using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Locação
    {
        public DateTime inicio { get; private set; }
        public DateTime fim { get; private set; }
        public Cliente cliente { get; private set; }

        Locação(DateTime inicio, DateTime fim, Cliente cliente) 
        { 
            this.inicio = inicio; 
            this.fim = fim; 
            this.cliente = cliente; 
        }

    }
}
