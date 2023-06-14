using Damas;
using NUnit.Framework;

namespace DMA.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInicializacaoTabuleiro()
        {
            TabuleiroDamas tabuleiro = new TabuleiroDamas();

            // Verifica se todas as pe�as foram inicializadas corretamente
            List<Piece> pieces = tabuleiro.GetPieces();
            foreach (Piece piece in pieces)
            {
                Assert.IsNotNull(piece);
                // Adicione aqui outras verifica��es necess�rias para cada pe�a
            }
        }
    }
}
