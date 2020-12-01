using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Star1
{
    public class Star1
    {
        public static int GetMultiplyExpensesEqualsTo2020()
        {
            string pathExpenses = Environment.CurrentDirectory + @"\input.dat";
            int result = 0;

            List<int> expenses = File.ReadAllLines(pathExpenses).Select(number => int.Parse(number)).ToList();
            expenses.ForEach(expense1 => expenses.ForEach(expense2 =>
            {
                if (expense1 + expense2 == 2020)
                {
                    result = expense1 * expense2;
                }
            }));

            return result;
        }
    }
}
