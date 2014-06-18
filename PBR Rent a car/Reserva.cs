using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Reserva
    {
        public DateTime Pedido{ get; private set; } //Necessário fazer conversão para o BD

        public Reserva() { }
        public Reserva(Veículo veículo, int dia, int mes, int ano,int hora, int minuto, Cliente cliente)
        {
            this.Cliente = cliente;
            this.Veículo = veículo;
            this.Pedido = new DateTime(ano, mes, dia, hora, minuto, 0);
        }
    }

    
}
