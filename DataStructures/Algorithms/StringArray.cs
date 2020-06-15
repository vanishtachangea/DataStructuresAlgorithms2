using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class StringArray
    {
        //https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/2961/
        //https://leetcode.com/problems/longest-substring-without-repeating-characters/
        public static int LengthOfLongestSubstring(string s)
        {
            Dictionary<int, int> subStrings = new Dictionary<int, int>();
            HashSet<int> subStringTemp = new HashSet<int>();
            char[] sChars = s.ToCharArray();
            int i = 0, j = 0;
            int max = 0;
            int size = sChars.Length;
            while (i < size && j < size)
            {
                if (subStringTemp.Contains(sChars[j]))
                {
                    max = Math.Max(max, subStringTemp.Count);
                    subStringTemp = new HashSet<int>();
                    i += 1;
                    j = i;
                }
                else
                {
                    subStringTemp.Add(sChars[j]);

                    if (j == size - 1)
                    {
                        i += 1;
                        j = i;
                        max = Math.Max(max, subStringTemp.Count);
                        subStringTemp = new HashSet<int>();
                    }
                    else
                        j += 1;
                }



            }


            return max;

        }
    }
}
