namespace Damas;

// ConcreteCommand - Implementa��o espec�fica de um comando
public class ConcreteCommand : ICommand {

    private Receiver receiver;
    private string command;

    public ConcreteCommand(Receiver receiver, string command){

        this.receiver = receiver;
        this.command = command;
    }

    public void Execute() {

        receiver.PerformAction(command);
    }
}
