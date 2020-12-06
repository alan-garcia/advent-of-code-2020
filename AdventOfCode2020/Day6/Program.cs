using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> uniqueDistinctAnswers = new List<int>();
            string path = Environment.CurrentDirectory + @"\input.dat";

            if (File.Exists(path))
            {
                List<string> answers = File.ReadAllLines(path).ToList();
                int numberOfYesAnswers = Star1.GetNumberOfYesAnswers(answers);
                int numberOfYesAnswersEveryone = Star2.GetNumberOfYesAnswersEveryone(answers);

                Console.WriteLine(" --- STAR 1 ---");
                Console.WriteLine($"Number of yes answers: { numberOfYesAnswers }");
                Console.WriteLine();

                Console.WriteLine(" --- STAR 2 ---");
                Console.WriteLine($"Number of yes answers everyone: { numberOfYesAnswersEveryone }");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
