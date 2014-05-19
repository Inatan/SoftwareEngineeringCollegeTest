using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Manutenção
    {
        public DateTime inicio { get; private set; }
        public DateTime fim { get; private set; }
        public string motivo { get; private set; }

        public Manutenção(DateTime inicio, DateTime fim, string motivo) 
        { 
            this.inicio = inicio; 
            this.fim = fim; 
            this.motivo = motivo; 
        }
    }
}
