namespace Damas;


//declarando a classe que implementa a interface ICommand
public interface MovePieceCommand : ICommand {

    
    private Board board;//refer�ncia para o tabuleiro para que haja intera��o com o comando
    private Piece piece;//refer�ncia para a pe�a a ser movida
    private Position targetPosition;//posi��o de destino
    private Position previosPossition;//posi��o anterior da pe�a, para desfazer o movimento

    //Construtor da classe e defini��o dos par�metros para cria��o da inst�ncia do comando
    public MovePieceCommand(Board board, Piece piece, Position targetPosition) {

        this.board = board; // Atribui o tabuleiro recebido como par�metro ao atributo "board"
        this.piece = piece; // Atribui a pe�a recebida como par�metro ao atributo "piece"
        this.targetPosition = targetPosition; // Atribui a posi��o de destino recebida como par�metro ao atributo "targetPosition"
    }

    //m�todo
    public void Execute() {

        // Armazena a posi��o anterior da pe�a antes de realizar o movimento
        previosPossition = piece.Position;

        // Move a pe�a para a posi��o de destino no tabuleiro
        board.MovePiece(piece, targetPosition);
    }

    //m�todo
    public void Undo() {

        //move a pe�a de volta ao local de origem
        board.MovePiece(piece, targetPosition);
    }
}