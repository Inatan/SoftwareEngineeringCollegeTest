using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Modelo
    {
        public Modelo() {}

        public Modelo(string nome, string fornecedor)
        {
            this.Nome = nome;
            this.Fornecedor = fornecedor;
        }

        //Métodos responsáveis pela interação com o BD
        public void gravar()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.AddToModeloSet(this);
                ctx.SaveChanges();
            }
        }

        public static List<Modelo> todosOsModelos()
        {
            List<Modelo> modelos = new List<Modelo>();
            using (var ctx = new DadosContainer())
            {
                foreach (var modelo in ctx.ModeloSet)
                {
                    modelos.Add(modelo);
                }
            }
            return modelos;
        }

        public override string ToString()
        {
            return "Modelo " + this.Nome + " com fornecedor " + this.Fornecedor;
        }
    }
}
