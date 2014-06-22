using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Reserva
    {
        private DateTime Pedido;

        public Reserva() { }
        public Reserva(Veículo veículo, int dia, int mes, int ano,int hora, int minuto, Cliente cliente, Funcionário func)
        {
            this.Cliente = cliente;
            this.Veículo = veículo;
            this.Pedido = new DateTime(ano, mes, dia, hora, minuto, 0);
            this.Data = this.Pedido.ToBinary();
            this.Funcionário = func;
        }
    }

    
}
