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

        Locação(int anoInicio, int mesInicio, int diaInicio, int horaInicio, int minutoInicio, int segundoInicio, int anoFim, int mesFim, int diaFim, int horaFim, int minutoFim, int segundoFim, Cliente cliente) 
        {
            this.inicio = new DateTime(anoInicio, mesInicio, diaInicio, horaInicio, minutoInicio, segundoInicio);
            this.fim = new DateTime(anoFim, mesFim, diaFim, horaFim, minutoFim, segundoInicio); ; 
            this.Cliente = cliente; 
        }

    }
}
