using System;
using AdventOfCode2023.Common;

namespace AdventOfCode2023.Day1
{
	public class Task1 : BaseTask
	{
		public Task1()
		{
		}

        public override void Run()
        {
            var input = this.GetInput();
//            var input = @"1abc2
//pqr3stu8vwx
//a1b2c3d4e5f
//treb7uchet".Split(new[] { '\r', '\n' }); 
            var total = 0;
            foreach(var line in input)
            {
                var value = GetCalibrationValue(line);
                total += value;
            }
            Console.WriteLine("Calibration total = {0}", total);

        }

        public int GetCalibrationValue(string inputLine)
        {
            var first = GetFirstNumber(inputLine);
            var reverse = ReverseString(inputLine);
            var second = GetFirstNumber(reverse);
            var value = first.ToString() + second.ToString();
            return int.Parse(value);
        }

        /// <summary>
        /// Find the first number in a input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetFirstNumber(string input)
        {
            foreach(var c in input)
            {
                if(Char.IsNumber(c))
                {
                    return int.Parse(c.ToString());
                }
            }
            throw new Exception("No number found!");
        }
    }
}

