namespace Damas;

public class Board
{
    private Piece[,] pieces;

    public Board()
    {
        private void InitializePieces()
        {
            // Inicializar o tabuleiro vazio
            pieces = new Piece[8, 8];
            // Preencher as peças das linhas superiores
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Verificar se a posição (row, col) é uma posição válida para uma peça
                    if ((row + col) % 2 != 0)
                    {
                        // Criar uma nova peça normal e colocá-la na posição (row, col)
                        pieces[row, col] = new Piece(PieceType.Normal, PieceColor.White);
                    }
                }
            }

            // Preencher as peças das linhas inferiores
            for (int row = 5; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Verificar se a posição (row, col) é uma posição válida para uma peça
                    if ((row + col) % 2 != 0)
                    {
                        // Criar uma nova peça normal e colocá-la na posição (row, col)
                        pieces[row, col] = new Piece(PieceType.Normal, PieceColor.Black);
                    }
                }
            }
        }

    }

    public bool CanMovePiece(int startX, int startY, int targetX, int targetY)
    {
        // Verifique se a posição inicial contém uma peça válida
        if (!IsValidPosition(startX, startY) || !HasPiece(startX, startY))
        {
            return false;
        }

        // Verifique se a posição alvo é válida
        if (!IsValidPosition(targetX, targetY))
        {
            return false;
        }

        // Verifique se a posição alvo está vazia
        if (HasPiece(targetX, targetY))
        {
            return false;
        }

        // Implemente as regras de movimento das peças de acordo com as regras do jogo de damas
        // ...

        return true; // Se todas as condições forem atendidas, o movimento é válido
    }

    public void MovePiece(int startX, int startY, int targetX, int targetY)
    {
        // Verifique se o movimento é válido
        if (CanMovePiece(startX, startY, targetX, targetY))
        {
            // Realize o movimento da peça
            Piece piece = pieces[startX, startY];
            pieces[startX, startY] = null;
            pieces[targetX, targetY] = piece;
        }
        else
        {
            Console.WriteLine("Movimento inválido da peça!");
        }
    }


    public bool CanCapturePiece(int startX, int startY, int targetX, int targetY)
    {
        // Verifique se a posição inicial contém uma peça válida
        if (!IsValidPosition(startX, startY) || !HasPiece(startX, startY))
        {
            return false;
        }

        // Verifique se a posição alvo é válida
        if (!IsValidPosition(targetX, targetY))
        {
            return false;
        }

        // Verifique se a posição alvo está vazia
        if (HasPiece(targetX, targetY))
        {
            return false;
        }

        // Implemente as regras de captura das peças de acordo com as regras do jogo de damas
        // ...

        return true; // Se todas as condições forem atendidas, a captura é possível
    }

    public void CapturePiece(int startX, int startY, int targetX, int targetY)
    {
        // Verifique se a captura é possível
        if (CanCapturePiece(startX, startY, targetX, targetY))
        {
            // Realize a captura da peça
            Piece piece = pieces[startX, startY];
            pieces[startX, startY] = null;
            pieces[targetX, targetY] = piece;

            // Remova a peça capturada
            int capturedX = (startX + targetX) / 2;
            int capturedY = (startY + targetY) / 2;
            pieces[capturedX, capturedY] = null;
        }
        else
        {
            Console.WriteLine("Captura inválida!");
        }
    }


    public bool CanPromoteToDama(int x, int y)
    {
        // Verifique se a posição contém uma peça válida
        if (!IsValidPosition(x, y) || !HasPiece(x, y))
        {
            return false;
        }

        // Implemente as regras de promoção para dama de acordo com as regras do jogo de damas
        // ...

        return true; // Se todas as condições forem atendidas, a promoção é possível
    }

    public void PromoteToDama(int x, int y)
    {
        // Verifique se a promoção é possível
        if (CanPromoteToDama(x, y))
        {
            // Realize a promoção da peça para dama
            Piece piece = pieces[x, y];
            piece.IsDama = true;
        }
        else
        {
            Console.WriteLine("Promoção inválida!");
        }
    }


    public bool CanJump(int startX, int startY, int targetX, int targetY)
    {
        // Verifique se é possível realizar o salto na posição alvo
        // Implemente as regras de salto de acordo com as regras do jogo de damas
        // ...
    }

    public void Jump(int startX, int startY, int targetX, int targetY)
    {
        // Realiza o salto na posição alvo
        // Implemente a lógica para executar o salto de acordo com as regras do jogo de damas
        // ...
    }
}
