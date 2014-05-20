using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Endereço
    {
        public Endereço() { }
        public Endereço(string uf,string cidade,string bairro,string rua,int número,int cep)
        {
            this.UF = uf;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Rua = rua;
            this.Número = número;
            this.CEP = cep;
        }

    }

    
}
