using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Logger
    {
        static Logger()
        {
        }

        /// <summary>
        /// Registra un evento en un archivo de log
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public static bool RegistrarEvento<T>(T objeto, string mensaje) where T : IRegistrarse
        {
            string archivo = "Log_" + DateTime.Now.LogFileName();
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.LogFormatedDateTime() + objeto.Mensaje); //Metodo de extensión de la clase DateTime

            try
            {
                using (StreamWriter fileWriter = new StreamWriter(archivo, true))
                {
                    fileWriter.Write(sb.ToString());
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al intentar escribir el archivo de log - " + e.Message, e);
            }
        }

        /// <summary>
        /// Registra una Excepcion en el archivo de log
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool RegistrarEvento(Exception e)
        {
            string archivo = "Log_" + DateTime.Now.LogFileName();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.LogFormatedDateTime() + "Error - " + e.Message); //Metodo de extensión de la clase DateTime

            try
            {
                using (StreamWriter fileWriter = new StreamWriter(archivo, true))
                {
                    fileWriter.Write(sb.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar escribir el archivo de log - " + ex.Message, ex);
            }
        }
    }
}
