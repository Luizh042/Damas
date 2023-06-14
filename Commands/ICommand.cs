using Damas;

namespace Damas;

public interface ICommand {

    //m�todo para executar o comando
    void Execute();

    //m�todo para desfazer o comando
    void Undo();
}