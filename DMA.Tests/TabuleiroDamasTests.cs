using System;

namespace Damas;

// Classe de teste
public class Teste
{
    public static void Main()
    {
        // Cria��o do Receiver
        Receiver receiver = new Receiver();

        // Cria��o dos comandos
        ICommand command1 = new ConcreteCommand(receiver, "CapturePieceCommand");
        ICommand command2 = new ConcreteCommand(receiver, "JumpCommand");
        ICommand command3 = new ConcreteCommand(receiver, "MoveDamaCommand");

        // Cria��o do Invoker
        Invoker invoker = new Invoker();

        // Testando sequ�ncia de comandos
        invoker.SetCommand(command1);
        invoker.Invoke();

        invoker.SetCommand(command2);
        invoker.Invoke();

        invoker.SetCommand(command3);
        invoker.Invoke();
    }
}
