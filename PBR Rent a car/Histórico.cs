using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Histórico
    {
        public List<Manutenção> manutenções { get; private set; }
        public List<Locação> locações { get; private set; }

        public List<Manutenção> getManutenções()
        {
            if (manutenções == null) manutenções = Manutenção.ToList();
            return manutenções;
        }

        public List<Locação> getLocações()
        {
            if (locações == null) locações = Locação.ToList();
            return locações;
        }

        public string stringManutenções()
        {
            string res = "";
            foreach (Manutenção m in getManutenções())
            {
                res = res + m.ToString() + "\n";
            }
            return res;
        }

        public string stringLocações()
        {
            string res = "";
            foreach (Locação l in getLocações())
            {
                res = res + l.ToString() + "\n";
            }
            return res;
        }

        public void addManutenção(Manutenção m)
        {
            if (manutenções == null) manutenções = Manutenção.ToList();
            manutenções.Add(m);
            Manutenção.Add(m);
        }

        public Manutenção últimaManutenção()
        {
            if (manutenções == null) manutenções = Manutenção.ToList();
            return manutenções.Last();
        }

        public void addLocação(Locação l)
        {
            if (locações == null) locações = Locação.ToList();
            locações.Add(l);
            Locação.Add(l);
        }

        public Locação últimaLocação()
        {
            if (locações == null) locações = Locação.ToList();
            return locações.Last();
        }

        public override string ToString()
        {
            return "Histórico com ID " + this.Id + "\n"
                + "Manutenções " + stringManutenções() + "\n"
                + "Locações " + stringLocações() + "\n";
        }

        public Histórico() { }
        public Histórico(Veículo veiculo, List<Manutenção> manutenções, List<Locação> locações)
        {
            this.Veículo = veiculo;
            this.manutenções = manutenções;
            this.locações = locações;
            this.Relatório = Relatório.singleton();
        }
    }
}
