using Microsoft.VisualStudio.TestTools.UnitTesting;

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
				var resultadoObtenido = sumar(numero1, numero2);

				// assert -> verificación
				Assert.AreEquals(esperado, resultadoObtenido);
				
			}

			public int Sumar(int sumando1, int sumando2)
			{
			return sumando1 + sumando2;
			
			}
			
		}

}