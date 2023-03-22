using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class FiveEight
    {
        /// <summary>
        /// Возвращает количество чисел, которое можно составить из двух num1 и num2 с числом разрядов N
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="N"></param>
        public int Solve(int num1, int num2, int N)
        {
            int[][] mass = new int[N + 1][];
            mass[0] = new int[] { 1, 0, 1, 0 };

            for (int i = 1; i <= N; i++)
            {
                mass[i] = new int[]
                {
                    mass[i - 1][2] + mass[i - 1][3],
                    mass[i - 1][0],
                    mass[i - 1][0] + mass[i - 1][1],
                    mass[i - 1][2]
                };
            }

            int num = 0;
            for (int i = 0; i < mass[mass.Length - 1].Length; i++)
            {
                num += mass[mass.Length - 1][i];
            }
            return num;
        }
    }
}
