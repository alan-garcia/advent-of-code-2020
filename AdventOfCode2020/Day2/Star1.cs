using System;
using System.IO;
using System.Linq;

namespace Day2
{
    public class Star1
    {
        public static int GetSuccessNumLettersPolicies()
        {
            string path = Environment.CurrentDirectory + @"\input.dat";
            string[] passwordPolicies = File.ReadAllLines(path);
            int totalSuccessPolicies = 0;

            if (File.Exists(path))
            {
                foreach (var passwordPolicy in passwordPolicies)
                {
                    string rangeNumOfOcurrencies = passwordPolicy.Split()[0];
                    string letter = passwordPolicy.Split()[1].Replace(":", "");
                    string password = passwordPolicy.Split()[2];

                    int minOcurrencies = int.Parse(rangeNumOfOcurrencies.Split('-')[0]);
                    int maxOcurrencies = int.Parse(rangeNumOfOcurrencies.Split('-')[1]);

                    var numLettersOcurrencies = password.Count(let => let.ToString() == letter);
                    if (numLettersOcurrencies >= minOcurrencies && numLettersOcurrencies <= maxOcurrencies)
                    {
                        totalSuccessPolicies++;
                    }
                }
            }

            return totalSuccessPolicies;
        }
    }
}
