using System.Collections.Generic;

namespace Day3
{
    public class Star2
    {
        public static int GetNumberOfTrees(List<List<char>> map, int moveToRight, int moveToDown)
        {
            int rowCount = map[0].Count;
            int numberOfTrees = 0;
            int y = 0;

            for (int x = 0; x < map.Count; x += moveToDown)
            {
                if (map[x][y] == '#')
                {
                    numberOfTrees++;
                }
                y = (y + moveToRight) % rowCount;
            }

            return numberOfTrees;
        }
    }
}
