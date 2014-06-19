using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Funcionário
    {
        public Funcionário() { }
        public Funcionário(string nome, string carteiraTrab, float salário, Login login)
        {
            this.Nome = nome;
            this.CarteiraDeTrabalho = carteiraTrab;
            this.Salário = salário;
            this.Login = login;
            this.Login.setDonoDaConta(this);
        }

        public void gravar()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.AddToFuncionárioSet(this);
                ctx.SaveChanges();
            }
        }

        public static List<Funcionário> todosOsFuncionários()
        {
            List<Funcionário> funcionários = new List<Funcionário>();
            using (var ctx = new DadosContainer())
            {
                foreach (var funcionário in ctx.FuncionárioSet)
                    funcionários.Add(funcionário);
            }
            return funcionários;
        }

    }
}
