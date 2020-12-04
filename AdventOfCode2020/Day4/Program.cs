using System;

namespace Day4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numValidPassports_Star1 = Star1.GetValidPassports();
            int numValidPassports_Star2 = Star2.GetValidPassports();

            Console.WriteLine(" --- STAR 1 ---");
            Console.WriteLine($"Number of valid passports: { numValidPassports_Star1 }");
            Console.WriteLine();

            Console.WriteLine(" --- STAR 2 ---");
            Console.WriteLine($"Number of valid passports: { numValidPassports_Star2 }");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
