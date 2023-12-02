using AdventOfCode2023.Common;

namespace AdventOfCode2023.Day2
{
	public class Task1 : BaseTask
	{
		public Task1()
		{
		}

        public override void Run()
        {
            var input = this.GetInput();

//            var input = @"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
//Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
//Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
//Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
//Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green".SplitToLines();


            var games = new List<Game>();
            foreach(var line in input)
            {
                var game = new Game(line);
                games.Add(game);
            }


            var possibleGames = new List<Game>();

            foreach(var g in games)
            {
                if(GameIsImpossible(g) == false)
                {
                    possibleGames.Add(g);
                }
            }

            var total = possibleGames.Sum(i => i.GameId);
            Console.WriteLine("Possible Game total = {0}", total);

        }

        public bool GameIsImpossible(Game game)
        {
            const int maxRed = 12;
            const int maxGreen = 13;
            const int maxBlue = 14;

            return game.Sets.Any(s => s.BlueCubes > maxBlue || s.RedCubes > maxRed || s.GreenCubes > maxGreen);
        }
    }
}

