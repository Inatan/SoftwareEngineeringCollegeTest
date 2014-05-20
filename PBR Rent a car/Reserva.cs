using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Reserva
    {
        public Veículo veículo{ get; private set; }
        public DateTime Pedido{ get; private set; }
        public Cliente cliente { get; private set; }

        public Reserva(Veículo veículo, int dia, int mes, int ano,int hora, int minuto,int segundo, Cliente cliente)
        {
            this.cliente = cliente;
            this.veículo = veículo;
            this.Pedido = new DateTime(ano, mes, dia, hora, minuto, segundo);
        }
    }

    
}
