using System;

namespace Damas
{

    class Program
    {

        static void Main(string[] args)
        {

            // Crie uma inst�ncia do seu jogo de damas e inicie o jogo
            TabuleiroDamas game = new TabuleiroDamas();
            game.Start();

            // Mant�m o console aberto at� que o jogo seja encerrado
            Console.ReadLine();
        }
    }
}
