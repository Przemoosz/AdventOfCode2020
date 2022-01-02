using System;
using System.IO;

namespace AdventOfCode
{
    internal class SolutionDay1Challenge2
    {
        public static void Main(string[] args)
        {
            long solution = 0;
            Console.WriteLine();
            // Utils.ReadFile();
            solution = Solution(Utils.ReadFile());
            Console.WriteLine($"Solution to day 1 Challange 2: {solution}");
        }

        public static long Solution(List<int> numbers)
        {
            long result = 0;
            bool breakfor = false;
            foreach (int number in numbers)
            {
                int searchingNumber = 2020 - number;
                foreach (int innernumber in numbers)
                {
                    if (numbers.Contains(searchingNumber - innernumber))
                    {
                        // Console.WriteLine($"{number} -- {innernumber} -- {searchingNumber-innernumber}");
                        result = number * innernumber * (searchingNumber - innernumber);
                        breakfor = true;
                        break;
                    }
                }
                if (breakfor)
                {
                    break;
                }
            }

            return result;
        }
    }

    static class Utils
    {
        public static List<int> ReadFile()
        {
            List<int> lines =
                new List<int>(
                    File.ReadLines(@"C:\Przemek\Net and C#\AdventOfCode\Day1Challange2\input.txt").Count());
            Console.WriteLine();
            foreach (string line in File.ReadLines(@"C:\Przemek\Net and C#\AdventOfCode\Day1Challange2\input.txt"))
            {
                // Console.WriteLine(line);
                lines.Add(int.Parse(line));
            }
            return lines;
        }
    }
}

