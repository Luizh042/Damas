namespace Damas;

public class Receiver {

    private Board board;

    public Receiver(Board board) {

        this.board = board;
    }

    public void MovePieceCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se a pe�a pode se mover para a posi��o alvo
        if (board.CanMovePiece(startX, startY, targetX, targetY)) {

            // Move a pe�a para a posi��o alvo
            board.MovePiece(startX, startY, targetX, targetY);
            Console.WriteLine("Pe�a movida com sucesso!");
        }
        else {

            Console.WriteLine("Movimento inv�lido da pe�a!");
        }
    }

    public void CapturePieceCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se � poss�vel capturar a pe�a na posi��o alvo
        if (board.CanCapturePiece(startX, startY, targetX, targetY)) {

            // Captura a pe�a na posi��o alvo
            board.CapturePiece(startX, startY, targetX, targetY);
            Console.WriteLine("Pe�a capturada com sucesso!");
        }
        else {

            Console.WriteLine("Captura inv�lida!");
        }
    }

    public void PromoteToDamaCommand(int x, int y) {

        // Verifica se a pe�a pode ser promovida para dama na posi��o alvo
        if (board.CanPromoteToDama(x, y)) {

            // Promove a pe�a para dama na posi��o alvo
            board.PromoteToDama(x, y);
            Console.WriteLine("Pe�a promovida para dama com sucesso!");
        }
        else {

            Console.WriteLine("Promo��o inv�lida!");
        }
    }

    public void JumpCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se � poss�vel realizar o salto na posi��o alvo
        if (board.CanJump(startX, startY, targetX, targetY)) {

            // Realiza o salto na posi��o alvo
            board.Jump(startX, startY, targetX, targetY);
            Console.WriteLine("Salto realizado com sucesso!");
        }
        else {

            Console.WriteLine("Salto inv�lido!");
        }
    }
    public void MoveDamaCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se a Dama pode se mover para a posi��o alvo
        if (board.CanMoveDama(startX, startY, targetX, targetY)) {

            // Move a Dama para a posi��o alvo
            board.MoveDama(startX, startY, targetX, targetY);
            Console.WriteLine("Dama movida com sucesso!");
        }
        else {

            Console.WriteLine("Movimento inv�lido da Dama!");
        }
    }
}


