using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Locação
    {
        private DateTime inicio;
        private DateTime fim;

        public DateTime getInicio()
        {
            this.inicio = DateTime.FromBinary(this.Inicio);
            return this.inicio;
        }

        public DateTime getFim()
        {
            if (this.Fim.HasValue) this.fim = DateTime.FromBinary(this.Fim.Value);
            return this.fim;
        }

        public void setFim(DateTime fim)
        {
            this.fim = fim;
            this.Fim = fim.ToBinary();
        }

        public bool acabou()
        {
            return this.Fim.HasValue;
        }

        public void carregar()
        {
            this.inicio = DateTime.FromBinary(this.Inicio);
            if (this.Fim.HasValue) this.fim = DateTime.FromBinary(this.Fim.Value);
        }

        public override string ToString()
        {
            return "Data de início: " + getInicio().ToString() + "\n"
                + "Data de fim: " + (this.Fim.HasValue ? getFim().ToString() : "Ainda não ocorreu");
        }

        public Locação() { }
        public Locação(DateTime inicio, Histórico hist, Funcionário func, Cliente cliente)
        {
            this.inicio = inicio;
            this.Inicio = inicio.ToBinary();
            this.Histórico = hist;
            this.Funcionário = func;
            this.Cliente = cliente;
        }
        public Locação(DateTime inicio, DateTime fim, Histórico hist, Funcionário func, Cliente cliente)
        {
            this.inicio = inicio;
            this.Inicio = inicio.ToBinary();
            this.fim = fim;
            this.Fim = fim.ToBinary();
            this.Histórico = hist;
            this.Funcionário = func;
            this.Cliente = cliente;
        }
        public Locação(int anoInicio, int mesInicio, int diaInicio, int horaInicio, int minutoInicio, int segundoInicio, int anoFim, int mesFim, int diaFim, int horaFim, int minutoFim, int segundoFim, Histórico hist, Funcionário func, Cliente cliente) 
        {
            this.inicio = new DateTime(anoInicio, mesInicio, diaInicio, horaInicio, minutoInicio, segundoInicio);
            this.fim = new DateTime(anoFim, mesFim, diaFim, horaFim, minutoFim, segundoInicio); ;
            this.Histórico = hist;
            this.Funcionário = func;
            this.Cliente = cliente;
        }

    }
}
