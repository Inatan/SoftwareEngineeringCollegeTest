using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBR_Rent_a_car
{
    public partial class Manutenção
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

        public Manutenção() { }
        public Manutenção(DateTime inicio, string motivo, Funcionário func, Histórico hist)
        {
            this.inicio = inicio;
            this.Inicio = inicio.ToBinary();
            this.Motivo = motivo;
            this.Funcionário = func;
            this.Histórico = hist;
        }
        public Manutenção(DateTime inicio, DateTime fim, string motivo, Funcionário func, Histórico hist)
        {
            this.inicio = inicio;
            this.Inicio = inicio.ToBinary();
            this.fim = fim;
            this.Fim = fim.ToBinary();
            this.Motivo = motivo;
            this.Funcionário = func;
            this.Histórico = hist;
        }
        public Manutenção(int anoInicio, int mesInicio, int diaInicio, int horaInicio, int minutoInicio, int segundoInicio, int anoFim, int mesFim, int diaFim, int horaFim, int minutoFim, int segundoFim, string motivo, Funcionário func, Histórico hist) 
        { 
            this.inicio = new DateTime(anoInicio,mesInicio,diaInicio,horaInicio,minutoInicio,segundoInicio);
            this.Inicio = this.inicio.ToBinary();
            this.fim = new DateTime(anoFim,mesFim,diaFim,horaFim,minutoFim,segundoInicio);
            this.Fim = this.fim.ToBinary();
            this.Motivo = motivo;
            this.Funcionário = func;
            this.Histórico = hist;
        }
    }
}
