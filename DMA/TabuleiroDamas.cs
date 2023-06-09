using System;
using Damas;

namespace Damas;

public class TabuleiroDamas
{

    public enum PlayerColor
    {

        White,
        Black
    }
    private static readonly int BoardSize = 8;
    private Piece[,]? pieces;
    private Player player1;
    private Player player2;
    private Player currentPlayer;
    private Player opponentPlayer;
    private PlayerColor currentPlayerColor;

    public void ChangeTurn()
    {

        if (currentPlayerColor == PlayerColor.White)
        {

            currentPlayerColor = PlayerColor.Black;
        }
        else
        {

            currentPlayerColor = PlayerColor.White;
        }
    }

    public TabuleiroDamas()
    {

        pieces = new Piece[BoardSize, BoardSize];

    }

    public void DisplayBoard()
    {

        Console.WriteLine("Tabuleiro:");

        // Exibir as coordenadas das colunas
        Console.Write("  ");
        for (int col = 0; col < BoardSize; col++)
        {

            Console.Write($"{col} ");
        }
        Console.WriteLine();

        // Exibir as peças e os números das linhas
        for (int row = 0; row < BoardSize; row++)
        {

            Console.Write($"{row} "); // Exibir número da linha

            for (int col = 0; col < BoardSize; col++)
            {

                Piece piece = pieces[row, col]; // Obter a peça na posição atual

                if (piece == null)
                {

                    Console.Write("- "); // Exibir espaço vazio se não houver peça
                }
                else
                {

                    string pieceSymbol = piece.IsDama ? "D" : "O"; // Usar "D" para damas e "O" para peças normais
                    Console.Write($"{pieceSymbol} "); // Exibir símbolo da peça
                }
            }

            Console.WriteLine(); // Pular para a próxima linha
        }
    }

    ///<summary>
    ///exibir as informações dos jogadores na tela
    ///</summary>
    public void DisplayPlayerInfo()
    {


        Console.WriteLine("Informações dos Jogadores:");
        Console.WriteLine($"Jogador Atual: {currentPlayer.Name} (Cor: {currentPlayer.Color})");
        Console.WriteLine($"Jogador Oponente: {opponentPlayer.Name} (Cor: {opponentPlayer.Color})");
    }
    ///<summary>
    /// Configura as peças iniciais no tabuleiro.
    ///</summary>
    private void SetInitialPieces()
    {

        // Limpar o tabuleiro
        ClearBoard();

        // Configurar as peças iniciais para o jogador branco
        for (int row = 0; row < 3; row++)
        {

            for (int col = 0; col < 8; col++)
            {

                // Verificar se a posição deve conter uma peça
                if ((row + col) % 2 == 0)
                {

                    pieces[row, col] = new Piece(PieceType.Normal, PieceColor.White);
                }
            }
        }

        // Configurar as peças iniciais para o jogador preto
        for (int row = 5; row < 8; row++)
        {

            for (int col = 0; col < 8; col++)
            {

                // Verificar se a posição deve conter uma peça
                if ((row + col) % 2 == 0)
                {

                    pieces[row, col] = new Piece(PieceType.Normal, PieceColor.Black);
                }
            }
        }
    }
    /*
    private void InitializePieces() {

        // Inicializar o tabuleiro vazio
        pieces = new Piece[8, 8];
        // Preencher as peças das linhas superiores
        for (int row = 0; row < 3; row++) {

            for (int col = 0; col < 8; col++) {

                // Verificar se a posição (row, col) é uma posição válida para uma peça
                if ((row + col) % 2 != 0) {

                    // Criar uma nova peça normal e colocá-la na posição (row, col)
                    pieces[row, col] = new Piece(PieceType.Normal, PieceColor.White);
                }
            }
        }

        // Preencher as peças das linhas inferiores
        for (int row = 5; row < 8; row++) {

            for (int col = 0; col < 8; col++) {

                // Verificar se a posição (row, col) é uma posição válida para uma peça
                if ((row + col) % 2 != 0) {

                    // Criar uma nova peça normal e colocá-la na posição (row, col)
                    pieces[row, col] = new Piece(PieceType.Normal, PieceColor.Black);
                }
            }
        }
    }
    */

    public bool IsValidPosition(int x, int y)
    {

        // Verifique se as coordenadas (x, y) estão dentro dos limites do tabuleiro
        return x >= 0 && x < BoardSize && y >= 0 && y < BoardSize;
    }

