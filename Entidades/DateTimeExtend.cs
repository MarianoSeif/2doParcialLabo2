using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    //Metodos de extension para la clase Datetime
    public static class DateTimeExtend
    {
        /// <summary>
        /// Metodo de extension para la clase DateTime. Devuelve una cadena con fecha y hora
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static string LogFormatedDateTime(this DateTime fecha)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(fecha.Date.ToShortDateString());
            sb.Append(" - ");
            sb.Append(fecha.ToString("HH:mm:ss"));
            sb.Append(" - ");
            return sb.ToString();
        }

        /// <summary>
        /// Metodo de extension para la clase DateTime. Devuelve una cadena formateada con la fecha
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static string LogFileName(this DateTime fecha)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(fecha.Day.ToString());
            sb.Append("-");
            sb.Append(fecha.Month.ToString());
            sb.Append("-");
            sb.Append(fecha.Year.ToString());
            sb.Append(".txt");
            return sb.ToString();
        }
    }
}
