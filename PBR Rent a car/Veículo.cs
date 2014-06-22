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

        public void setLocado(Funcionário permitidor, Cliente locador)
        {
            if (this.status == estado.Disponível)
            {
                this.status = estado.Locado;
                this.Estado = SerializarEstado();
                using (var ctx = new DadosContainer())
                {
                    Locação l = new Locação(DateTime.Now, this.Histórico, permitidor, locador);
                    //ctx.AddToLocaçãoSet(l);
                    ctx.SaveChanges();
                }
            }
        }

        public void setLocado(Funcionário permitidor, Cliente locador, DateTime horario)
        {
            if (this.status == estado.Disponível)
            {
                this.status = estado.Locado;
                this.Estado = SerializarEstado();
                using (var ctx = new DadosContainer())
                {
                    Locação l = new Locação(horario, this.Histórico, permitidor, locador);
                    //ctx.AddToLocaçãoSet(l);
                    ctx.SaveChanges();
                }
            }
        }

        public void setDisponivel()
        {
            using (var ctx = new DadosContainer())
            {
                if (getEstado() == estado.Manutenção)
                {
                    if (!this.Histórico.últimaManutenção().acabou())
                        this.Histórico.últimaManutenção().setFim(DateTime.Now);
                }
                else if (getEstado() == estado.Locado)
                {
                    if (!this.Histórico.últimaLocação().acabou())
                        this.Histórico.últimaLocação().setFim(DateTime.Now);
                }
                ctx.SaveChanges();
            }
            this.status = estado.Disponível;
            this.Estado = SerializarEstado();
        }

        public void setManutenção(Login funcionárioQueMandou)
        {
            if (this.status == estado.Disponível)
            {
                this.status = estado.Manutenção;
                this.Estado = SerializarEstado();
                using (var ctx = new DadosContainer())
                {
                    ctx.Attach(funcionárioQueMandou);
                    var hist = ctx.HistóricoSet.Where(h => h.Id == this.Histórico.Id).First();
                    Manutenção m = new Manutenção(DateTime.Now, "", funcionárioQueMandou.Funcionário, hist);
                    //ctx.AddToManutençãoSet(m);
                    ctx.SaveChanges();
                }
            }
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
