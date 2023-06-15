namespace Damas;


//declarando a classe que implementa a interface ICommand
public class CapturePieceCommand : ICommand {

    private Board board;//refer�ncia para o tabuleiro para que haja intera��o com o comando
    private Piece capturingPiece;//refer�ncia para a pe�a que ir� realizar a captura
    private Piece capturedPiece; //refer�ncia a pe�a a ser capturada
    private Positon targetPosition; //refer�ncia do destino da pe�a capturadora
    private Position capturedPosition; //refer�ncia atual da pe�a capturada

    //Construtor da classe e defini��o dos par�metros para cria��o da inst�ncia do comando
    public CapturePieceCommand(Board board, CapturePieceCommand capturingPiece, Piece capturedPiece, Position targetPosition, Position capturedPiecePosition) {

        this.board = board;// Atribui o tabuleiro recebido como par�metro ao atributo "board"
        this.capturingPiece = capturingPiece;//Atribui a pe�a capturadora recebida como par�metro ao atributo "capturingPiece"
        this.capturedPiece = capturedPiece;//Atribui a pe�a capturada recebida como par�metro ao atributo "capturedPiece"
        this.targetPosition = targetPosition;//Atribui a posi��o de destino recebida como par�metro ao atributo "targetPosition"
        this.capturedPosition = capturedPiecePosition;//Atribui a posi��o atual da pe�a capturada recebida como par�metro ao atributo "capturedPiecePosition"
    }

    //m�todo
    public void Execute() {

        //Armazena a posi��o anterior da pe�a capturada antes de realizar o movimento
        Position previusPosition = capturingPiece.Position;
        
        //move a pe�a capturadora para a posi��o de destino no tabuleiro
        board.MovePiece(capturingPiece, targetPosition);

        //remove a pe�a capturada do tabuleiro
        board.RemovePiece(capturedPiece, capturedPiecePosition);
    }

    //m�todo
    public void Undo() {

        //move a pe�a capturadora de volta para a posi��o anterior
        board.MovePiece(capturingPiece, capturingPiece.Position);

        //reposiciona a pe�a capturada no tabuleiro
        board.AddPiece(capturedPiece, capturedPiece.Position)
    }
}