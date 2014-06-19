using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Funcionário
    {
        public enum TipoDeFuncionário
        {
            Funcionário,
            Gerente
        };
        private TipoDeFuncionário função;

        public Funcionário() { }
        public Funcionário(string nome, string carteiraTrab, float salário, TipoDeFuncionário função, Login login)
        {
            this.Nome = nome;
            this.CarteiraDeTrabalho = carteiraTrab;
            this.Salário = salário;
            this.função = função;
            this.Função = (byte)função;
            this.Login = login;
            this.Login.setDonoDaConta(this);
        }

        public TipoDeFuncionário getFunção()
        {
            return this.função;
        }

        public void promover()
        {
            this.função = TipoDeFuncionário.Gerente;
            this.Função = (byte)TipoDeFuncionário.Gerente;
        }

        public void rebaixar()
        {
            this.função = TipoDeFuncionário.Funcionário;
            this.Função = (byte)TipoDeFuncionário.Funcionário;
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
