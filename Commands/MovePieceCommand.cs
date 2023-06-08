namespace Damas;

public interface MovePieceCommand : ICommand {

    private Board board;
    private Piece piece;
    private Position targetPosition;
    private Position previosPossition;

    public MovePieceCommand(Board board, Piece piece, Position targetPosition) {

        this.board = board;
        this.piece = piece;
        this.targetPosition = targetPosition;
    }

    public void Execute() {

        previosPossition = piece.Position;
        board.MovePiece(piece, targetPosition);
    }

    public void Undo() {

        board.MovePiece(piece, targetPosition);
    }
}