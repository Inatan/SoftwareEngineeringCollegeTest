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
            históricos = Histórico.ToList<Histórico>();
        }

        public static Relatório singleton()
        {
            return relatório;
        }
        //--------------Fim da implementação do Pattern!--------------

        private List<Histórico> históricos = new List<Histórico>();

        public List<Histórico> getHistóricos()
        {
            return this.históricos;
        }

        public void adicionarHistórico(Histórico h)
        {
            históricos.Add(h);
            Histórico.Add(h);
        }
    }
}
