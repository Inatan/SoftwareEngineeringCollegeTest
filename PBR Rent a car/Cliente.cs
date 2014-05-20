using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Cliente
    {
        public string nome { get; private set; }
        public string cpfcnpj { get; private set; }
        public List<string> telefones { get; private set; }
        public Endereço endereço { get; private set; }
        public string notificação { get; private set; }

        public Cliente(string nome, string cpfcnpj, List<string> telefones, Endereço endereço, string notificação)
        {
            this.nome=nome;
            this.cpfcnpj=cpfcnpj;
            this.telefones=telefones;
            this.endereço=endereço;
            this.notificação=notificação;
        }
    }
}
