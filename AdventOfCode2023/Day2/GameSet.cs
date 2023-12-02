using System;
using AdventOfCode2023.Common;

namespace AdventOfCode2023.Day2
{
	public class GameSet
	{
		public GameSet(string input)
		{
			// input will look like 1 red, 2 green, 6 blue
			ParseSet(input);

        }

		public void ParseSet(string input)
		{
			var vals = input.Split(',');
			foreach(var val in vals)
			{
				if(val.Contains("blue"))
				{
					BlueCubes = val.ExtractNumberFromText();
                }

				if(val.Contains("red"))
				{
					RedCubes = val.ExtractNumberFromText();
                }

				if(val.Contains("green"))
				{
					GreenCubes = val.ExtractNumberFromText();
                }
			}
		}

        public int BlueCubes { get; set; }
		public int RedCubes { get; set; }
		public int GreenCubes { get; set; }
	}
}

