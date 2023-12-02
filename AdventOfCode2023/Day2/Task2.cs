using AdventOfCode2023.Common;

namespace AdventOfCode2023.Day2
{
	public class Task2 : BaseTask
	{
		public Task2()
		{
		}

        public override void Run()
        {
            var input = this.GetInput();

            //var input = @"Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
            //Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
            //Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
            //Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
            //Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green".SplitToLines();


            var games = new List<Game>();
            foreach (var line in input)
            {
                var game = new Game(line);
                games.Add(game);
            }

            var total = 0;
            foreach(var g in games)
            {
                total += g.Power;
            }

            Console.WriteLine("The total of game powers is {0}", total);
        }
    }
}

