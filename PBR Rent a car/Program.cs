using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBR_Rent_a_car
{
    public static class Program
    {
        public static List<Reserva> reservas= new List<Reserva>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Relatório.singleton().teste();
            using (var ctx = new DadosContainer())
            {
                var histSet = ctx.VeículoSet.Select(v => v.Histórico).ToList();
                foreach (Histórico h in histSet)
                {
                    Console.WriteLine("Histórico");
                    Console.WriteLine(h.Id);
                    var locs = h.Locação.ToList();
                    var mans = h.Manutenção.ToList();
                    foreach (Locação l in locs) Console.WriteLine(l.ToString());
                    foreach (Manutenção m in mans) Console.WriteLine(m.ToString());    
                }
            }
            Application.Run(new CadastroLogin());
        }
    }
}
