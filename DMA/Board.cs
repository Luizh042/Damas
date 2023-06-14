namespace Damas
{

    /*
        Tabuleiro do jogo de damas.
    */
    public class Board
    {

        private Piece[,] pieces;
        private int sizeSide;

        public Board(int sizeSide)
        {

            this.sizeSide = sizeSide;
            pieces = new Piece[sizeSide, sizeSide];
        }

        public int SizeSide
        {
            get
            {
                return sizeSide;
            }
        }

        public Piece GetPiece(int x, int y)
        {
            return pieces[x, y];
        }

        public void SetPiece(int x, int y, Piece piece)
        {
            pieces[x, y] = piece;
        }

        public void RemovePiece(int x, int y)
        {
            pieces[x, y] = null;
        }
    }
}