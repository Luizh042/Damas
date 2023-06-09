namespace Damas;

public class Invoker {

    private List<ICommand> commands;
    private int currentCommandIndex;

    public Invoker() {

        commands = new List<ICommand>();
        currentCommandIndex = -1;
    }

    public void ExecuteCommand(ICommand command) {

        // Executa o comando e adiciona-o à lista de comandos executados
        command.Execute();
        commands.Add(command);
        currentCommandIndex++;
    }

    public void UndoCommand() {
        
        if (currentCommandIndex >= 0) {

            // Desfaz o último comando executado
            ICommand command = commands[currentCommandIndex];
            command.Undo();
            currentCommandIndex--;
        }
    }

    public void RedoCommand() {

        if (currentCommandIndex < commands.Count - 1) {

            // Refaz o último comando desfeito
            currentCommandIndex++;
            ICommand command = commands[currentCommandIndex];
            command.Execute();
        }
    }
}

