using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public  static class QuickSortAlgo
    {

        public  static int[] QuickSort(int[] array, int left, int right)
        {
            if(left<right)
            {
                int pivot = array[(left + right) / 2];
                int index = Partition(array, left, right, pivot);
                QuickSort(array, left, index - 1);
                QuickSort(array, index, right);
            }
            return array;
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while(left<=right)
            {
                while(array[left]<pivot)
                {
                    left++;
                }
                while(array[right]>pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    array = Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
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
