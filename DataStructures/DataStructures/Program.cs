using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worldlk!");
            //Console.ReadKey();
            Console.WriteLine("Hello World");
            BinarySearchTree bst = new BinarySearchTree();
            bst.insert(9);
            bst.insert(4);
            bst.insert(6);
            bst.insert(20);
            bst.insert(170);
            bst.insert(15);
            bst.insert(1);
            string jsonString;
            jsonString = JsonSerializer.Serialize(bst.Traverse(bst.root));


            //Console.WriteLine(jsonString);


            //Console.WriteLine("Look up 9");
            //int temp = Convert.ToInt32(Console.ReadLine());
            //Node x = bst.lookup(temp);
            //Console.WriteLine(x==null? "null":x.value.ToString());


            //Console.WriteLine("REmove 4");
            //bst.remove(4);
            //jsonString = JsonSerializer.Serialize(bst.Traverse(bst.root));
            //Console.WriteLine(jsonString);

            //Console.WriteLine("REmove 20");
            //bst.remove(20);
            //jsonString = JsonSerializer.Serialize(bst.Traverse(bst.root));
            //Console.WriteLine(jsonString);

            //int[] array1 = { 2, 3, 4, 4, 3 };
            //Console.WriteLine(FirstRecurringValue(array1));

            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            IList<int> x = TopKFrequent(nums, k);
            for(int i=0;i<x.Count;i++)
            {
                Console.WriteLine(x[i]);
            }

            Console.ReadKey();
        }
        public static  int? FirstRecurringValue(int[] array1)
        {
            Hashtable h = new Hashtable();
            for (int i = 0; i < array1.Length; i++)
            {
                if (h.ContainsKey(array1[i]))
                {
                    return array1[i];                }
                    
                else h.Add(array1[i], 1);
            }
            return null;
        }


        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            //Dictionary<int,int> count = new Dictionary<int,int>();

            //return count.Keys.Take(k).ToList();

            SortedDictionary<int,int> count = new SortedDictionary<int,int>();
            for(int i=0;i<nums.Length;i++){
                if(count.ContainsKey(nums[i]))
                    count[nums[i]] +=1;
                else 
                {
                    count.Add(nums[i], 1);
                }
            }
            return count.Keys.Take(k).ToList();

            //return new List<int>();
        }
    }
}
