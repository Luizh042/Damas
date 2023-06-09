namespace Damas {

    public class Move {

        public int SourceX { get; set; }
        public int SourceY { get; set; }
        public int DestinationX { get; set; }
        public int DestinationY { get; set; }
        public Piece Piece { get; set; }

        public Move(int sourceX, int sourceY, int destinationX, int destinationY, Piece piece) {

            SourceX = sourceX;
            SourceY = sourceY;
            DestinationX = destinationX;
            DestinationY = destinationY;
            Piece = piece;
        }
    }
}