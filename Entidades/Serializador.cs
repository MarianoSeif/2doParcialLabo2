using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public static class Serializador<T>
    {
        /// <summary>
        /// Serializa y guarda el objeto pasado por referencia
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool Guardar(T datos)
        {
            string archivo = "pedidos_pendientes.xml";

            if (datos == null)
            {
                throw new Exception("La fuente de datos no es válida");
            }
            else
            {
                try
                {
                    using (XmlTextWriter fileWriter = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        serializer.Serialize(fileWriter, datos);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error de Serializacion " + e.Message, e);
                }
            }
            return true;
        }


        /// <summary>
        /// Lee el archivo y deserializa los objetos
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool Leer(out T datos)
        {
            string archivo = "pedidos_pendientes.xml";
            if (File.Exists(archivo))
            {
                try
                {
                    using (XmlTextReader fileReader = new XmlTextReader(archivo))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        datos = (T)serializer.Deserialize(fileReader);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error de Serializacion", e);
                }
                return true;
            }
            datos = default;
            return false;
        }
    }
}