using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + @"\input.dat";
            List<List<char>> map = File.ReadAllLines(path).Select(row => row.ToCharArray().ToList())
                                    .ToList();

            List<int> allTrees = new List<int>();

            if (File.Exists(path))
            {
                int numOfTrees_Star1 = Star1.GetNumberOfTrees(map);
                Console.WriteLine(" --- STAR 1 ---");
                Console.WriteLine($"Number of trees: { numOfTrees_Star1 }");
                Console.WriteLine();

                allTrees.Add(Star2.GetNumberOfTrees(map, 1, 1));
                allTrees.Add(Star2.GetNumberOfTrees(map, 3, 1));
                allTrees.Add(Star2.GetNumberOfTrees(map, 5, 1));
                allTrees.Add(Star2.GetNumberOfTrees(map, 7, 1));
                allTrees.Add(Star2.GetNumberOfTrees(map, 1, 2));

                Console.WriteLine(" --- STAR 2 ---");
                Console.WriteLine($"Number of trees: { allTrees.Aggregate(1, (right, down) => right * down) }");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
