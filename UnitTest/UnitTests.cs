using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSerializador()
        {
            //Arrange
            Cliente cliente = new Cliente("Pepe Peposo", "Quintana 555");
            //Act
            Serializador<Cliente>.Guardar("unArchivo.xml", cliente);
            //Assert
            Assert.IsTrue(File.Exists("unArchivo.xml"));
        }

        [TestMethod]
        public void TestLog()
        {
            //Arrange
            string archivo = "C:\\Users\\ms\\source\\repos\\Seif.Mariano.2doParcial_Labo2\\UnitTest\\bin\\Debug\\" + "Log_" + DateTime.Today.LogFileName();
            Cliente cliente = new Cliente("Pepe Peposo", "Quintana 555");
            Pedido pedido = new Pedido(666, cliente, false);
            //Act
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            long size1 = fs.Length;
            fs.Close();
            pedido.DejarRegistroEnLog();
            FileStream fs2 = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            long size2 = fs2.Length;
            fs2.Close();
            //Assert
            Assert.AreNotEqual(size1, size2);
        }

        [TestMethod]
        public void TestTickeador()
        {
            //Arrange
            Cliente cliente = new Cliente("Pepe Peposo", "Quintana 555");
            Pedido pedido = new Pedido(666, cliente, false);
            string archivo = "C:\\Users\\ms\\source\\repos\\Seif.Mariano.2doParcial_Labo2\\UnitTest\\bin\\Debug\\Pedido_" + pedido.Id.ToString() + "_" + DateTime.Today.LogFileName();
            //Act
            Tickeador.GenerarTicket(pedido);
            //Assert
            Assert.IsTrue(File.Exists(archivo));
        }
    }
}
