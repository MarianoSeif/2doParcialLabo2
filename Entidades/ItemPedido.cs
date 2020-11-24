using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemPedido
    {
        private int id;
        private int idPedido;
        private string producto;
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public ItemPedido()
        {
        }

        public ItemPedido(string producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }
        public ItemPedido(int idPedido, string producto, int cantidad):this(producto, cantidad)
        {
            this.idPedido = idPedido;
        }

    }
}
