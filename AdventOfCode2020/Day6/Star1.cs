using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class Star1
    {
        public static int GetNumberOfYesAnswers(List<string> input)
        {
            List<string> uniqueAnswers = Customs.GetUnionAllAnswers(input);
            List<int> uniqueDistinctAnswers = new List<int>();

            uniqueAnswers.ForEach(uniqueAnswer => uniqueDistinctAnswers.Add(uniqueAnswer.Distinct().Count()));

            return uniqueDistinctAnswers.Sum();
        }
    }
}
