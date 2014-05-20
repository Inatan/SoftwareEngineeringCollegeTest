using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Cliente
    {
        public List<string> telefones { get; private set; }

        public Cliente(string nome, string cpfcnpj, List<string> telefones, Endereço endereço, string notificação)
        {
            this.Nome=nome;
            this.CPF=cpfcnpj;
            this.telefones=telefones;
            this.Endereço=endereço;
            this.Notificação=notificação;
        }
    }
}
