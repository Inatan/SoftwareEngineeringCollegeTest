using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Veículo
    {
        public enum estado : byte
        {
            Disponível = 0,
            Manutenção,
            Locado
        };
        private estado status;

        public estado getEstado()
        {
            this.status = (estado)Estado;
            return this.status;
        }

        public void setLocado()
        {
            this.status = estado.Locado;
            this.Estado = SerializarEstado();
        }

        public void setDisponivel()
        {
            this.status = estado.Disponível;
            this.Estado = SerializarEstado();
        }

        public void setManutenção()
        {
            this.status = estado.Manutenção;
            this.Estado = SerializarEstado();
        }

        public Veículo() { }
        public Veículo(string cor, int ano, string categoria,int quilometragem, Modelo modelo)
        {
            this.Cor = cor;
            this.Ano = ano;
            this.Categoria = categoria;
            this.Quilometragem = quilometragem;
            this.Modelo = modelo;
            this.status = estado.Disponível;
            this.Estado = SerializarEstado();
            this.Histórico = new Histórico(this, new List<Manutenção>(), new List<Locação>());
            this.Modelo.Veículo.Add(this);
        }

        private byte SerializarEstado() //Transforma status em formato armazenável pelo BD
        {
            return (byte)status;
        }

        public override string ToString()
        {
            return "Veículo com ID " + this.Id;
        }
    }
}
