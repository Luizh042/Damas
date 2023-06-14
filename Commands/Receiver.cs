using System.Collections.Generic; 

public class Receiver
{
    private Dictionary<Position, Piece> pieces;

    public Receiver()
    {
        pieces = new Dictionary<Position, Piece>();
    }

    public Piece GetPiece(Position position)
    {
        if (pieces.ContainsKey(position))
            return pieces[position];

        return null;
    }

    public void SetPiece(Position position, Piece piece)
    {
        pieces[position] = piece;
    }

    public void MovePiece(Position startPosition, Position targetPosition)
    {
        Piece piece = pieces[startPosition];
        pieces.Remove(startPosition);
        pieces[targetPosition] = piece;
    }
}