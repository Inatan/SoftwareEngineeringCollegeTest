using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    partial class Veículo
    {
        public string cor { get; private set; }
        public int ano { get; private set; }
        public string categoria { get; private set; }
        public int quilometragem { get; private set; }
        public Modelo modelo { get; private set; }
        private enum estado
        {
            Locado,
            Manutenção,
            Disponivel
        };
        private estado status;

        public void setLocado()
        {
            this.status = estado.Locado;
        }

        public void setDisponivel()
        {
            this.status = estado.Disponivel;
        }
        public void setManutenção()
        {
            this.status = estado.Manutenção;
        }

        public Veículo(string cor, int ano, string categoria,int quilometragem, Modelo modelo)
        {
            this.cor = cor;
            this.ano = ano;
            this.categoria = categoria;
            this.quilometragem = quilometragem;
            this.modelo = modelo;
            this.status = estado.Disponivel;
            //Integração com BD
            CreateVeículo(_Id, cor, ano, categoria, quilometragem, SerializarEstado());
            Modelo = modelo;
        }

        private byte SerializarEstado() //Transforma status em formato armazenável pelo BD
        {
            return (byte)status;
        }

        public List<Veículo> pesquisar(Modelo modelo, string cor, int ano, string categoria, int quilometragem)
        {
            List<Veículo> encontrados = new List<Veículo>();
            using (var ctx = new DadosContainer())
            {
                foreach (var v in ctx.VeículoSet)
                {
                    if (adequado(v, modelo, cor, ano, categoria, quilometragem)) encontrados.Add(v);
                }
            }
            return encontrados;
        }

        private bool adequado(Veículo v, Modelo m, string cor, int ano, string cat, int km)
        {
            if (v.Modelo == m && v.cor == cor && v.ano == ano && v.categoria == cat && v.quilometragem == km) return true;
            return false;
        }
    }
}
