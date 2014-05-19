using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Modelo
    {
        public string nome { get; private set; }
        public string fornecedor { get; private set; }

        Modelo(string nome, string fornecedor)
        {
            this.nome = nome;
            this.fornecedor = fornecedor;
        }

    }
}
