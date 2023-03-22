using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class BarnBuildSimple
    {
        public int SimpleEnumeration(int[][] map)
        {
            int maxSize = 0;
            for (int y = 0; y < map.Length; y++)
            {
                for (int x = 0; x < map[y].Length; x++)
                {
                    if (map[y][x] == 0)
                    {
                        int currentSize = GetMaxSize(map, y, x);

                        if (maxSize < currentSize)
                            maxSize = currentSize;
                    }
                }
            }
            return maxSize;
        }
        int GetMaxSize(int[][] map, int y, int x)
        {
            int maxSize = 1;
            int tempMaxSize = 1;
            int height = 1;
            int maxWidth = map[y].Length;

            while (y < map.Length && map[y][x] == 0)
            {
                int tempX = x;
                int width = 1;
                while (width < maxWidth && tempX < map[y].Length)
                {
                    if (map[y][tempX] == 0)
                    {
                        tempMaxSize = height * width;
                        width++;
                        tempX++;
                    }
                    else
                    {
                        maxWidth = width;
                        break;
                    }
                }
                if (maxSize < tempMaxSize)
                    maxSize = tempMaxSize;

                y++;
                height++;
            }
            return maxSize;
        }

    }
}
