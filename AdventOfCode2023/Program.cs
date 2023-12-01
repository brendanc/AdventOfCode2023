// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using AdventOfCode2023.Common;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Advent of Code project!");
        //   var taskInput = ReadLine.Read("Which task would you like to run?");
        var taskInput = "1.2";
        var resolvedTask = TaskResolver.ResolveTask(taskInput);

        var sw = new Stopwatch();
        sw.Start();
        resolvedTask.Run();
        sw.Stop();
        var ts = sw.Elapsed;
        Console.WriteLine(string.Format("{0}:{1}", Math.Floor(ts.TotalMinutes), ts.ToString("ss\\.ff")));
        ReadLine.Read("Run complete!");
    }
}