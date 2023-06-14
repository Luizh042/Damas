using NUnit.Framework;
using Damas;
using Receiver;

namespace Damas.Tests
{
    public class MovePieceCommandTests
    {
        [Test]
        public void Execute_ShouldMovePieceToTargetPosition()
        {
            // Arrange
            Receiver receiver = new Receiver();
            Position startPosition = new Position(2, 2);
            Position targetPosition = new Position(3, 3);
            Piece piece = new Piece();

            receiver.SetPiece(startPosition, piece);
            ICommand movePieceCommand = new MovePieceCommand(receiver, startPosition, targetPosition);

            // Act
            movePieceCommand.Execute();

            // Assert
            Assert.IsNull(receiver.GetPiece(startPosition));
            Assert.AreEqual(piece, receiver.GetPiece(targetPosition));
        }
    }
}
