using Damas;

namespace Damas;

public interface ICommand {

    //método para executar o comando
    void Execute();

    //método para desfazer o comando
    void Undo();
}