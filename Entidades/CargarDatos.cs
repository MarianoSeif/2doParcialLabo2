using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CargarDatos
    {
        public static List<string> listaProductos;

        static CargarDatos()
        {
            listaProductos = new List<string>();
            listaProductos.Add("Hamburguesa");
            listaProductos.Add("Papas Fritas");
            listaProductos.Add("Coca");
            listaProductos.Add("Sandwich Mila");
            listaProductos.Add("Ensalada");
            listaProductos.Add("Flan");
            listaProductos.Add("Helado");
            listaProductos.Add("Sprite");
        }
    }
}
