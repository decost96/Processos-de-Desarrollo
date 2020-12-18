using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Logica;
using System;


namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SumaDosNumeros()
        {
            // Arrange -> Preparacion
            var numero1 = 7;
            var numero2 = 10;
            var esperado = 17;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultadoObtenido = calculadora.Sumar(numero1, numero2);

            // assert -> Verificación
            Assert.AreEqual(esperado, resultadoObtenido);

        }

        [TestMethod]
        public void DivisionDosNumeros()
        {
            // Arrange -> Preparacion
            var numero1 = 10;
            var numero2 = 5;
            var esperado = 2;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultadoObtenido = calculadora.Dividir(numero1, numero2);

            // assert -> Verificación
            Assert.AreEqual(esperado, resultadoObtenido);

        }

        [TestMethod]
        public void DivisionDe0() 
        { 
            // Arrange -> Preparacion
            var numero1 = 0;
            var numero2 = 5;
            var esperado = 0;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultadoObtenido = calculadora.Dividir(numero1, numero2);

            // assert -> Verificación
            Assert.AreEqual(esperado, resultadoObtenido);

        }

        [TestMethod]
        public void DivisionDecimal()
        {
            // Arrange -> Preparacion
            var numero1 = 8;
            var numero2 = 5;
            var esperado = 1.600000023841858;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultadoObtenido = calculadora.Dividir(numero1, numero2);

            // assert -> Verificación
            Assert.AreEqual(esperado, resultadoObtenido);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionPor0()
        {
            // Arrange -> Preparacion
            var dividiendo = 50;
            var divisor = 0;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(dividiendo, divisor);

            // assert -> Verificación
           // Assert.IsTrue(float.IsInfinity(resultado));

        }

        [TestMethod]
        public void ObtenerUnNumeroConDosDecimal()
        {
            // Arrange -> Preparacion
            var numeroPiCon5Decimales = 3.14159;
            var numeroPiCon2Decimales = 3.14;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDosDecimales(numeroPiCon5Decimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon2Decimales, resultado);

        }

        [TestMethod]
        public void ObtenerUnNumeroCon3Decimal()
        {
            // Arrange -> Preparacion
            var numeroPiConDecimales = 3.141592653589793238462643383;
            var numeroPiCon3Decimales = 3.141;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarTresDecimales(numeroPiConDecimales);

            // assert -> Verificación
            Assert.AreEqual(numeroPiCon3Decimales, resultado);

        }

        [TestMethod]
        public void ObtenerNumeroConXDecimales()
        {
            // Arrange -> Preparacion
            var numeroAuero = 3.141592653589793238462643383;
            var numeroDeDecimales = 5;
            var esperado = 3.14159;

            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.TomarDecimales(numeroAuero, numeroDeDecimales);

            // assert -> Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod]
        public void ObtenertNumeroRedondeado()
        {
            // Arrange -> Preparacion
            var numeroDecimal = 4.6;
            var numeroEntero = 5;


            // act -> Esta la parte de Ejecución 
            var calculadora = new Calculadora();
            var resultado = calculadora.RedondearAEntero(numeroDecimal, numeroEntero);

            // assert -> Verificación
            Assert.AreEqual(numeroEntero, resultado);

        }
        [TestMethod]
        public void AumentarEntero()
        {
            var numeroEntero1 = 9;
            //int x = Convert.ToInt32(TestContext.DataRow["FirstNumber"]);
            var numeroEntero2 = 8;
            //int y = Convert.ToInt32(TestContext.DataRow["SecondNumber"]);
            var esperado = 17;

            var calculadora = new Calculadora();
            int resultado = calculadora.AumentarEntero(numeroEntero1, numeroEntero2);

            Assert.AreEqual(esperado, resultado);
        }
    }
}


