using System;

namespace Program
{
    class Program
    {
        //private static void Main(string[] args)
        public testc()
        {
            //Console.WriteLine("Enter the Year in Four Digits : ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //T = Number of Testcases
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                //First line consists of S, X and N, which denotes the starting point, destination point and number of paths respectively. 
                string[] sxn = new string[3];
                string sxnStr = Console.ReadLine();
                sxn = sxnStr.Split(' ');

                //Next line will contain N numbers that denote maximum speed limit of the paths.
                string speedStr = Console.ReadLine();
                string[] speed = new string[Convert.ToInt32(sxn[2])];
                speed = speedStr.Split(' ');

                int[] speedInt = Array.ConvertAll<string, int>(speed, int.Parse);

                //keep a copy of original array 
                int[] speedCopy = new int[speedInt.Length];
                Array.Copy(speedInt, speedCopy, speedInt.Length);

                //Sort the array of speed limit of th paths 
                int[] speedIntSorted = SortArrayAscending(speedInt);

                //Console.WriteLine(speedCopy[0] + " *speedCopy*" + speedCopy[1] + " " + speedCopy[2] + " ");

                //Get the Shortest Path
                Console.WriteLine(findShortestPath(speedCopy, speedIntSorted));

            }
            Console.ReadLine();
        }

        static int[] SortArrayAscending(int[] array1)
        {
            int temp;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int y = 0; y < array1.Length - 1 - i; y++)
                {
                    if (array1[y] > array1[y + 1])
                    {
                        temp = array1[y];
                        array1[y] = array1[y + 1];
                        array1[y + 1] = temp;
                    }

                }
            }
            return array1;
        }

        static string findShortestPath(int[] array1, int[] array1Sorted)
        {
            if (array1Sorted[array1Sorted.Length - 1] == array1Sorted[array1Sorted.Length - 2])
                return "Many Roads";
            else
            {
                //Console.WriteLine(array1[0] + " " + array1[1] + " " + array1[2] + " ");
                //Console.WriteLine(array1Sorted[0]+ " " +array1Sorted[1] + " "+ array1Sorted[2] + " ");
                //Console.WriteLine("array1" +Array.IndexOf(array1, array1Sorted[array1Sorted.Length - 1]));
                return (Array.IndexOf(array1, array1Sorted[array1Sorted.Length - 1]) + 1).ToString();
            }
        }
    }
}
