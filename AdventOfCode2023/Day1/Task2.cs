using AdventOfCode2023.Common;

namespace AdventOfCode2023.Day1
{
	public class Task2 : Task1
	{
		Dictionary<string,int> NumberWords;
        public Task2()
        {
			NumberWords = new Dictionary<string, int>
            {
                { "one", 1 },
                { "two", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7 },
                { "eight", 8 },
                { "nine", 9 }
            };

        }

        public override void Run()
        {
           var input = this.GetInput();
            var output = "";
//            var input = @"1xyzoneight
//two1nine
//eightwothree
//abcone2threexyz
//xtwone3four
//4nineeightseven2
//zoneight234
//7pqrstsixteen".Split(new[] { '\r', '\n' });

            var total = 0;
            foreach (var line in input)
            {
                output += line + " - ";
                var fixedLine = ReplaceNumberWords(line);
                output += fixedLine + " - ";
                var value = GetCalibrationValue(fixedLine);
                output += value + " - ";
                total += value;
                output += total + "\r\n";
            }
            Console.WriteLine("Calibration total = {0}", total);
           // File.WriteAllText("output.txt", output);
        }

        public string ReplaceNumberWords(string input)
        {
            while(WordHasNumberWord(input))
            {
                var word = FindFirstNumberWord(input);
                input = input.ReplaceFirst(word, NumberWords[word].ToString() + word.Last());
            }
            return input;
        }

        public bool WordHasNumberWord(string input)
        {
           return NumberWords.Any(w => input.Contains(w.Key));
        }

        public string FindFirstNumberWord(string input)
        {
            var results = new Dictionary<string, int>();
            foreach(var val in NumberWords)
            {
                var i = input.IndexOf(val.Key);
                if(i >= 0)
                {
                    results.Add(val.Key, i);
                }
            }
            var minIndex = results.Select(r => r.Value).Min();
            return results.First(r => r.Value == minIndex).Key;
        }

        public string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}

