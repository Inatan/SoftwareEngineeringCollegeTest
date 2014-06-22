using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GemBox.Document;

namespace PBR_Rent_a_car
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastroLogin());
        }
    }
}
