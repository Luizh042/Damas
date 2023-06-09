using Damas;
namespace Damas;

public class Player
{

    public string Name { get; set; }
    public PieceColor Color { get; set; }

    public Player(string name, PieceColor color) {

        Name = name;
        Color = color;
    }

    public Move GetMove() {

        Console.WriteLine($"É s vez do jogador{Name} (cor:{Color})");

        int fromX, fromY, toX, toY;

        //solicitar a posição de origem da peça
        Console.WriteLine("Informe a posição da peça que deseja mover:");
        Console.WriteLine("Linha: ");
        fromX = int.Parse(Console.ReadLine());
        Console.WriteLine("Coluna: ");
        fromY = int.Parse(Console.ReadLine());

        //Solicitar a posição de destino
        Console.WriteLine("Informe a posição para onde deseja mover a peça:");
        Console.WriteLine("Linha: ");
        toX = int.Parse(Console.ReadLine());
        Console.WriteLine("Coluna: ");
        toY = int.Parse(Console.ReadLine());

        Piece piece = new Piece(PieceType.Normal, Color);

        return new Move(fromX, fromY, toX, toY, piece);
    }
}