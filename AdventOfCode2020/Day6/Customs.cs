using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class Customs
    {
        public static List<string> GetUnionAllAnswers(List<string> input)
        {
            return string.Join(" ", input.ToArray())
                .Split(new[] { "  " }, StringSplitOptions.None) // Join all characters through whitespace characters (in this case, express "NewLine" characters) into an array.
                .Select(x => x.Replace(" ", string.Empty)) // Remove whitespaces from each line answers.
                .ToList();
        }
    }
}
