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
        public Cliente(string nome, string cpfcnpj, string telefoneFixo, string telefoneMóvel, Endereço endereço)
        {
            this.Nome=nome;
            this.CPF = cpfcnpj;
            this.Endereço=endereço;
            telefones= new List<string>();
            this.telefones.Add(telefoneFixo);
            this.telefones.Add(telefoneMóvel);
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
