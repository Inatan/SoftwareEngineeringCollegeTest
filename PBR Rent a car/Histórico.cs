using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Histórico
    {
        public Veículo veiculo { get; private set; }
        public List<Manutenção> manutenções { get; private set; }
        public List<Locação> locações { get; private set; }

        public Histórico(Veículo veiculo, List<Manutenção> manutenções, List<Locação> locações)
        {
            this.veiculo = veiculo;
            this.manutenções=manutenções;
            this.locações = locações;
        }
    }
}
