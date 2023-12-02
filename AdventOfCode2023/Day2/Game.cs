namespace AdventOfCode2023.Day2
{
	public class Game
	{
		public int GameId { get; set; }
		public int Power { get; set; }

		public List<GameSet> Sets { get; set; }

		public Game(string input)
		{
			Sets = new List<GameSet>();
			ParseGameId(input);
			ParseSets(input);
			CalculatePower();
		}

		public void ParseGameId(string input)
		{
			GameId = int.Parse(input.Split(':')[0].Replace("Game", "").Trim());
		}

		public void ParseSets(string input)
		{
			var setsInput = input.Split(':')[1];
			var setsCollection = setsInput.Split(';');

			foreach(var text in setsCollection)
			{
				Sets.Add(new GameSet(text));
			}
		}

		public void CalculatePower()
		{
			var maxRed = Sets.Max(s => s.RedCubes);
			var maxBlue = Sets.Max(s => s.BlueCubes);
			var maxGreen = Sets.Max(s => s.GreenCubes);

			Power =  maxBlue * maxGreen * maxRed;
		}

		
	}
}

