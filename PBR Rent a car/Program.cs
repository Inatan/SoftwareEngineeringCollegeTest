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
            using (var ctx = new DadosContainer())
            {
                Console.WriteLine(ctx.ClienteSet.ToList().Count);
                Console.WriteLine(ctx.LoginSet.ToList().Count);
            }
            Application.Run(new CadastroLogin()); 
        }
    }
}
