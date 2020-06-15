using System;
using System.Collections;
using System.Text.Json;
namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
           

            Console.WriteLine(jsonString);


            Console.WriteLine("Look up 9");
            int temp = Convert.ToInt32(Console.ReadLine());
            Node x = bst.lookup(temp);
            Console.WriteLine(x==null? "null":x.value.ToString());


            Console.WriteLine("REmove 4");
            bst.remove(4);
            jsonString = JsonSerializer.Serialize(bst.Traverse(bst.root));
            Console.WriteLine(jsonString);

            Console.WriteLine("REmove 20");
            bst.remove(20);
            jsonString = JsonSerializer.Serialize(bst.Traverse(bst.root));
            Console.WriteLine(jsonString);

            int[] array1 = { 2, 3, 4, 4, 3 };
            Console.WriteLine(FirstRecurringValue(array1));
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
    }
}
