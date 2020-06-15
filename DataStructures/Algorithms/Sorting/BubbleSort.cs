using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class BubbleSortAlgo
    {
        public static string BubbleSort(int[] array)
        {
            Dictionary<int, int> swaps = new Dictionary<int, int>();
            for(int i=0;i<array.Length;i++)
            {
                if (swaps.Select(x => x.Value > 2).FirstOrDefault())
                {
                    return "Too chaotic";
                }
                for (int j=0;j<array.Length-1;j++)
                {
                    if(array[j] > array[j+1])
                    {
                        if (swaps.ContainsKey(array[j]))
                            swaps[array[j]] += 1;
                        else
                            swaps.Add(array[j], 1);
                        array = Swap(array, j, j + 1);                        
                    }

                }
                
            }
            int val = swaps.Values.Sum();
            return val.ToString();
        }
        public static int[] BubbleSortBAckup(int[] array)
        {
            Dictionary<int, int> swaps = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        if (swaps.ContainsKey(array[j]))
                            swaps[array[j]] += 1;
                        else
                            swaps.Add(array[j], 1);
                        array = Swap(array, j, j + 1);
                    }

                }
            }
            foreach (KeyValuePair<int, int> entry in swaps)
                Console.WriteLine(entry.Key + " " + entry.Value);
            return array;
        }
        private static int[] Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            return array;
        }
    }
}
