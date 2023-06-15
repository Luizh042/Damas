namespace Damas;


//declarando a classe que implementa a interface ICommand
public class MoveDamaCommand : ICommand {

    private Board board;//refer�ncia para o tabuleiro para que haja intera��o com o comando
    private Piece dama;//refer�ncia a dama a ser movida
    private Position startPosition;//refer�ncia a posi��o inicial da dama
    private Position targetPosition;//refer�ncia de destino da dama


    //Construtor da classe e defini��o dos par�metros para cria��o da inst�ncia do comando
    public MoveDamaCommand(Board board, Piece dama, Position startPosition, Position targetPosition) {

        this.board = board;//Atribui o tabuleiro recebido como par�metro ao atributo "board"
        this.dama = dama;//Atribui a dama a ser movida recebida como par�metro ao atributo "king"
        this.startPosition = startPosition;//Atribui a posi��o inicial recebida como par�metro ao atributo "startPosition"
        this.targetPosition = targetPosition;//Atribui a posi��o de destino recebida como par�metro ao atributo "targetPosition"
    }

    //m�todo
    public void Execute() {

        //move a dama para a posi��o de destino
        board.MovePiece(dama, targetPosition);
    }

    //m�todo
    public void Undo() {

        //desfaz movimento, voltando a dama para a posi��o inicial
        board.MovePiece(dama, startPosition);
    }
}