namespace DMA;

public class TabuleiroDamas
{
    public static void Main(string [] args)
    {}
    private string pecas;

    public TabuleiroDamas()
    {
        InicializarTabuleiro();
    }

    public string GetPecas()
    {
        return pecas;
    }

    private void InicializarTabuleiro()
    {
        pecas = "preto";
    }
}

