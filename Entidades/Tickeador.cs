using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Tickeador
    {
        public static bool GenerarTicket(Pedido pedido)
        {
            StringBuilder nombreArchivo = new StringBuilder();
            nombreArchivo.Append("Pedido_");
            nombreArchivo.Append(pedido.Id.ToString());
            nombreArchivo.Append("_");
            nombreArchivo.Append(DateTime.Today.LogFileName());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cliente: " + pedido.Cliente.Nombre);
            sb.AppendLine("Domicilio: " + pedido.Cliente.Domicilio);

            try
            {
                using (StreamWriter fileWriter = new StreamWriter(nombreArchivo.ToString()))
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
    }
}
