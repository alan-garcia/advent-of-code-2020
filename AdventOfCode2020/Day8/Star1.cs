using System.Collections.Generic;

namespace Day8
{
    public class Star1
    {
        public static int GetTotalAccumulator(List<string> instructions)
        {
            int accumulator = 0;
            List<int> seen = new List<int>();

            for (int i = 0; !seen.Contains(i); i++)
            {
                seen.Add(i);
                string operation = instructions[i].Split()[0];
                int argument = int.Parse(instructions[i].Split()[1]);

                if (operation == "acc")
                {
                    accumulator += argument;
                }
                else if (operation == "jmp")
                {
                    i += argument - 1;
                }
            }

            return accumulator;
        }
    }
}
