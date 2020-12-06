using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class Star2
    {
        public static int GetNumberOfYesAnswersEveryone(List<string> input)
        {
            List<string> uniqueAnswers = Customs.GetUnionAllAnswers(input);

            int everyoneAnswers = uniqueAnswers
                .Select(answer => answer.Split('\n')
                    .Aggregate((a, b) => string.Concat(b.Intersect(a)))
                    .Count())
                .Sum();

            return everyoneAnswers;
        }
    }
}
