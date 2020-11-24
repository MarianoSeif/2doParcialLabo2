using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Entidades
{
    public static class DB
    {
        const string STRINGCONNEC = "Data Source = .\\SQLEXPRESS;Initial Catalog = SeifMariano2D2doParcial; Integrated Security = True;";

        static SqlConnection sqlConn;
        static SqlCommand command;

        static DB()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = STRINGCONNEC;
            command = new SqlCommand();
            command.Connection = sqlConn;
        }

        /// <summary>
        /// Guarda un objeto de la clase pedido en la base de datos
        /// </summary>
        public static void GuardarPedido(Pedido pedido)
        {
            string consulta = "insert into pedidos output INSERTED.ID values (@idCliente, @estado, @delivery)";
            string consulta2 = "insert into itemspedidos output INSERTED.ID values (@idPedido, @producto, @cantidad)";

            command.CommandText = consulta;
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@idCliente", pedido.Cliente.Id));
            command.Parameters.Add(new SqlParameter("@estado", (int)pedido.Estado));
            command.Parameters.Add(new SqlParameter("@delivery", pedido.Delivery));

            try
            {
                if (sqlConn.State != System.Data.ConnectionState.Open)
                    sqlConn.Open();
                int id = (int)command.ExecuteScalar();
                pedido.Id = id;

                command.CommandText = consulta2;
                foreach (ItemPedido item in pedido.Items)
                {
                    item.IdPedido = id;
                    command.Parameters.Clear();
                    command.Parameters.Add(new SqlParameter("@idPedido", id));
                    command.Parameters.Add(new SqlParameter("@producto", item.Producto));
                    command.Parameters.Add(new SqlParameter("@cantidad", item.Cantidad));

                    int idItem = (int)command.ExecuteScalar();
                    item.Id = idItem;
                }
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (sqlConn.State != System.Data.ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
        }

        /// <summary>
        /// Actualiza el estado del pedido en la base de datos
        /// </summary>
        public static bool ActualizarEstadoPedido(Pedido pedido)
        {
            string consulta = "update pedidos set estado = @estado where id = @id";

            command.CommandText = consulta;
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@estado", (int)pedido.Estado));
            command.Parameters.Add(new SqlParameter("@id", pedido.Id));

            try
            {
                if (sqlConn.State != System.Data.ConnectionState.Open)
                    sqlConn.Open();
                int retorno = command.ExecuteNonQuery();
                return retorno == 1;
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (sqlConn.State != System.Data.ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
        }

        /// <summary>
        /// Arma una lista de pedidos con los datos traidos de la base de datos
        /// </summary>
        /// <returns></returns>
        public static Queue<Pedido> TraerPedidos()
        {
            Queue<Pedido> pedidos = new Queue<Pedido>();

            command.CommandText = "select * from pedidos where estado = @estado";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@estado", (int)EEstadoPedido.pendiente));

            try
            {
                if (sqlConn.State != System.Data.ConnectionState.Open)
                {
                    sqlConn.Open();
                }

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Pedido pedido = new Pedido(
                        int.Parse(dataReader["id"].ToString()),
                        FastFood.BuscarClientePorId(int.Parse(dataReader["idCliente"].ToString())),
                        (bool)dataReader["delivery"]
                    );
                    pedidos.Enqueue(pedido);
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (sqlConn.State != System.Data.ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
        }

        /// <summary>
        /// Arma una lista de clientes con los datos traidos de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> TraerClientes()
        {
            string consulta = "select * from clientes";
            List<Cliente> clientes = new List<Cliente>();
            
            try
            {
                command.CommandText = consulta;

                if (sqlConn.State != System.Data.ConnectionState.Open)
                {
                    sqlConn.Open();
                }

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    clientes.Add(new Cliente(
                        int.Parse(dataReader["id"].ToString()),
                        dataReader["nombre"].ToString(),
                        dataReader["domicilio"].ToString()
                    ));
                }
                return clientes;
            }
            catch (Exception ex)
            {
                throw new DatabaseException(ex);
            }
            finally
            {
                if (sqlConn.State != System.Data.ConnectionState.Closed)
                {
                    sqlConn.Close();
                }
            }
        }
    }
}
