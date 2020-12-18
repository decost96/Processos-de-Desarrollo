using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatematicasFramework.Test
{
    [TestClass]
    public class CuandoPrueboCalculadora
    {
        private TestContext testContextInstance;
        public TestContext TesContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroPositivoObtengoUnPositivo() 
        {
            var numero = 25;
            var esperado = 5;

            var calculadora = new Calculadora();
            var resultado = calculadora.RaizCuadrada(numero);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void SacoRaizCuadradaDeUnNumeroNegativoObtengoUnNegativoSeDisparaArgumentException()
        {
            var numero = -25;
           

            var calculadora = new Calculadora();
           

            Assert.ThrowsException<ArgumentException>(() => calculadora.RaizCuadrada(numero));
        }

    }
}
