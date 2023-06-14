namespace Damas
{

    public class StartGameCommand : ICommand
    {
        Game game;

        public StartGameCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Start();
        }
    }
}