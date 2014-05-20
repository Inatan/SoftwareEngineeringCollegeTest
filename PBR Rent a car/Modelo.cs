using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Modelo
    {
        //private string p;
       // private string p_2;

        public Modelo(string nome, string fornecedor)
        {
            this.Nome = nome;
            this.Fornecedor = fornecedor;
        }

       /* public Modelo(string p, string p_2)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
        }*/

        //Métodos responsáveis pela interação com o BD
        public void gravar()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.AddToModeloSet(this);
                ctx.SaveChanges();
            }
        }

        public static Modelo pesquisar(int id)
        {
            using (var ctx = new DadosContainer())
            {
                foreach (var x in ctx.ModeloSet)
                {
                    if (x.Id == id) return x;
                }
            }
            return null;
        }
    }
}
