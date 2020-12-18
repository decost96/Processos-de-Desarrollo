using System;

namespace Matematica.Logica
{
    public class Calculadora
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;

        }

        public float Dividir(float dividiendo, float divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException();

            return dividiendo / divisor;

        }

        public double TomarDosDecimales(double numeroConDecimales)
        {
            var numeroPaso1 = MoverLaComaALaDerecha2Veces(numeroConDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda2Veces(numeroPaso2);
            return numeroPaso3;
        }

        private double MoverLaComaALaDerecha2Veces(double numeroConDecimales)
        {
            return numeroConDecimales * 100;
        }

        private double TomarParteEntera(double numeroConDecimales)
        {
            return Math.Truncate(numeroConDecimales);
        }

        private double MoverLaComaALaIzquierda2Veces(double numero)
        {
            return numero / 100;
        }

        public double TomarTresDecimales(double numero)
        {
            var numeroPaso1 = MoverLaComaALaDerecha3Veces(numero);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda3Veces(numeroPaso2);
            return numeroPaso3;
        }

        private double MoverLaComaALaDerecha3Veces(double numero)
        {
            return numero * 1000;
        }

        private double MoverLaComaALaIzquierda3Veces(double numero)
        {
            return numero / 1000;
        }

        public double TomarDecimales(double numero, int numeroDeDecimales)
        {
            var numeroPaso1 = MoverLaComaALaDerecha(numero, numeroDeDecimales);
            var numeroPaso2 = TomarParteEntera(numeroPaso1);
            var numeroPaso3 = MoverLaComaALaIzquierda(numero, numeroDeDecimales);
            return numeroPaso3;
        }

        public double MoverLaComaALaIzquierda(double numero,  int numeroDeDecimales)
        {
            return numero / Math.Pow(10, numeroDeDecimales);
        }

        public double MoverLaComaALaDerecha(double numero, int numeroDeDecimales)
        {
            return numero * Math.Pow(10, numeroDeDecimales);
        }

        public double RedondearAEntero(double numeroDecimal, int numeroEntero)
        {
            return Math.Round(numeroDecimal);
        }

        public int AumentarEntero(int numeroEntero1, int numeroEntero2)
        {
            var suma = 0;
            for (var i=0; i<100; i++)
            {
                suma++;
            }
            return suma;
        }
    }
}
