using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numPoliciesStar1 = Star1.GetSuccessNumLettersPolicies();
            int numPoliciesStar2 = Star2.GetSuccessNumLettersPolicies();

            Console.WriteLine($"Star 1: { numPoliciesStar1 }");
            Console.WriteLine($"Star 2: { numPoliciesStar2 }");
            Console.ReadKey();
        }
    }
}
