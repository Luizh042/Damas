namespace DMA.Tests;
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
        string pecas = tabuleiro.GetPecas();

        Assert.AreEqual("vermelho", pecas);
    }
}