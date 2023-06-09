namespace Damas;

public class Receiver {

    private Board board;

    public Receiver(Board board) {

        this.board = board;
    }

    public void MovePieceCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se a peça pode se mover para a posição alvo
        if (board.CanMovePiece(startX, startY, targetX, targetY)) {

            // Move a peça para a posição alvo
            board.MovePiece(startX, startY, targetX, targetY);
            Console.WriteLine("Peça movida com sucesso!");
        }
        else {

            Console.WriteLine("Movimento inválido da peça!");
        }
    }

    public void CapturePieceCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se é possível capturar a peça na posição alvo
        if (board.CanCapturePiece(startX, startY, targetX, targetY)) {

            // Captura a peça na posição alvo
            board.CapturePiece(startX, startY, targetX, targetY);
            Console.WriteLine("Peça capturada com sucesso!");
        }
        else {

            Console.WriteLine("Captura inválida!");
        }
    }

    public void PromoteToDamaCommand(int x, int y) {

        // Verifica se a peça pode ser promovida para dama na posição alvo
        if (board.CanPromoteToDama(x, y)) {

            // Promove a peça para dama na posição alvo
            board.PromoteToDama(x, y);
            Console.WriteLine("Peça promovida para dama com sucesso!");
        }
        else {

            Console.WriteLine("Promoção inválida!");
        }
    }

    public void JumpCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se é possível realizar o salto na posição alvo
        if (board.CanJump(startX, startY, targetX, targetY)) {

            // Realiza o salto na posição alvo
            board.Jump(startX, startY, targetX, targetY);
            Console.WriteLine("Salto realizado com sucesso!");
        }
        else {

            Console.WriteLine("Salto inválido!");
        }
    }
    public void MoveDamaCommand(int startX, int startY, int targetX, int targetY) {

        // Verifica se a Dama pode se mover para a posição alvo
        if (board.CanMoveDama(startX, startY, targetX, targetY)) {

            // Move a Dama para a posição alvo
            board.MoveDama(startX, startY, targetX, targetY);
            Console.WriteLine("Dama movida com sucesso!");
        }
        else {

            Console.WriteLine("Movimento inválido da Dama!");
        }
    }
}


