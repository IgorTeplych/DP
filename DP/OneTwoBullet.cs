using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class OneTwoBullet
    {
        /// <summary>
        /// Формат формулы "a/b+c/d"
        /// </summary>
        /// <param name="formula"></param>
        public string Solve(string formula)
        {
            var term1 = ParseFraction(formula.Split('+')[0]);
            var term2 = ParseFraction(formula.Split('+')[1]);

            var sum = Solve(term1.Item1, term1.Item2, term2.Item1, term2.Item2);

            return sum.Item1.ToString() + '/' + sum.Item2.ToString();
        }

        (int, int) ParseFraction(string fract)
        {
            var nums = fract.Split('/');
            return (Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]));
        }

        (int, int) Solve(int num1, int denom1, int num2, int denom2)
        {
            int commonDenom = denom1 * denom2;
            int commonNum = num1 * denom2 + num2 * denom1;
            int gcd = GCD(commonNum, commonDenom);
            return ((commonNum / gcd), (commonDenom / gcd));
        }

        int GCD(int num1, int num2)
        {
            if (num1 == 0)
                return num2;
            if (num2 == 0)
                return num1;

            if (IsEven(num1) && IsEven(num2))
                return GCD(num1 >> 1, num2 >> 1) << 1;

            if (IsEven(num1) && !IsEven(num2))
                return GCD(num1 >> 1, num2);

            if (!IsEven(num1) && IsEven(num2))
                return GCD(num1, num2 >> 1);

            if (num1 > num2)
                return GCD((num1 - num2) >> 1, num2);

            return GCD(num1, (num2 - num1) >> 1);
        }

        bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
    }
}
