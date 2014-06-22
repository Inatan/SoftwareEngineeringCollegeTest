using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Cliente
    {
        public List<string> telefones { get; private set; }

        public Cliente() { }
        public Cliente(string nome, string cpfcnpj, string telefoneFixo, string telefoneMóvel, Endereço endereço, Login login)
        {
            this.Nome=nome;
            this.CPF = cpfcnpj;
            this.Endereço=endereço;
            telefones= new List<string>();
            this.telefones.Add(telefoneFixo);
            this.telefones.Add(telefoneMóvel);
            this.Telefone = SerializarTelefones();
            this.Notificação = "";
            this.Login = login;
            this.Login.setDonoDaConta(this);
        }

        private string SerializarTelefones()
        {
            return String.Join("/", telefones);
        }
    }
}
