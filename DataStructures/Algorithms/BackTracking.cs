using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{

    public class BackTracking
    {
        List<string> permutations = new List<string>();
        public IList<string> LetterCasePermutation(string S)
        {

            char[] sChar = S.ToCharArray();

            int i = 0;
            int len = S.Length;
            NewPermutation(i, len, "", sChar);
            return permutations;

        }
        public void NewPermutation(int i, int len, string currentStr, char[] fullStringChar)
        {
            if (i <= len)
            {
                //Console.WriteLine("i "+i);
                //Console.WriteLine(currentStr);
                if (currentStr.Length == len)
                {

                    permutations.Add(currentStr);
                }
                else if (Char.IsLetter(fullStringChar[i]))
                {
                    NewPermutation(i + 1, len, currentStr + Char.ToLower(fullStringChar[i]), fullStringChar);
                    NewPermutation(i + 1, len, currentStr + Char.ToUpper(fullStringChar[i]), fullStringChar);
                }
                else
                {
                    NewPermutation(i + 1, len, currentStr + fullStringChar[i], fullStringChar);
                }
            }

        }
    }
}
