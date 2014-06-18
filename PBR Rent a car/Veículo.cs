using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Veículo
    {
        public enum estado
        {
            Locado,
            Manutenção,
            Disponivel
        };
        public estado status;

        public void setLocado()
        {
            this.status = estado.Locado;
            this.Estado = SerializarEstado();
            atualizarEstado();
        }

        public void setDisponivel()
        {
            this.status = estado.Disponivel;
            this.Estado = SerializarEstado();
            atualizarEstado();
        }

        public void setManutenção()
        {
            this.status = estado.Manutenção;
            this.Estado = SerializarEstado();
            atualizarEstado();
        }

        public Veículo() { }
        public Veículo(string cor, int ano, string categoria,int quilometragem, Modelo modelo)
        {
            this.Cor = cor;
            this.Ano = ano;
            this.Categoria = categoria;
            this.Quilometragem = quilometragem;
            this.Modelo = modelo;
            this.status = estado.Disponivel;
            this.Estado = SerializarEstado();
        }

        private byte SerializarEstado() //Transforma status em formato armazenável pelo BD
        {
            return (byte)status;
        }

        //Métodos responsáveis pela interação com o BD
        public void gravar()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.AddToVeículoSet(this);
                ctx.SaveChanges();
            }
        }

        private void atualizarEstado()
        {
            using (var ctx = new DadosContainer())
            {
                foreach (var v in ctx.VeículoSet)
                {
                    if (v.Id == this.Id)
                    {
                        v.Estado = SerializarEstado();
                        break;
                    }
                }
                ctx.SaveChanges();
            }
        }

        public static List<Veículo> todosOsVeículos()
        {
            List<Veículo> todos = new List<Veículo>();
            using (var ctx = new DadosContainer())
            {
                foreach (var v in ctx.VeículoSet) todos.Add(v);
            }
            return todos;
        }
    }
}
