using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class LeetCodeLockDownChallenge
    {

        public static Dictionary<int, int> Squares = new Dictionary<int, int>();
        public static Dictionary<int, int> Sums = new Dictionary<int, int>();

        //https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/528/week-1/3284/
        public static bool IsHappy(int n)
        {
            int sum = n;
            int i = 0;
            int oldSum = 0;
            if (n == 1)
                return true;
            while (sum != 1)
            {
                i += 1;
                oldSum = sum;
                //Console.WriteLine(sum);
                if (Sums.ContainsKey(oldSum))
                {
                    sum = Sums[oldSum];
                    if (sum == 1)
                        return true;
                }
                sum = GetSum(oldSum);
                if (Sums.ContainsKey(oldSum))
                    return false;

               Sums.Add(oldSum, sum);
                //Console.WriteLine("sum " + sum);
                if (sum == 1)
                    return true;


            }

            return false;
        }
        public static int GetSum(int n)
        {
            int sum = 0;
            int number = 0;
            foreach (char c in n.ToString().ToCharArray())
            {
                //Console.WriteLine(c);
                number = 0;
                number = Int16.Parse(c.ToString());
                //Console.WriteLine("number" + number);
                if (Squares.ContainsKey(number))
                    sum += Squares[number];
                else
                {

                    int s = number * number;
                    //Console.WriteLine(s);

                    Squares[number] = s;
                    sum += s;
                }
            }

            return sum;


        }
    }
}

