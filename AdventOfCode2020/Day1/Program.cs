using AdventOfCode2020.Star1;
using AdventOfCode2020.Star2;
using System;

namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int star1 = Star1.GetMultiplyExpensesEqualsTo2020();
            int star2 = Star2.GetMultiplyExpensesEqualsTo2020();

            Console.WriteLine($"Star 1: { star1 }");
            Console.WriteLine($"Star 2: { star2 }");
            Console.ReadKey();
        }
    }
}
