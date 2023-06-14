using Damas;
using NUnit.Framework;

namespace Damas.Tests
{
    [TestFixture]
    public class TabuleiroDamasTests
    {
        [SetUp]
        public void SetUp()
        {
            // Cria��o do Receiver e do Board
            Board board = new Board(8);
            Receiver receiver = new Receiver(board);

            // Cria��o dos comandos
            ICommand command1 = new MovePieceCommand(receiver, 0, 0, 1, 1);
            ICommand command2 = new CapturePieceCommand(receiver, 2, 2, 3, 3);
            ICommand command3 = new PromoteToDamaCommand(receiver, 4, 4);
            ICommand command4 = new JumpCommand(receiver, 5, 5, 6, 6);
            ICommand command5 = new MoveDamaCommand(receiver, 7, 7, 6, 6);

            // Cria��o do Invoker
            Invoker invoker = new Invoker();

            // Testando sequ�ncia de comandos
            invoker.SetCommand(command1);
            invoker.Invoke();

            invoker.SetCommand(command2);
            invoker.Invoke();

            invoker.SetCommand(command3);
            invoker.Invoke();

            invoker.SetCommand(command4);
            invoker.Invoke();

            invoker.SetCommand(command5);
            invoker.Invoke();
        }

        [Test]
        public void TesteTabuleiroDamas()
        {
            // Cria��o do tabuleiro de damas
            Board tabuleiro = new Board(8);

            // Teste para verificar o tamanho do tabuleiro
            Assert.AreEqual(8, tabuleiro.Size);

            // Teste para verificar que todas as posi��es iniciais est�o vazias
            for (int row = 0; row < tabuleiro.Size; row++)
            {
                for (int col = 0; col < tabuleiro.Size; col++)
                {
                    Assert.IsNull(tabuleiro.GetPiece(row, col));
                }
            }

            // Teste para verificar a configura��o inicial das pe�as
            tabuleiro.SetInitialPieces();

            // Teste para verificar se as pe�as foram colocadas corretamente
            Assert.IsNotNull(tabuleiro.GetPiece(0, 1));
            Assert.IsNotNull(tabuleiro.GetPiece(1, 0));
            // ... verifique outras posi��es iniciais de pe�as

            // Teste para verificar a remo��o de uma pe�a do tabuleiro
            tabuleiro.RemovePiece(0, 1);
            Assert.IsNull(tabuleiro.GetPiece(0, 1));
        }
    }
}
