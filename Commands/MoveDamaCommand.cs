namespace Damas;


//declarando a classe que implementa a interface ICommand
public class MoveDamaCommand : ICommand {

    private Board board;//referência para o tabuleiro para que haja interação com o comando
    private Piece dama;//referência a dama a ser movida
    private Position startPosition;//referência a posição inicial da dama
    private Position targetPosition;//referência de destino da dama


    //Construtor da classe e definição dos parâmetros para criação da instância do comando
    public MoveDamaCommand(Board board, Piece dama, Position startPosition, Position targetPosition) {

        this.board = board;//Atribui o tabuleiro recebido como parâmetro ao atributo "board"
        this.dama = dama;//Atribui a dama a ser movida recebida como parâmetro ao atributo "king"
        this.startPosition = startPosition;//Atribui a posição inicial recebida como parâmetro ao atributo "startPosition"
        this.targetPosition = targetPosition;//Atribui a posição de destino recebida como parâmetro ao atributo "targetPosition"
    }

    //método
    public void Execute() {

        //move a dama para a posição de destino
        board.MovePiece(dama, targetPosition);
    }

    //método
    public void Undo() {

        //desfaz movimento, voltando a dama para a posição inicial
        board.MovePiece(dama, startPosition);
    }
}