using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace HuffmanCodingAlgoritmo
{
    [TestClass]
    public class HuffmanCodingAlgoritmo
    {
        [TestMethod]
        public void CuandoAplicoHuffmanObtengoUnaCadeDeCeroYUnos()
        {
            var cadenaSinComprimir = "EXTENUANTE";
            var tama�oInicial = cadenaSinComprimir.Length * sizeof(char);

            var compresor = new Compresor();
            BitArray CadenaComprimida = compresor.Huffman(cadenaSinComprimir);

            Assert.IsNotNull(CadenaComprimida);
            Assert.IsTrue(CadenaComprimida.Length< tama�oInicial);
        }
    }
}
