using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bit
    {
        //https://leetcode.com/explore/featured/card/may-leetcoding-challenge/534/week-1-may-1st-may-7th/3319/
        public static int FindComplement(int num)
        {
            StringBuilder binary = new StringBuilder(Convert.ToString(num, 2));
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                    binary[i] = '1';
                else
                    binary[i] = '0';
            }
            return Convert.ToInt32(binary.ToString(), 2);
        }

        public int FindComplement2(int num)
        {
            // bitmask has the same length as num and contains only ones 1...1
            int bitmask = num;
            bitmask |= (bitmask >> 1);
            bitmask |= (bitmask >> 2);
            bitmask |= (bitmask >> 4);
            bitmask |= (bitmask >> 8);
            bitmask |= (bitmask >> 16);
            // flip all bits 
            return bitmask ^ num;
        }
    }
}
