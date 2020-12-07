using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + @"\input.dat";
            if (File.Exists(path))
            {
                List<string> allBags = File.ReadAllLines(path).ToList();
                var allBagsWithQuantities = Star1.GetBagsWithGroupQuantities(allBags);

                bool BagContains(string color) => allBagsWithQuantities[color].ContainsKey("shiny gold") || allBagsWithQuantities[color].Keys.Any(BagContains);
                int relatedBagsContainsShinyGold = allBagsWithQuantities.Keys.Count(BagContains);

                Console.WriteLine(" --- STAR 1 ---");
                Console.WriteLine($"Number of related bags that contains 'shiny gold' bag: { relatedBagsContainsShinyGold }");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
