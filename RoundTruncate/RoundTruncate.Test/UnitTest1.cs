using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoundTruncate;
using System;

namespace RoundTruncate.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtenerEntero()
        {
            var numeroDecimal = 41.47248;
            var esperado = 41;

            var calculadora = new Calculadora();
            var resultado = calculadora.devolver(numeroDecimal);


            Assert.AreEqual(esperado, resultado);
        }
    }


}
