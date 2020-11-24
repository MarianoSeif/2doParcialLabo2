using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
using System.Media;

namespace Seif.Mariano._2doParcial_Labo2
{
    public partial class FormCartelera : Form
    {
        List<Thread> listaHilos;
        int cantVentas;
        public FormCartelera()
        {
            InitializeComponent();
            cantVentas = 0;
        }
        private void FormCartelera_Load(object sender, EventArgs e)
        {
            try
            {
                this.DoubleBuffered = true;
                this.dtgPedidos.DataSource = null;
                this.dtgPedidos.DataSource = FastFood.listaPedidos.ToList();
                this.lblPedidoListo.Text = "";

                FastFood.pedidoCambioDeEstadoEvent += this.InformarPedidoListo;

                //Se crean y se inician los hilos
                listaHilos = new List<Thread>();
                listaHilos.Add(new Thread(this.RefrescarDatagrids));
                listaHilos.Add(new Thread(this.GenerarPedido));
                listaHilos.Add(new Thread(this.ProcesarPedido));
                listaHilos.Add(new Thread(this.DeliveryBoy));

                foreach (Thread hilo in listaHilos)
                {
                    hilo.Start();
                }
            }
            catch (Exception ex)
            {
                Logger.RegistrarEvento(ex);
                MessageBox.Show("Pasaron cosas...: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void FormCartelera_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (Thread hilo in listaHilos)
                {
                    if (hilo.IsAlive)
                    {
                        hilo.Abort();
                    }
                }

                foreach (Pedido pedido in FastFood.listaTerminados)
                {
                    DB.ActualizarEstadoPedido(pedido);
                }
                Serializador<List<Pedido>>.Guardar("pedidos_pendientes.xml", FastFood.listaPedidos.ToList());
                MessageBox.Show("Un saludo a 2do C", "Bye", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarDatagrids()
        {
            try
            {
                if (this.dtgPedidos.InvokeRequired)
                {
                    this.dtgPedidos.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.dtgPedidos.DataSource = null;
                        this.dtgPedidos.DataSource = FastFood.listaPedidos.ToList();
                    });
                }
                else
                {
                    this.dtgPedidos.DataSource = null;
                    this.dtgPedidos.DataSource = FastFood.listaPedidos.ToList();
                }

                if (this.dtgTerminados.InvokeRequired)
                {
                    this.dtgTerminados.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.dtgTerminados.DataSource = null;
                        this.dtgTerminados.DataSource = FastFood.listaTerminados.ToList();
                    });
                }
                else
                {
                    this.dtgTerminados.DataSource = null;
                    this.dtgTerminados.DataSource = FastFood.listaTerminados.ToList();
                }

                Thread.Sleep(1500);
                RefrescarDatagrids();
            }
            catch (ThreadAbortException ex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarPedido()
        {
            try
            {
                FastFood.GenerarPedido();
                cantVentas++;
                Thread.Sleep(5000);
                if (cantVentas < 20)
                {
                    this.GenerarPedido();
                }
            }
            catch (ThreadAbortException ex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcesarPedido()
        {
            try
            {
                if (FastFood.listaPedidos.Count > 0)
                {
                    FastFood.ProcesarPedido();
                }
                ProcesarPedido();
            }
            catch (ThreadAbortException ex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeliveryBoy()
        {
            try
            {
                FastFood.Delivery();
                DeliveryBoy();
            }
            catch (ThreadAbortException ex)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            FastFood.GenerarPedido();
        }

        private void btnProcesarPedido_Click(object sender, EventArgs e)
        {
            FastFood.ProcesarPedido();
        }

        private void InformarPedidoListo(Pedido pedido)
        {
            this.lblPedidoListo.Text = $"{pedido.Cliente} ya puede retirar su pedido";
            SystemSounds.Hand.Play();
        }
    }
}