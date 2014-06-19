using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Login
    {
        public enum TipoDeUsuário
        {
            Cliente,
            Funcionário,
            Gerente
        };
        private TipoDeUsuário permissão;

        public Login() { }
        public Login(string usuário, string senha, TipoDeUsuário permissão)
        {
            this.Usuário = usuário;
            this.Senha = senha;
            this.permissão = permissão;
            this.Permissão = (byte)permissão;
        }

        public TipoDeUsuário getPermissão()
        {
            this.permissão = (TipoDeUsuário)Permissão;
            return this.permissão;
        }

        public void setPermissão(TipoDeUsuário permissão)
        {
            this.permissão = permissão;
            this.Permissão = (byte)permissão;
        }

        public void setDonoDaConta(Cliente cliente)
        {
            if (this.permissão == TipoDeUsuário.Cliente)
            {
                this.Cliente = cliente;
                this.Cliente.Login = this;
            }
        }

        public void setDonoDaConta(Funcionário funcionário)
        {
            if (this.permissão == TipoDeUsuário.Funcionário || this.permissão == TipoDeUsuário.Gerente)
            {
                this.Funcionário = funcionário;
                this.Funcionário.Login = this;
            }
        }

        public void gravar()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.AddToLoginSet(this);
                ctx.SaveChanges();
            }
        }

        public static Login loginVálido(string usuário, string senha)
        {//Retorna NULL caso o login seja inválido!!!
            return todosOsLogins().Find(l => verificaUsuárioESenha(usuário, senha, l));
        }

        private static bool verificaUsuárioESenha(string usuário, string senha, Login login)
        {
            return usuário == login.Usuário && senha == login.Senha;
        }

        private static List<Login> todosOsLogins()
        {
            List<Login> logins = new List<Login>();
            using (var ctx = new DadosContainer())
            {
                foreach (var login in ctx.LoginSet)
                    logins.Add(login);
            }
            return logins;
        }
    }
}
