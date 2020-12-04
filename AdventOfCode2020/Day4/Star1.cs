using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day4
{
    public class Star1
    {
        public static int GetValidPassports()
        {
            int numValidPassports = 0;
            string[] validFields = new[] { "byr:", "iyr:", "eyr:", "hgt:", "hcl:", "ecl:", "pid:" };
            string path = Environment.CurrentDirectory + @"\input.dat";

            if (File.Exists(path))
            {
                List<string> uniquePassports = Passport.JoinPassportInfoToUnique(path);

                numValidPassports = uniquePassports.Select(passport => validFields.All(field => passport.Contains(field)))
                        .Where(x => x == true)
                        .Count();
            }

            return numValidPassports;
        }
    }
}
