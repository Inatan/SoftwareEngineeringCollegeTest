using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Reserva
    {
        private Veículo veículo;
        private DateTime Pedido;
        private Cliente cliente;

        public Reserva(Veículo veículo, int dia, int mes, int ano,int hora, int minuto,int segundo, Cliente cliente)
        {
            this.cliente = cliente;
            this.veículo = veículo;
            this.Pedido = new DateTime(ano, mes, dia, hora, minuto, segundo);
        }
    }

    
}
