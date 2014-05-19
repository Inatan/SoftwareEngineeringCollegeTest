using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Endereço
    {
        public string uf{ get; private set; }
        public string cidade{ get; private set; }
        public string bairro{ get; private set; }
        public string rua{ get; private set; }
        public int número{ get; private set; }
        public int cep{ get; private set; }


        public Endereço(string uf,string cidade,string bairro,string rua,int número,int cep)
        {
            this.uf = uf;
            this.cidade = cidade;
            this.bairro = bairro;
            this.rua = rua;
            this.número = número;
            this.cep = cep;
        }

    }

    
}
