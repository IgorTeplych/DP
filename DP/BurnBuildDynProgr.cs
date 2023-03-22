using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class BurnBuildDynProgr
    {
        int[] L;
        int[] R;
        int[] line;
        int[][] map;
        int N;
        public int Solve(int[][] map)
        {
            this.map = map;
            N = map.Length;
            line = new int[N];
            L = new int[N];
            R = new int[N];

            int maxSquare = 0;
            for (int y = 0; y < map.Length; y++)
            {
                CalcLineHeights(y);
                CalcR(y);
                CalcL(y);

                for (int x = 0; x < N; x++)
                {
                    int height = line[x];
                    int width = R[x] - L[x] + 1;
                    int square = height * width;
                    if (maxSquare < square)
                        maxSquare = square;
                }
            }
            return maxSquare;
        }
        void CalcR(int y)
        {
            Stack<int> stack = new Stack<int>();
            for (int x = 0; x < N; x++)
            {
                while (stack.Count > 0)
                {
                    if (line[stack.Peek()] > line[x])
                    {
                        R[stack.Pop()] = x - 1;
                    }
                    else
                    {
                        break;
                    }
                }
                stack.Push(x);
            }
            while (stack.Count == 0)
                R[stack.Pop()] = N - 1;
        }
        void CalcL(int y)
        {
            Stack<int> stack = new Stack<int>();
            for (int x = N - 1; x >= 0; x--)
            {
                while (stack.Count > 0)
                {
                    if (line[stack.Peek()] > line[x])
                    {
                        L[stack.Pop()] = x + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                stack.Push(x);
            }
            while (stack.Count == 0)
                L[stack.Pop()] = 0;
        }

        void CalcLineHeights(int y)
        {
            for (int x = 0; x < map.Length; x++)
            {
                if (map[x][y] > 0)
                    line[x] = 0;
                else
                    line[x]++;
            }
        }
    }
}
