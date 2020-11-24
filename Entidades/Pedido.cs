using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void NotifierDelegate(Pedido pedido);
    public enum EEstadoPedido
    {
        ingresado,
        pendiente,
        listo,
        delivery,
        entregado
    }
    public class Pedido : IRegistrarse
    {
        public event NotifierDelegate cambioEstadoEvent;
        private int id;
        private bool delivery;
        private Cliente cliente;
        private EEstadoPedido estado;
        private List<ItemPedido> items;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public EEstadoPedido Estado
        {
            get { return estado; }
            set { 
                estado = value;
                if(estado == EEstadoPedido.listo || estado == EEstadoPedido.delivery)
                {
                    cambioEstadoEvent.Invoke(this);
                }
            }
        }

        public List<ItemPedido> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        public bool Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }

        [System.ComponentModel.Browsable(false)]
        public string Mensaje
        {
            get
            {
                return "Se creó un nuevo pedido";
            }
        }
        public Pedido()
        {
            this.estado = EEstadoPedido.pendiente;
            this.items = new List<ItemPedido>();
            this.DejarRegistroEnLog();
        }

        public Pedido(Cliente cliente, bool delivery):this()
        {
            this.cliente = cliente;
            this.delivery = delivery;
        }
        
        public Pedido(Cliente cliente, bool delivery, List<ItemPedido> items) : this(cliente, delivery)
        {
            this.items = items;
        }

        public Pedido(int id, Cliente cliente, bool delivery) : this(cliente, delivery)
        {
            this.id = id;
        }

        public void DejarRegistroEnLog()
        {
            Logger.RegistrarEvento<Pedido>(this, "Se creó un nuevo pedido");
        }
    }
}
