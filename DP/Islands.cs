using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Islands
    {
        public void Count(int[][] map)
        {
            Print(map);

            int count = 0;
            for (int y = 0; y < map.Length; y++)
            {
                for (int x = 0; x < map[y].Length; x++)
                {
                    if (map[y][x] == 1)
                    {
                        count++;
                        SinkIsland(map, x, y);
                        Print(map);
                    }
                }
            }
        }

        void SinkIsland(int[][] map, int x, int y)
        {
            if (x < 0) return;
            if (y < 0) return;
            if (y >= map.Length) return;
            if (x >= map[y].Length) return;
            if (map[y][x] == 0) return;

            map[y][x] = 0;

            SinkIsland(map, x - 1, y);
            SinkIsland(map, x + 1, y);
            SinkIsland(map, x, y - 1);
            SinkIsland(map, x, y + 1);
        }

        void Print(int[][] map)
        {
            for (int y = 0; y < map.Length; y++)
            {
                for (int x = 0; x < map.Length; x++)
                {
                    Console.Write(map[y][x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
    }
}
