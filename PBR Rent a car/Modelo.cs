using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Modelo
    {
        private string nome;
        private string fornecedor;

        Modelo(string nome, string fornecedor)
        {
            this.nome = nome;
            this.fornecedor = fornecedor;
        }

        public string getnome()
        {
            return this.nome;
        }

        public string getfornecedor()
        {
            return this.fornecedor;
        }

    }
}
