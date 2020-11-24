using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : IRegistrarse
    {
        private int id;
        private string nombre;
        private string domicilio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        [System.ComponentModel.Browsable(false)]
        public string Mensaje
        {
            get
            {
                return "Se creó un nuevo cliente: "+this.nombre;
            }
        }

        public Cliente()
        {
            DejarRegistroEnLog();
        }

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        public Cliente(string nombre, string domicilio):this(nombre)
        {
            this.domicilio = domicilio;
        }

        public Cliente(int id, string nombre, string domicilio) : this(nombre, domicilio)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public void DejarRegistroEnLog()
        {
            Logger.RegistrarEvento<Cliente>(this, "Se creó un nuevo cliente: " + this.nombre);
        }
    }
}
