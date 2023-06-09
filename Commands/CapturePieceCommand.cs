namespace Damas;


//declarando a classe que implementa a interface ICommand
public class CapturePieceCommand : ICommand {

    private Board board;//referência para o tabuleiro para que haja interação com o comando
    private Piece capturingPiece;//referência para a peça que irá realizar a captura
    private Piece capturedPiece; //referência a peça a ser capturada
    private Positon targetPosition; //referência do destino da peça capturadora
    private Position capturedPosition; //referência atual da peça capturada

    //Construtor da classe e definição dos parâmetros para criação da instância do comando
    public CapturePieceCommand(Board board, CapturePieceCommand capturingPiece, Piece capturedPiece, Position targetPosition, Position capturedPiecePosition) {

        this.board = board;// Atribui o tabuleiro recebido como parâmetro ao atributo "board"
        this.capturingPiece = capturingPiece;//Atribui a peça capturadora recebida como parâmetro ao atributo "capturingPiece"
        this.capturedPiece = capturedPiece;//Atribui a peça capturada recebida como parâmetro ao atributo "capturedPiece"
        this.targetPosition = targetPosition;//Atribui a posição de destino recebida como parâmetro ao atributo "targetPosition"
        this.capturedPosition = capturedPiecePosition;//Atribui a posição atual da peça capturada recebida como parâmetro ao atributo "capturedPiecePosition"
    }

    //método
    public void Execute() {

        //Armazena a posição anterior da peça capturada antes de realizar o movimento
        Position previusPosition = capturingPiece.Position;
        
        //move a peça capturadora para a posição de destino no tabuleiro
        board.MovePiece(capturingPiece, targetPosition);

        //remove a peça capturada do tabuleiro
        board.RemovePiece(capturedPiece, capturedPiecePosition);
    }

    //método
    public void Undo() {

        //move a peça capturadora de volta para a posição anterior
        board.MovePiece(capturingPiece, capturingPiece.Position);

        //reposiciona a peça capturada no tabuleiro
        board.AddPiece(capturedPiece, capturedPiece.Position)
    }
}