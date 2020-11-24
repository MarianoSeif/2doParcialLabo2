using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Seif.Mariano._2doParcial_Labo2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormCartelera());
            }
            catch (Exception e)
            {
                Logger.RegistrarEvento(e);
                Console.WriteLine("Error inesperado");
            }            
        }
    }
}
