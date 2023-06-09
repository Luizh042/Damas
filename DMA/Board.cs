namespace Damas {

    public class Board {

        private Piece[,] pieces;
        private int size;

        public Board(int size) {

            this.size = size;
            pieces = new Piece[size, size];
        }

        public int Size => size;

        public Piece GetPiece(int x, int y) {

            if (IsValidPosition(x, y))
                return pieces[x, y];
            else
                return null;
        }

        public void SetPiece(int x, int y, Piece piece) {

            if (IsValidPosition(x, y))
                pieces[x, y] = piece;
        }

        public void RemovePiece(int x, int y) {

            if (IsValidPosition(x, y))
                pieces[x, y] = null;
        }

        public bool IsValidPosition(int x, int y) {

            return x >= 0 && x < size && y >= 0 && y < size;
        }
    }
}
