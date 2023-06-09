namespace Damas;


//declarando a classe que implementa a interface ICommand
public interface MovePieceCommand : ICommand {

    
    private Board board;//referência para o tabuleiro para que haja interação com o comando
    private Piece piece;//referência para a peça a ser movida
    private Position targetPosition;//posição de destino
    private Position previosPossition;//posição anterior da peça, para desfazer o movimento

    //Construtor da classe e definição dos parâmetros para criação da instância do comando
    public MovePieceCommand(Board board, Piece piece, Position targetPosition) {

        this.board = board; // Atribui o tabuleiro recebido como parâmetro ao atributo "board"
        this.piece = piece; // Atribui a peça recebida como parâmetro ao atributo "piece"
        this.targetPosition = targetPosition; // Atribui a posição de destino recebida como parâmetro ao atributo "targetPosition"
    }

    //método
    public void Execute() {

        // Armazena a posição anterior da peça antes de realizar o movimento
        previosPossition = piece.Position;

        // Move a peça para a posição de destino no tabuleiro
        board.MovePiece(piece, targetPosition);
    }

    //método
    public void Undo() {

        //move a peça de volta ao local de origem
        board.MovePiece(piece, targetPosition);
    }
}