namespace Damas;


//declarando a classe que implementa a interface ICommand
public class PromoteToDamaCommand : ICommand {

    private Board board;//referência para o tabuleiro para que haja interação com o comando
    private Piece piece;//referência a peça a ser promivida
    private Position currentPosition;//referência a posição atual da peça


    //Construtor da classe e definição dos parâmetros para criação da instância do comando
    public PromoteToDamaCommand(Board board, Piece piece, Position currentPosition) {

        this.board = board;//Atribui o tabuleiro recebido como parâmetro ao atributo "board"
        this.piece = piece;//Atribui a peça a ser promovida recebida como parâmetro ao atributo "piece"
        this.currentPosition = currentPosition; //Atribui a posição atual da peça recebida como parâmetro ao atributo "currentPosition"
    }

    //método
    public void Execute() {

        //promovendo a peça para dama
        board.PromoteToDama(piece);
    }

    //método
    public void Undo() {

        //rebaixando a peça promovida
        board.DemoteFromDama(piece)
    }
}