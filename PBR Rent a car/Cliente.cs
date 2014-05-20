using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Cliente
    {
        public List<string> telefones { get; private set; } //Para a próxima etapa...

        public Cliente() { }
        public Cliente(string nome, string cpfcnpj, string telefone, Endereço endereço, string notificação)
        {
            this.Nome=nome;
            this.CPF=cpfcnpj;
            this.Telefone = telefone;
            this.Endereço=endereço;
            this.Notificação=notificação;
        }

        public void gravar()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.AddToClienteSet(this);
                ctx.SaveChanges();
            }
        }
    }
}
