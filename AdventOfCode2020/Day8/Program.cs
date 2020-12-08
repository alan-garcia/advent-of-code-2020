using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + @"\input.dat";
            if (File.Exists(path))
            {
                List<string> instructions = File.ReadAllLines(path).ToList();
                int totalAccumulator = Star1.GetTotalAccumulator(instructions);

                Console.WriteLine(" --- STAR 1 ---");
                Console.WriteLine($"Total accumulator: { totalAccumulator }");
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
