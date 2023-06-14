namespace Damas
{

	public class Game
	{
		public bool turnOn = false;

		public void Start()
		{
			Console.WriteLine("Iniciando partida");
			turnOn = true;
		}

		public void Ending()
		{
			Console.WriteLine("Fim do jogo");
			turnOn = false;
		}
	}
}