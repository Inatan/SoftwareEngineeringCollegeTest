using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Endereço
    {
        private string uf;
        private string cidade;
        private string bairro;
        private string rua;
        private int número;
        private int cep;


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
