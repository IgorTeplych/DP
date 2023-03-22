using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class DigitalSpruce
    {
        public int GetMaxWay(int[][] tree)
        {
            for (int i = tree.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    tree[i][j] = Math.Max(tree[i + 1][j], tree[i + 1][j + 1]) + tree[i][j];
                }
            }
            return tree[0][0];
        }
    }
}
