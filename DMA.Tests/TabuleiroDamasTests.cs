using System;

namespace Damas;

// Classe de teste
public class Teste
{
    public static void Main()
    {
        // Criação do Receiver
        Receiver receiver = new Receiver();

        // Criação dos comandos
        ICommand command1 = new ConcreteCommand(receiver, "CapturePieceCommand");
        ICommand command2 = new ConcreteCommand(receiver, "JumpCommand");
        ICommand command3 = new ConcreteCommand(receiver, "MoveDamaCommand");

        // Criação do Invoker
        Invoker invoker = new Invoker();

        // Testando sequência de comandos
        invoker.SetCommand(command1);
        invoker.Invoke();

        invoker.SetCommand(command2);
        invoker.Invoke();

        invoker.SetCommand(command3);
        invoker.Invoke();
    }
}
