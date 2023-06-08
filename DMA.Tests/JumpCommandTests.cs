using NUnit.Framework;

namespace Damas;

[TestFixture]
public class JumpCommandTests
{
    [Test]
    public void Execute_WhenJumpCommandExecuted_CapturesPiecesAndMovesJumper()
    {
        // Arrange
        Board board = new Board();
        Piece jumper = new Piece();
        List<Piece> capturedPieces = new List<Piece>();
        Position startPosition = new Position(1, 1);
        Position targetPosition = new Position(3, 3);

        // Add some captured pieces to the board
        Piece capturedPiece1 = new Piece();
        Piece capturedPiece2 = new Piece();
        board.AddPiece(capturedPiece1, new Position(2, 2));
        board.AddPiece(capturedPiece2, new Position(3, 3));

        JumpCommand jumpCommand = new JumpCommand(board, jumper, capturedPieces, startPosition, targetPosition);

        // Act
        jumpCommand.Execute();

        // Assert
        Assert.AreEqual(targetPosition, jumper.Position);
        Assert.IsFalse(board.ContainsPiece(capturedPiece1));
        Assert.IsFalse(board.ContainsPiece(capturedPiece2));
        Assert.AreEqual(0, capturedPieces.Count);
    }

    [Test]
    public void Undo_WhenJumpCommandUndone_ReturnsToPreviousState()
    {
        // Arrange
        Board board = new Board();
        Piece jumper = new Piece();
        List<Piece> capturedPieces = new List<Piece>();
        Position startPosition = new Position(1, 1);
        Position targetPosition = new Position(3, 3);

        // Add some captured pieces to the board
        Piece capturedPiece1 = new Piece();
        Piece capturedPiece2 = new Piece();
        board.AddPiece(capturedPiece1, new Position(2, 2));
        board.AddPiece(capturedPiece2, new Position(3, 3));

        JumpCommand jumpCommand = new JumpCommand(board, jumper, capturedPieces, startPosition, targetPosition);

        // Act
        jumpCommand.Execute();
        jumpCommand.Undo();

        // Assert
        Assert.AreEqual(startPosition, jumper.Position);
        Assert.IsTrue(board.ContainsPiece(capturedPiece1));
        Assert.IsTrue(board.ContainsPiece(capturedPiece2));
        Assert.AreEqual(2, capturedPieces.Count);
    }
}
