using Damas;
namespace Damas
{

    public class Piece
    {
        public PieceType Type { get; set; }
        public PieceColor Color { get; set; }
        public bool IsDama { get; set; }

        public Piece(PieceType type, PieceColor color)
        {
            Type = type;
            Color = color;
            IsDama = false;
        }

        
    }
}

public enum PieceType
{
    Normal,
    Dama
}

public enum PieceColor
{
    White,
    Black
}
