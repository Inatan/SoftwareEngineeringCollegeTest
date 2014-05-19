using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Cliente
    {
        private string nome;
        private string cpfcnpj;
        private List<string> telefones;
        private Endereço endereço;
        private string notificação;

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
