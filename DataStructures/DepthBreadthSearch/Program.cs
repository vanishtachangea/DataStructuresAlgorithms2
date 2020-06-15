using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthBreadthSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World?");
            //Console.WriteLine(Fib(6).ToString());

            //Dictionary<int, int> memoization = new Dictionary<int, int>();
            //Console.WriteLine(FibMemo(6, memoization).ToString());
            //int n = 32;
            //char[] numchars = n.ToString().ToCharArray();
            //Console.WriteLine(numchars[1]);
            ////Console.WriteLine(IsHappy(101));
            //Console.WriteLine("Dynamic Programming");

            //Dictionary<int, int> memoization2 = new Dictionary<int, int>();
            //Console.WriteLine(DynamicProgramming.MemoisedAddTo80(5, memoization2));
            //Console.WriteLine(DynamicProgramming.MemoisedAddTo80(53, memoization2));

            //Console.WriteLine("Search Algorithm");
            //string[] list1 ={"apple","banana", "carrot", "orange"};
            //getArrayInfo(list1);
            

            Console.ReadKey();
        }
        public static bool IsHappy(int n)
        {
            char[] numChars = n.ToString().ToCharArray();
            int sum = 0;
            for (int i = 0; i < numChars.Length; i++)
            {
                sum += (Int32.Parse(numChars[i].ToString()) * Int32.Parse(numChars[i].ToString()));
            }
            if (sum == 1)
                return true;
            else
                return IsHappy(sum);
        }

        //Fibonacci : 0,1,1,2,3,5,8,13,21
        public static int Fib(int n) //0(n2) Time
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
        public static int FibMemo(int n, Dictionary<int, int> memoization) //o(n) Time
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (!memoization.ContainsKey(n))
            {
                memoization[n] = FibMemo(n - 1, memoization) + FibMemo(n - 2, memoization);
            }
            return memoization[n];
        }

        public static int countPathsMatrix(int[,] grid, int row, int col)
        {
            if (!ValidSquare(grid, row, col)) return 0;
            if (IsAtEnd(grid, row, col)) return 1;
            return countPathsMatrix(grid, row + 1, col) + countPathsMatrix(grid, row, col + 1);
        }
        public static bool ValidSquare(int[,] grid, int row, int col)
        {
            if (grid[row, col] == 0)
                return true;
            return false;
        }
        public static bool IsAtEnd(int[,] grid, int row, int col)
        {
            if (row == (grid.GetLength(0) - 1) && col == (grid.GetLength(0) - 1))
                return true;
            return false;
        }
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/submissions/
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minPrice;
            if (prices.Length > 0)
                minPrice = prices[0];
            else
                minPrice = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                if (prices[i] - minPrice > maxProfit)
                    maxProfit = prices[i] - minPrice;
            }
            return maxProfit;
        }

        public static void getArrayInfo(string[] array1)
        {
            Console.WriteLine(Array.IndexOf(array1,"carrot"));
        }
    }
    public class Graph
    {
        private Dictionary<int, Node> NodeLookup = new Dictionary<int, Node>();

        public class Node
        {
            public int id;
            public LinkedList<Node> Adjacent = new LinkedList<Node>();
            private Node(int id)
            {
                this.id = id;
            }
        }


        private Node GetNode(int id)
        {
            return NodeLookup[id];
        }
        public void AddEdge(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            s.Adjacent.AddLast(d);
        }

        public bool HasPathDFS(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            HashSet<int> Visited = new HashSet<int>();
            return HasPathDFS(s, d, Visited);

        }
        private bool HasPathDFS(Node sourceNode, Node destinationNode, HashSet<int> visited)
        {
            if (visited.Contains(sourceNode.id))
                return false;
            visited.Add(sourceNode.id);
            if (sourceNode == destinationNode)
                return true;
            foreach (Node child in sourceNode.Adjacent)
            {
                if (HasPathDFS(child, destinationNode, visited))
                    return true;
            }
            return false;
        }

        public bool HasPathBFS(int source, int destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            return HasPathBFS(s, d);
        }
        private bool HasPathBFS(Node sourceNode, Node destinationNode)
        {
            LinkedList<Node> nextToVisit = new LinkedList<Node>();
            HashSet<int> Visited = new HashSet<int>();
            nextToVisit.AddLast(sourceNode);
            while (nextToVisit.Count > 0)
            {
                Node currentNode = nextToVisit.First<Node>();
                nextToVisit.RemoveFirst();
                if (currentNode == destinationNode)
                    return true;
                if (Visited.Contains(currentNode.id))
                    continue;
                Visited.Add(currentNode.id);
                foreach (Node child in currentNode.Adjacent)
                {
                    nextToVisit.AddLast(child);
                }
            }
            return false;
        }

    }
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> visited = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!visited.Contains(nums[i]))
                    visited.Add(nums[i]);
                else
                    duplicates.Add(nums[i]);
            }
            visited.ExceptWith(duplicates);
            Console.WriteLine(visited.Count);
            return visited.First();
        }
    }
    class DynamicProgramming
    {
        public static int MemoisedAddTo80(int number, Dictionary<int, int> memoized)
        {
            if (memoized.ContainsKey(number))
                return memoized[number];
            else
            {
                Console.WriteLine("long");
                memoized[number] = 80 + number;
            }
                

            return memoized[number];

        }
    }
}
