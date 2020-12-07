using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day7
{
    public class Star1
    {
        public static Dictionary<string, Dictionary<string, int>> GetBagsWithGroupQuantities(List<string> allBags)
        {
            Regex regularExpr = new Regex(@"(.*?) bags contain(?: (\d+ .*?) bag(?:s)?[,.])*", RegexOptions.Compiled);

            var allBagsWithQuantities = allBags.Select(x => regularExpr.Match(x))
                .ToDictionary(
                    regMatch => regMatch.Groups[1].Value,
                    regMatch => regMatch.Groups[2].Captures.OfType<Capture>()
                        .Select(capture => capture.Value.Split(new[] { ' ' }, 2))
                        .ToDictionary(quantity => quantity[1], quantity => int.Parse(quantity[0]))
                );

            return allBagsWithQuantities;
        }
    }
}
