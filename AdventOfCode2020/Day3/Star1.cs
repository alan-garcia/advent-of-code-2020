using System.Collections.Generic;

namespace Day3
{
    public class Star1
    {
        public static int GetNumberOfTrees(List<List<char>> map)
        {
            int rowCount = map[0].Count;
            int numberOfTrees = 0;
            int y = 0;

            for (int x = 0; x < map.Count; x++)
            {
                if (map[x][y] == '#')
                {
                    numberOfTrees++;
                }
                y = (y + 3) % rowCount;
            }

            return numberOfTrees;
        }
    }
}
