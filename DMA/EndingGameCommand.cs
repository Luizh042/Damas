namespace Damas
{

    public class EndingGameCommand : ICommand
    {
        Game game;

        public EndingGameCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Ending();
        }
    }
}