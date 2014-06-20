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
