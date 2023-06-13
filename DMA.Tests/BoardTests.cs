using System;

namespace Damas;

// Classe de teste
public class TestsBoard
{
    Board _board;
    [SetUp]
    public void SetUp()
    {
        _board = new Board(8);
    }

    [Test]
    public void TestBoardSize()
    {
        Assert.AreEqual(8, _board.SizeSide);
    }

    [Test]
    public void TestPiece_2_2() {
        Piece piece = new Piece(PieceColor.White);
        _board.SetPiece(2, 2, piece);
        Assert.AreEqual(piece, _board.GetPiece(2, 2));
    }
    public void TestBoard_Piece_2_2_empty() {
        Assert.IsNull(_board.GetPiece(2, 2));
    }
}
