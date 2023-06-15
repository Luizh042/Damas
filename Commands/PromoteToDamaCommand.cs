namespace Damas;


//declarando a classe que implementa a interface ICommand
public class PromoteToDamaCommand : ICommand {

    private Board board;//refer�ncia para o tabuleiro para que haja intera��o com o comando
    private Piece piece;//refer�ncia a pe�a a ser promivida
    private Position currentPosition;//refer�ncia a posi��o atual da pe�a


    //Construtor da classe e defini��o dos par�metros para cria��o da inst�ncia do comando
    public PromoteToDamaCommand(Board board, Piece piece, Position currentPosition) {

        this.board = board;//Atribui o tabuleiro recebido como par�metro ao atributo "board"
        this.piece = piece;//Atribui a pe�a a ser promovida recebida como par�metro ao atributo "piece"
        this.currentPosition = currentPosition; //Atribui a posi��o atual da pe�a recebida como par�metro ao atributo "currentPosition"
    }

    //m�todo
    public void Execute() {

        //promovendo a pe�a para dama
        board.PromoteToDama(piece);
    }

    //m�todo
    public void Undo() {

        //rebaixando a pe�a promovida
        board.DemoteFromDama(piece)
    }
}