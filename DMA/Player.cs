using Damas;
namespace Damas;

public class Player
{

    public string Name { get; set; }
    public PieceColor Color { get; set; }
    public List<Piece> Pieces { get; set; }
    
    public Player(string playerName, PieceColor color) { 
        Name = playerName;
        Color = color;
        Pieces = new List<Piece>();
    }


    public Move GetMove() {

        Console.WriteLine($"� s vez do jogador{Name} (cor:{Color})");

        int fromX, fromY, toX, toY;

        //solicitar a posi��o de origem da pe�a
        Console.WriteLine("Informe a posi��o da pe�a que deseja mover:");
        Console.WriteLine("Linha: ");
        fromX = int.Parse(Console.ReadLine());
        Console.WriteLine("Coluna: ");
        fromY = int.Parse(Console.ReadLine());

        //Solicitar a posi��o de destino
        Console.WriteLine("Informe a posi��o para onde deseja mover a pe�a:");
        Console.WriteLine("Linha: ");
        toX = int.Parse(Console.ReadLine());
        Console.WriteLine("Coluna: ");
        toY = int.Parse(Console.ReadLine());

        Piece piece = new Piece(PieceType.Normal, Color);

        return new Move(fromX, fromY, toX, toY, piece);
    }
}