using System;

namespace MatematicasFramework.Test
{
    internal class Calculadora
    {
        public Calculadora()
        {

        }

        public double RaizCuadrada(double numero)
        {
            if (numero < 0)
                throw new ArgumentException("No existe raiz cuadra de un numero negativo");
            return Math.Sqrt(numero);
        }
    }
}