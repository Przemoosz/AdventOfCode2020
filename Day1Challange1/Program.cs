using System;
using System.IO;

namespace AdventOfCode
{
    internal class SolutionDay1
    {
        public static void Main(string[] args)
        {
            // Utils.FileRead();
            string[] data = Utils.FileRead();
            List <int> convertedData = IntListCreate(data);
            // foreach(int i in convertedData)
            //     Console.WriteLine(i+20);
            foreach (var value in convertedData)
            {
                if (convertedData.Contains(2020 - value))
                {
                    int secondElement = 2020 - value;
                    Console.WriteLine($"First Element {value}");
                    Console.WriteLine($"Second Element {secondElement}");
                    Console.WriteLine($"Answer: {value*secondElement}");
                    break;
                }

            }
           //
        }

        public static List<int> IntListCreate(string[] loadedData)
        {
            List<int> toReturn = new List<int>(loadedData.Length);
            foreach (string number in loadedData)
            {
                toReturn.Add(Convert.ToInt32(number));
            }
            //foreach(int a in toReturn) Console.WriteLine(a.GetType);
            return toReturn;
        }
    }

    static class Utils
    {
        public static string[] FileRead()
        {
            int rows = File.ReadLines(@"C:\Przemek\Net and C#\AdventOfCode\Day1Challange1\input.txt").Count();
            string[] lines = new string[rows];
            int index = 0;
            //Console.WriteLine(rows);
            foreach (string row in File.ReadLines(@"C:\Przemek\Net and C#\AdventOfCode\Day1Challange1\input.txt"))
            {
                lines[index] = row.Trim();
                index++;
            }
            // foreach (string row in lines) Console.WriteLine(row);
            return lines;
        }
    }
}