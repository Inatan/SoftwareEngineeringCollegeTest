using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Veículo
    {
        private string cor;
        private int ano;
        private string categoria;
        private int quilometragem;
        private Modelo modelo;
        private enum estado
        {
            Locado,
            Manutenção,
            Disponivel
        };
        private estado status;

        public Veículo(string cor, int ano, string categoria,int quilometragem, Modelo modelo)
        {
            this.cor = cor;
            this.ano = ano;
            this.categoria = categoria;
            this.quilometragem = quilometragem;
            this.modelo = modelo;
            this.status =estado.Disponivel;
        }
    }
    
    
}
