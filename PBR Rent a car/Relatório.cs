using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GemBox.Document;

namespace PBR_Rent_a_car
{
    public partial class Relatório
    {
        //--------------Singleton Object Pattern!--------------
        private static Relatório relatório = new Relatório();
        
        private Relatório() 
        {
            using (var ctx = new DadosContainer())
            {
                históricos = ctx.HistóricoSet.ToList();
                foreach (Histórico h in históricos)
                {
                    Histórico.Add(h);
                }
                ctx.SaveChanges();
            }
        }

        public static Relatório singleton()
        {
            return relatório;
        }
        //--------------Fim da implementação do Pattern!--------------

        private List<Histórico> históricos = new List<Histórico>();

        public List<Histórico> getHistóricos()
        {
            this.históricos = Histórico.ToList();
            return this.históricos;
        }

        public void teste()
        {
            using (var ctx = new DadosContainer())
            {
                ctx.Attach(this);
                var hs = Histórico.ToList();
                Console.WriteLine(hs.Count);
                foreach (var h in hs) Console.WriteLine(h.ToString());
            }
        }

        public void gerarRelatório(string option, DateTime data)
        {
            DocumentModel doc = new DocumentModel();
            Section s = new Section(doc);
            doc.Sections.Add(s);
            Paragraph intro = new Paragraph(doc);
            s.Blocks.Add(intro);
            Run introRun = new Run(doc, "Relatório de Veículos, com manutenções e locações, cada uma com suas respectivas datas.");
            intro.Inlines.Add(introRun);
            SpecialCharacter newline = new SpecialCharacter(doc, SpecialCharacterType.LineBreak);
            intro.Inlines.Add(newline);
            newline = newline.Clone();
            introRun = new Run(doc, "Relatório da opção " + option + 
                option == "período" ? "no período dado por " + data.ToString() : "");
            intro.Inlines.Add(introRun);
            using (var ctx = new DadosContainer())
            {
                ctx.Attach(this);
                foreach (Histórico h in getHistóricos())
                {
                    Paragraph p = new Paragraph(doc);
                    s.Blocks.Add(p);
                    List<Locação> locs = h.getLocações().FindAll(l => comparaDatas(option, data, l.getInicio()) ||
                        (l.acabou() && comparaDatas(option, data, l.getFim())));
                    List<Manutenção> mans = h.getManutenções().FindAll(m => comparaDatas(option, data, m.getInicio()) ||
                        (m.acabou() && comparaDatas(option, data, m.getFim())));
                    Run run = new Run(doc, "Veículo " + h.Veículo.Id);
                    p.Inlines.Add(run);
                    p.Inlines.Add(newline);
                    newline = newline.Clone();
                    run = new Run(doc, "Manutenções no período dado");
                    p.Inlines.Add(run);
                    p.Inlines.Add(newline);
                    newline = newline.Clone();
                    List<string> linhas;
                    foreach (Manutenção m in mans)
                    {
                        linhas = m.ToString().Split('\n').ToList();
                        foreach (string linha in linhas)
                        {
                            run = new Run(doc, linha);
                            p.Inlines.Add(run);
                            p.Inlines.Add(newline);
                            newline = newline.Clone();
                        }
                    }
                    run = new Run(doc, "Locações no período dado");
                    p.Inlines.Add(run);
                    p.Inlines.Add(newline);
                    newline = newline.Clone();
                    foreach (Locação l in locs)
                    {
                        linhas = l.ToString().Split('\n').ToList();
                        foreach (string linha in linhas)
                        {
                            run = new Run(doc, linha);
                            p.Inlines.Add(run);
                            p.Inlines.Add(newline);
                            newline = newline.Clone();
                        }
                    }
                }
            }
            doc.Save("relatorio.pdf");    
        }

        private static bool comparaDatas (string option, DateTime restrição, DateTime data)
        {
            switch (option)
            {
                case "dia":
                    return restrição.Day == data.Day;
                case "semana":
                    return restrição.Year == data.Year && restrição.Month == data.Month &&
                        Math.Abs(restrição.Day - data.Day) <= 7;
                case "mes":
                    return restrição.Month == data.Month;
                case "ano":
                    return restrição.Year == data.Year;
                case "período":
                    return restrição.Year == data.Year && restrição.Month == data.Month && restrição.Day == data.Day;
            }
            return false;
        }
        
        public void adicionarHistórico(Histórico h)
        {
            if (históricos == null) históricos = Histórico.ToList();
            históricos.Add(h);
            Histórico.Add(h);    
        }
    }
}
