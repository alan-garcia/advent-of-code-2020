using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Day4
{
    public class Passport
    {
        public static List<string> JoinPassportInfoToUnique(string path)
        {
            StringBuilder currentInfoPassport = new StringBuilder();
            List<string> uniquePassports = new List<string>();
            List<string> passports = File.ReadAllLines(path).ToList();

            foreach (var passport in passports)
            {
                if (!string.IsNullOrWhiteSpace(passport))
                {
                    currentInfoPassport.Append(passport + " ");
                }
                else
                {
                    uniquePassports.Add(currentInfoPassport.ToString().Remove(currentInfoPassport.ToString().Length - 1));
                    currentInfoPassport = new StringBuilder();
                }
            }

            return uniquePassports;
        }

        public static bool ValidateFields(Dictionary<string, string> fields)
        {
            int numberOfFields = 0;

            if (fields.ContainsKey("byr"))
            {
                numberOfFields++;
                int.TryParse(fields["byr"], out int birthYear);
                if (birthYear < 1920 && birthYear > 2020)
                {
                    return false;
                }
            }

            if (fields.ContainsKey("iyr"))
            {
                numberOfFields++;
                int.TryParse(fields["iyr"], out int issueYear);
                if (issueYear < 2010 && issueYear > 2020)
                {
                    return false;
                }
            }

            if (fields.ContainsKey("eyr"))
            {
                numberOfFields++;
                int.TryParse(fields["eyr"], out int expirationYear);
                if (expirationYear < 2020 && expirationYear > 2030)
                {
                    return false;
                }
            }

            if (fields.ContainsKey("hgt"))
            {
                numberOfFields++;
                string hgt = fields["hgt"];
                if (hgt.EndsWith("cm"))
                {
                    int.TryParse(hgt.Substring(0, hgt.Length - 2), out int height);
                    if (height < 150 || height > 193)
                    {
                        return false;
                    }
                }
                else if (hgt.EndsWith("in"))
                {
                    int.TryParse(hgt.Substring(0, hgt.Length - 2), out int height);
                    if (height < 59 || height > 76)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            if (fields.ContainsKey("hcl"))
            {
                numberOfFields++;
                bool hairColor = Regex.IsMatch(fields["hcl"], "^(?!(#[a-f|0-9]{6})$).*");
                if (hairColor)
                {
                    return false;
                }
            }

            if (fields.ContainsKey("ecl"))
            {
                numberOfFields++;
                bool eyeColorIsValid = Regex.IsMatch(fields["ecl"], "^(?!(amb|blu|brn|gry|grn|hzl|oth)$).*");
                if (eyeColorIsValid)
                {
                    return false;
                }
            }

            if (fields.ContainsKey("pid"))
            {
                numberOfFields++;
                bool passportIdIsValid = Regex.IsMatch(fields["pid"], "^(?!([0-9]{9})$).*");
                if (passportIdIsValid)
                {
                    return false;
                }
            }

            if (numberOfFields < 7)
            {
                return false;
            }

            return true;
        }
    }
}
