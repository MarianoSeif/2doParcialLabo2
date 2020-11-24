using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatabaseException : Exception
    {
        public DatabaseException(Exception innerException) : base("Error al escribir en la base de datos - " + innerException.Message, innerException)
        {
        }
    }
}