    public bool HasPiece(int x, int y)
    {

        // Verifique se a posição (x, y) do tabuleiro contém uma peça
        return pieces[x, y] != null;
    }

    public bool IsEnemyPiece(int x, int y)
    {

        // Verifique se a posição (x, y) contém uma peça do adversário
        if (IsValidPosition(x, y))
        {

            Piece piece = pieces[x, y];
            if (piece != null)
            {

                // Verifique se a peça é do jogador atual ou do adversário
                return piece.Color != PieceColor.White;
            }
        }
        return false;
    }


    public bool IsDama(int x, int y)
    {

        // Verifique se a posição (x, y) contém uma dama
        if (IsValidPosition(x, y))
        {

            Piece piece = pieces[x, y];
            if (piece != null)
            {

                // Substitua a lógica abaixo com a lógica correta do seu jogo
                return piece.Type == PieceType.Dama;
            }
        }
        return false;
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

        // Verifique se a posição de origem contém uma peça válida
        if (!IsValidPosition(startX, startY) || !HasPiece(startX, startY))
        {

            return false;
        }

        // Verifique se a posição de destino está vazia
        if (HasPiece(targetX, targetY))
        {

            return false;
        }

        // Implemente as regras de salto de acordo com as regras do jogo de damas
        // Verifique se há uma peça inimiga a ser capturada no meio da trajetória
        int capturedX = (startX + targetX) / 2; // Calcula a posição x da peça a ser capturada
        int capturedY = (startY + targetY) / 2; // Calcula a posição y da peça a ser capturada

        if (HasPiece(capturedX, capturedY) && IsEnemyPiece(capturedX, capturedY))
        {

            return true; // Se todas as condições forem atendidas, o salto é possível
        }

        return false;
    }

    public void Jump(int startX, int startY, int targetX, int targetY)
    {

        // Verifique se o salto é possível
        if (CanJump(startX, startY, targetX, targetY))
        {

            // Realize o salto, capturando a peça inimiga
            int capturedX = (startX + targetX) / 2; // Calcula a posição x da peça a ser capturada
            int capturedY = (startY + targetY) / 2; // Calcula a posição y da peça a ser capturada

            // Captura a peça inimiga
            CapturePiece(startX, startY, capturedX, capturedY);

            // Move a peça para a posição alvo
            MovePiece(startX, startY, targetX, targetY);

            Console.WriteLine("Salto realizado com sucesso!");
        }
        else
        {

            Console.WriteLine("Salto inválido!");
        }
    }

    public bool CanMoveDama(int startX, int startY, int targetX, int targetY)
    {

        // Verifique se a posição inicial contém uma Dama válida
        if (!IsValidPosition(startX, startY) || !HasPiece(startX, startY) || !IsDama(startX, startY))
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

        // Calcule a diferença entre as posições inicial e alvo
        int deltaX = targetX - startX;
        int deltaY = targetY - startY;

        // Verifique se o movimento é diagonal (mesma distância em X e Y)
        if (Math.Abs(deltaX) != Math.Abs(deltaY))
        {

            return false;
        }

        // Verifique se há peças no caminho
        int stepX = Math.Sign(deltaX);
        int stepY = Math.Sign(deltaY);

        int currentX = startX + stepX;
        int currentY = startY + stepY;

        while (currentX != targetX && currentY != targetY)
        {

            // Verifique se há uma peça no caminho
            if (HasPiece(currentX, currentY))
            {

                return false;
            }

            currentX += stepX;
            currentY += stepY;
        }

        return true; // Se todas as condições forem atendidas, o movimento da Dama é válido
    }

    public void MoveDama(int startX, int startY, int targetX, int targetY)
    {

        // Verifique se o movimento da Dama é válido
        if (CanMoveDama(startX, startY, targetX, targetY))
        {

            // Realize o movimento da Dama
            Piece piece = pieces[startX, startY];
            pieces[startX, startY] = null;
            pieces[targetX, targetY] = piece;
        }
        else
        {

            Console.WriteLine("Movimento inválido da Dama!");
        }
    }

