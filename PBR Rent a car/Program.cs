﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBR_Rent_a_car
{
    public static class Program
    {
        public static List<Cliente> clientes= new List<Cliente>();
        public static List<Reserva> reservas= new List<Reserva>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InterfaceCliente()); 
        }
    }
}
