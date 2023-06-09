using System;

namespace Damas
{

    class Program
    {

        static void Main(string[] args)
        {

            // Crie uma instância do seu jogo de damas e inicie o jogo
            TabuleiroDamas game = new TabuleiroDamas();
            game.Start();

            // Mantém o console aberto até que o jogo seja encerrado
            Console.ReadLine();
        }
    }
}
