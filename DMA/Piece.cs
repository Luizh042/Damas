using Damas;
namespace Damas
{

    public class Piece
    {
        public PieceColor Color { get; set; }
        public Piece(PieceColor color)
        {
            Color = color;
        }
    }
}

public enum PieceColor
{
    White,
    Black
}