using System;
using System.IO;
using System.Linq;

namespace Day2
{
    public class Star2
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
                    string rangeNumberOfOcurrencies = passwordPolicy.Split()[0];
                    string letter = passwordPolicy.Split()[1].Replace(":", "");
                    string password = passwordPolicy.Split()[2];

                    int minOcurrencies = int.Parse(rangeNumberOfOcurrencies.Split('-')[0]);
                    int maxOcurrencies = int.Parse(rangeNumberOfOcurrencies.Split('-')[1]);

                    string first = password[minOcurrencies - 1].ToString();
                    string second = password[maxOcurrencies - 1].ToString();

                    if ((first == letter && second != letter) || (first != letter && second == letter))
                    {
                        totalSuccessPolicies++;
                    }
                }
            }

            return totalSuccessPolicies;
        }
    }
}
