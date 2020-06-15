using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SortingAlgorithms
    {
        //Divide and Conquer
        //Time Complexity: O(n log n)
        //Space Complexity: O(n)
        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;
            //Split the array into 2 
 
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];
            Array.Copy(array, 0, left, 0, leftSize);
            Array.Copy(array, leftSize, right, 0, rightSize);
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);

            //return Merge(MergeSort(left), MergeSort(right));

        }
        protected static int[] Merge(int[] left, int[] right)
        {
            int leftIndex = 0, rightIndex = 0;
            //int k=0;
            int[] sorted = new int[left.Length + right.Length];

            for(int k=0;k<sorted.Length;k++)
            {
                if (leftIndex == left.Length)
                {
                    sorted[k] = right[rightIndex];
                    rightIndex++;

                }
                else if (rightIndex == right.Length)
                {
                    sorted[k] = left[leftIndex];
                    leftIndex++;
                }
                else if (left[leftIndex] < right[rightIndex])
                {
                    sorted[k]=left[leftIndex];
                    leftIndex++;
                }

                else
                {
                    sorted[k] = right[rightIndex];
                    rightIndex++;
                }
            }

            GraphQuestions.DisplayCells(left);
            GraphQuestions.DisplayCells(right);
            GraphQuestions.DisplayCells(sorted);
            Console.WriteLine(".....");
            return sorted;
        }


        //Non-Comparison 
        //Time Complexity : O(nk)
        //Space Complexity: O(n+k)
        public static int[] RadixSort(int[] array)
        {
            return array;
        }
    }
}