    private void InitializeBoard()
    {

        // Inicializar o array de peças com posições vazias
        pieces = new Piece[8, 8];

        // Preencher as posições iniciais das peças brancas
        for (int row = 0; row < 3; row++)
        {

            for (int col = 0; col < 8; col++)
            {

                // Verificar se a posição deve conter uma peça
                if ((row + col) % 2 == 0)
                {

                    pieces[row, col] = new Piece(PieceType.Normal, PieceColor.White);
                }
            }
        }

        // Preencher as posições iniciais das peças pretas
        for (int row = 5; row < 8; row++)
        {

            for (int col = 0; col < 8; col++)
            {

                // Verificar se a posição deve conter uma peça
                if ((row + col) % 2 == 0)
                {

                    pieces[row, col] = new Piece(PieceType.Normal, PieceColor.Black);
                }
            }
        }
    }


    private void SetInitialPlayers()
    {

        //criar jogadores
        Player player1 = new Player("Jogador 1", (PieceColor)PlayerColor.White);
        Player player2 = new Player("Jogador 2", (PieceColor)PlayerColor.Black);

        //define o jogador atual como o jogador 1
        currentPlayer = player1;
        opponentPlayer = player2;
    }

    private bool IsPieceValid(int x, int y, PieceColor playerColor)
    {

        // Verificar se a posição está dentro do tabuleiro
        if (!IsPositionValid(x, y))
        {

            return false;
        }

        // Verificar se a posição contém uma peça do jogador atual
        Piece piece = pieces[x, y];
        if (piece == null || piece.Color != playerColor)
        {

            return false;
        }

        // A posição contém uma peça válida do jogador atual
        return true;
    }

    private bool IsPositionEmpty(int x, int y)
    {

        // Verificar se a posição (x, y) está dentro dos limites do tabuleiro
        if (x < 0 || x >= BoardSize || y < 0 || y >= BoardSize)
        {

            return false;
        }

        // Verificar se a posição não contém uma peça
        return pieces[x, y] == null;
    }

    private bool IsPositionValid(int x, int y)
    {
        //verifica se a posiçãop é valida
        return x >= 0 && x < BoardSize && y >= 0 && y < BoardSize;
    }


    private bool IsValidMove(int fromX, int fromY, int toX, int toY)
    {

        // Verificar se a posição de origem contém uma peça do jogador atual
        if (!IsPieceValid(fromX, fromY, currentPlayer.Color))
        {

            return false;
        }

        // Verificar se a posição de destino está dentro do tabuleiro
        if (!IsPositionValid(toX, toY))
        {

            return false;
        }

        // Verificar se a posição de destino está vazia
        if (!IsPositionEmpty(toX, toY))
        {

            return false;
        }

        // Verificar se o movimento é válido para uma peça normal
        if (currentPlayer.Color == PieceColor.White)
        {

            // Movimento válido para peças brancas (para frente e na diagonal)
            if (toX != fromX - 1 || (toY != fromY + 1 && toY != fromY - 1))
            {

                return false;
            }
        }
        else if (currentPlayer.Color == PieceColor.Black)
        {

            // Movimento válido para peças pretas (para frente e na diagonal)
            if (toX != fromX + 1 || (toY != fromY + 1 && toY != fromY - 1))
            {

                return false;
            }
        }

        // Se todas as condições foram atendidas, o movimento é válido
        return true;
    }



    private void PlayGame()
    {

        // variável para controlar se o jogo está em andamento
        bool gameInProgress = true;

        //loop principal do jogo
        while (gameInProgress)
        {

            //exibir o tabuleiro e as informações do jogador atual
            DisplayBoard();
            DisplayPlayerInfo();

            //obter a jogada do jogador atual
            Move move = currentPlayer.GetMove();

            //verificar se a jogada é valida

            if (IsValidMove(move.SourceX, move.SourceY, move.DestinationX, move.DestinationY))
            {

                // Executar a jogada
                ExecuteMove(move);

                if (IsGameOver())
                {

                    // Exibir o resultado final do jogo
                    DisplayGameResult();
                    gameInProgress = false; // Termina o jogo
                }
                else
                {

                    // Alternar para o próximo jogador
                    switchPlayer();
                }
            }
            else
            {

                // A jogada é inválida, exibir mensagem de erro e pedir outra jogada
                Console.WriteLine("Jogada inválida! Tente novamente");
            }


            void ClearBoard()
            {

                for (int i = 0; i < boardSize; i++)
                {

                    for (int j = 0; j < boardSize; j++)
                    {

                        board[i, j] = null;
                    }
                }
            }

            void Start()
            {

                //inicia o tabuleiro
                initializePieces();

                //define as peças e jogadores iniciais
                SetInicialPieces();
                SetInicialPlayers();

                //Inicia o jogo
                PlayGame();
            }
        }
    }
}


