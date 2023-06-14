namespace Damas;


//declarando a classe que implementa a interface ICommand
public class JumpCommand : ICommand {

    private Board board;//referência para o tabuleiro para que haja interação com o comando
    private Piece jumper;//Referência a peça que realiza o salto
    private List<Piece> capturedPieces;//referência em lista das peças que são capturadas durante o salto
    private Position startPosition;//referência a posição inical do jumper
    private Position targetPosition;//referência a posição de destino do jumper

    public JumpCommand(Board board, Piece jumper, List<Piece> capturedPieces, Position startPosition, Position targetPosition) {

        this.board = board;//Atribui o tabuleiro recebido como parâmetro ao atributo "board"
        this.jumper = jumper;//atribui o jumper recebido como parâmetroao atributo"jumper"
        this.capturedPieces = capturedPieces;//atribui a lista de peças capturadas recebida como parêmetro ao atributo "capturedPieces"
        this.startPosition = startPosition;//atribui a posição inicial recebida como parâmetro ao atributo "startPosition"
        this.targetPosition = targetPosition;//atribui a posição de destino como parâmetro ao atributo "targetPosition"
    }

    //método
    public void Execute() {

        //move o jumper para a posição de destino
        board.MovePiece(jumper, targetPosition);

        //remove as peças capturadas do tabuleiro
        foreach (Piece capturedPiece in capturedPieces) {

            board.RemovePiece(capturedPiece);
        }
    }

    //método que desfaz o comando
    public void Undo() {

        //desfaz o movimento, retornando o jumper para a posição inicial
        board.MovePiece(jumper, startPosition);

        //coloca as peças capturadas de volta ao tabuleiro
        foreach (Piece capturedPiece in capturedPieces) {

            board.AddPiece(capturedPiece, capturedPiece.GetPosition());
            
        }
    }
}