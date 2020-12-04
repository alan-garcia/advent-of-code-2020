using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day4
{
    public class Star2
    {
        public static int GetValidPassports()
        {
            int numValidPassports = 0;
            string[] validFields = new[] { "byr:", "iyr:", "eyr:", "hgt:", "hcl:", "ecl:", "pid:" };
            string path = Environment.CurrentDirectory + @"\input.dat";

            if (File.Exists(path))
            {
                List<string> uniquePassports = Passport.JoinPassportInfoToUnique(path);
                foreach (var passport in uniquePassports)
                {
                    Dictionary<string, string> fields = passport.Split().ToDictionary(k => k.Split(':')[0], v => v.Split(':')[1]);
                    if (Passport.ValidateFields(fields))
                    {
                        numValidPassports++;
                    }
                }
            }

            return numValidPassports;
        }
    }
}
