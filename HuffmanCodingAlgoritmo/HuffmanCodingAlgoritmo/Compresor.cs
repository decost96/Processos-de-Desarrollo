using System;
using System.Collections;

namespace HuffmanCodingAlgoritmo
{
    internal class Compresor
    {
        public Compresor()
        {

        }

        public BitArray Huffman(string cadenaSinComprimir)
        {
            // crear prueba unit para odernas ascendente, nodo y calcular frecuencia
            var frecuencia = CalcularFrecuencia(cadenaSinComprimir);
            var frecuenciaOrdenada = OrdenarAscendente(frecuencia);
            var arbol = new Nodo():
            
            foreach(var caracter in frecuenciaOrdenada) // remplazar este foreach por una sentania tipo while
                                                        // teniendo encuenta que extraer menor elimina la frecuencia 
            {
                var nuevoNodo = new Nodo();
                nuevoNodo.NodoIzquierdo = ExtraerMenor(frecuenciaOrdenada);
                nuevoNodo.NodoDerecho = ExtraerMenor(frecuenciaOrdenada);

                nuevoNodo.Valor = nuevoNodo.NodoIzquierdo.Valor + nuevoNodo.NodoDerecho.Valor;
                arbol.Insertar(nuevoNodo);            
            }

            return null;

        }

    }
}