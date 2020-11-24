using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    //Clase estática que maneja el negocio
    public static class FastFood
    {
        public static event NotifierDelegate pedidoCambioDeEstadoEvent;
        private static Random random;
        public static Queue<Pedido> listaPedidos;
        public static List<Cliente> listaClientes;
        public static Stack<Pedido> listaTerminados;
        public static Queue<Pedido> listaDelivery;
        

        static FastFood()
        {
            random = new Random();
            listaTerminados = new Stack<Pedido>();
            listaDelivery = new Queue<Pedido>();
            try
            {
                listaClientes = DB.TraerClientes();
                FastFood.TraerPedidos();
            }
            catch (Exception e)
            {
                throw new Exception("Error al cargar los datos del negocio - " + e.Message, e);
            }
        }

        /// <summary>
        /// Genera una venta con datos al azar (ya existentes, traidos de la base de datos)
        /// </summary>
        public static void GenerarPedido()
        {
            bool delivery = random.Next(1, 10) <= 5 ? true : false;
            int cantItems = random.Next(1, 4);
            Cliente cliente = listaClientes[random.Next(0, (listaClientes.Count) - 1)];
            List<ItemPedido> items = new List<ItemPedido>();

            for (int i = 0; i < cantItems; i++)
            {
                int cantCadaProducto = random.Next(1, 3);
                int indiceProducto = random.Next(0, CargarDatos.listaProductos.Count);
                items.Add(new ItemPedido(CargarDatos.listaProductos[indiceProducto], cantCadaProducto));
            }
            try
            {
                Pedido pedido = new Pedido(cliente, delivery, items);
                pedido.cambioEstadoEvent += AvisarAlFormCambioDeEstado;
                listaPedidos.Enqueue(pedido);
                
                DB.GuardarPedido(pedido);
                pedido.DejarRegistroEnLog();
            }
            catch (Exception e)
            {
                throw new Exception("Error al generar la venta - " + e.Message, e);
            }
        }

        public static void ProcesarPedido()
        {
            Pedido pedido = listaPedidos.Dequeue();
            if (pedido.Delivery)
            {
                Tickeador.GenerarTicket(pedido);
                pedido.Estado = EEstadoPedido.delivery;
                //DB.ActualizarEstadoPedido(pedido);
            }
            else
            {
                pedido.Estado = EEstadoPedido.listo;
                //DB.ActualizarEstadoPedido(pedido);
            }
            
            listaTerminados.Push(pedido);
            int milisegundos = random.Next(5, 7) * 1000;
            Thread.Sleep(milisegundos);
        }

        public static Cliente BuscarClientePorId(int id)
        {
            foreach (Cliente item in listaClientes)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static void AvisarAlFormCambioDeEstado(Pedido pedido)
        {
            if(pedido.Estado == EEstadoPedido.delivery)
            {
                listaDelivery.Enqueue(pedido);
            }
            else
            {
                pedidoCambioDeEstadoEvent.Invoke(pedido);
            }
        }

        public static void Delivery()
        {
            if(listaDelivery.Count > 0)
            {
                Pedido pedido = listaDelivery.Dequeue();
                pedido.Estado = EEstadoPedido.entregado;
            }
            Thread.Sleep(random.Next(8, 12) * 1000);
        }

        private static void TraerPedidos()
        {
            //listaPedidos = DB.TraerPedidos();
            List<Pedido> tempListaPedidos = new List<Pedido>();
            Serializador<List<Pedido>>.Leer("pedidos_pendientes.xml", out tempListaPedidos);
            listaPedidos = new Queue<Pedido>(tempListaPedidos);
            foreach (Pedido pedido in listaPedidos)
            {
                pedido.cambioEstadoEvent += FastFood.AvisarAlFormCambioDeEstado;
            }
        }
    }
}
