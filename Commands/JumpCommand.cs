namespace Damas;


//declarando a classe que implementa a interface ICommand
public class JumpCommand : ICommand {

    private Board board;//refer�ncia para o tabuleiro para que haja intera��o com o comando
    private Piece jumper;//Refer�ncia a pe�a que realiza o salto
    private List<Piece> capturedPieces;//refer�ncia em lista das pe�as que s�o capturadas durante o salto
    private Position startPosition;//refer�ncia a posi��o inical do jumper
    private Position targetPosition;//refer�ncia a posi��o de destino do jumper

    public JumpCommand(Board board, Piece jumper, List<Piece> capturedPieces, Position startPosition, Position targetPosition) {

        this.board = board;//Atribui o tabuleiro recebido como par�metro ao atributo "board"
        this.jumper = jumper;//atribui o jumper recebido como par�metroao atributo"jumper"
        this.capturedPieces = capturedPieces;//atribui a lista de pe�as capturadas recebida como par�metro ao atributo "capturedPieces"
        this.startPosition = startPosition;//atribui a posi��o inicial recebida como par�metro ao atributo "startPosition"
        this.targetPosition = targetPosition;//atribui a posi��o de destino como par�metro ao atributo "targetPosition"
    }

    //m�todo
    public void Execute() {

        //move o jumper para a posi��o de destino
        board.MovePiece(jumper, targetPosition);

        //remove as pe�as capturadas do tabuleiro
        foreach (Piece capturedPiece in capturedPieces) {

            board.RemovePiece(capturedPiece);
        }
    }

    //m�todo que desfaz o comando
    public void Undo() {

        //desfaz o movimento, retornando o jumper para a posi��o inicial
        board.MovePiece(jumper, startPosition);

        //coloca as pe�as capturadas de volta ao tabuleiro
        foreach (Piece capturedPiece in capturedPieces) {

            board.AddPiece(capturedPiece, capturedPiece.GetPosition());
            
        }
    }
}