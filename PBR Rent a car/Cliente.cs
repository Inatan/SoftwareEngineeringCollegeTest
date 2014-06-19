using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Cliente
    {
        public List<string> telefones { get; private set; }//Para a próxima etapa...

        public Cliente() { }
        public Cliente(string nome, string cpfcnpj, string telefoneFixo, string telefoneMóvel, Endereço endereço)
        {
            this.Nome=nome;
            this.CPF = cpfcnpj;
            this.Endereço=endereço;
            this.Endereço.Cliente = this;
            telefones= new List<string>();
            this.telefones.Add(telefoneFixo);
            this.telefones.Add(telefoneMóvel);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
            this.Telefone = SerializarTelefones();
        }

        public string SerializarTelefones()
        {
            return String.Join("/", telefones);
        }

        public List<string> getTelefones()
        {
            return this.Telefone.Split('/').ToList<string>();
<<<<<<< HEAD
=======
            this.Login = login;
            this.Login.setDonoDaConta(this);
>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======
            this.Login = login;
            this.Login.setDonoDaConta(this);
>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
        }

        public void gravar()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.AddToClienteSet(this);
                ctx.SaveChanges();
            }
        }

        public static List<Cliente> todosOsClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var ctx = new DadosContainer())
            {
                foreach (var cliente in ctx.ClienteSet)
                    clientes.Add(cliente);
            }
            return clientes;
        }
    }
}
