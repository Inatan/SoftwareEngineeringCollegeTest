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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new Interface()); 
=======
            Application.Run(new CadastroLogin()); 
>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======
            Application.Run(new CadastroLogin()); 
>>>>>>> 85802f8c8151e268285bbbb67c44f7ad88b3384b
=======
            Application.Run(new Interface()); 
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
=======
            Application.Run(new Interface()); 
>>>>>>> f4525a2cb45744424d6bb856ffc06eaa25e5f24b
        }
    }
}
