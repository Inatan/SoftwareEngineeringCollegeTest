using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Relatório
    {
        //--------------Singleton Object Pattern!--------------
        private static Relatório relatório = new Relatório();
        
        private Relatório() 
        {
            using (var ctx = new DadosContainer())
            {
                históricos = ctx.HistóricoSet.ToList();
                foreach (Histórico h in históricos)
                {
                    Histórico.Add(h);
                }
                ctx.SaveChanges();
            }
        }

        public static Relatório singleton()
        {
            return relatório;
        }
        //--------------Fim da implementação do Pattern!--------------

        private List<Histórico> históricos = new List<Histórico>();

        public List<Histórico> getHistóricos()
        {
            this.históricos = Histórico.ToList();
            return this.históricos;
        }

        public void teste()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.Attach(this);
                var hs = Histórico.ToList();
                Console.WriteLine(hs.Count);
                foreach (var h in hs) Console.WriteLine(h.ToString());
            }
        }

        public void adicionarHistórico(Histórico h)
        {
            if (históricos == null) históricos = Histórico.ToList();
            históricos.Add(h);
            Histórico.Add(h);    
        }
    }
}
