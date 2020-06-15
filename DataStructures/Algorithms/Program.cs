using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int[,] trust = { { 1, 3 }, { 2, 3 } };
            //int[][] trust = { new int[] { 1, 3 }, new int[] { 2,6} };
            //int[][] trust = { new int[] { 1,3}, new int[] { 2,3}, new int[] { 3,1}};
            //Console.WriteLine(GraphQuestions.FindJudge(3,trust));

            //int[][] trust2 = { new int[]  { 1, 2 } };
            //Console.WriteLine(GraphQuestions.FindJudge(2, trust2));

            int[][] trust3 = { new int[] { } };
            //Console.WriteLine(GraphQuestions.FindJudge(1, trust3));
            // int[][] jaggedArray = new int[2][];
            // Console.WriteLine(jaggedArray.Length);
            // Console.WriteLine(jaggedArray.GetLength(0));


            // jaggedArray[0][0] = 33;
            //jaggedArray[0][1] = 44;
            //jaggedArray[1][0] = 33;
            //jaggedArray[1][1] = 44;
            //jaggedArray[2][0] = 33;
            //jaggedArray[2][1] = 44;
            //jaggedArray[0] = new int[1] { 20 };
            //jaggedArray[1] = new int[3] { 11, 22, 33 };

            // Console.WriteLine(jaggedArray[0].GetLength(0));
            // Console.WriteLine(jaggedArray[1].GetLength(0));
            // Console.WriteLine(jaggedArray[0].GetLength(1));
            //Console.WriteLine(jaggedArray[1].GetLength(1));
            // LinkedList<Tuple<int, int>> diff = new LinkedList<Tuple<int, int>>();

            int[] arr = { 0, -1, -2, 2, 1 };
            //int k = 1;
            // Console.WriteLine(GraphQuestions.FindPairsWithGivenDifference(arr, k));
            int[] arr1 = { 1, 3, 1, 5, 4 };
            int k = 0;
            //Console.WriteLine(GraphQuestions.FindPairs(arr1, k));
            //int numCourses = 3;
            //int[][] prerequisites = {new int[]{1, 0},new int[]{0, 2} };

            //int numCourses = 3;
            //int[][] prerequisites = { new int[] { 1, 0 }, new int[] { 0,2 } };

            //int numCourses = 4;
            //int[][] prerequisites = { new int[] { 2, 0 }, new int[] { 1, 0 }, new int[] { 3, 1 }, new int[] { 3, 2 }, new int[] { 1, 3 } };


            // Console.WriteLine(GraphQuestions.CanFinish(numCourses, prerequisites));
            //GraphQuestions.PrintLinkedList();

            int[] cells = { 0, 1, 0, 1, 1, 0, 0, 1 };
            int N = 16;

            //int[] cells = { 0, 1, 0};
            //int N = 4;
            // { 2, 100, 50, 120, 1000]

            //GraphQuestions.DisplayCells(GraphQuestions.PrisonAfterNDays(cells, N));
            //string b = "()()))";
            //Console.WriteLine(GraphQuestions.bracketMatch(b));

            ////double[] grants ={2, 100, 50, 120, 1000};
            ////double bud = 190;
            //double bud = 40;

            //double[] grants ={10, 5, 20, 30 };

            //Console.WriteLine(GraphQuestions.FindGrantsCap(grants,bud));
            //int[] array1 = { 99,44,6,2,1,5,63,87,283,4,0 };
            //int[] array1 = { 99, 44, 6, 2, 1};
            //GraphQuestions.DisplayCells(SortingAlgorithms.MergeSort(array1));

            //    string[] logs = { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo", "a2 act car" };
            //    ["let1 art can test", "let1 art can"]
            //GraphQuestions.DisplayCells(GraphQuestions.ReorderLogFiles(logs));
            //    string[][] head = { { 7, null }, { 13, 0 }, { 11, 4 },[10, 2],[1, 0]]

            //    Console.WriteLine(LeetCodeLockDownChallenge.IsHappy(2));
            //    Console.WriteLine(StringArray.LengthOfLongestSubstring("pwwkew"));

            //int[] array = { 10, 3, 2, 7, 7, 5, 8, 4, 1, 2, 9, 7, 8, 11 };
            //GraphQuestions.DisplayCells(array);
            //array = QuickSortAlgo.QuickSort(array, 0, array.Length-1);
            //GraphQuestions.DisplayCells(array);

            //int[] array2 = { 2, 1, 5 ,3 ,4 };
            //int[] array2 = { 5, 1, 5, 3, 2 };
            int[] array2 = { 2 ,5, 1, 3 ,4 };
            GraphQuestions.DisplayCells(array2);
            string s = BubbleSortAlgo.BubbleSort(array2);
            Console.WriteLine(s);
           // GraphQuestions.DisplayCells(array2);

            Console.ReadKey();
        }
    }
    public class GraphQuestions
     {
        //https://leetcode.com/explore/interview/card/amazon/79/sorting-and-searching/482/
        public int FindKthLargestNaiveSolution(int[] nums, int k)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            return nums[k - 1];
        }

        public static int bracketMatch(string text)
        {
            char[] textChar = text.ToCharArray();
            Stack<char> openBracketStack = new Stack<char>();
            int countMissingBrackets = 0;
            for (int i = 0; i < textChar.Length; i++)
            {
                if (textChar[i] == '(')
                {
                    openBracketStack.Push('(');
                }
                else if (textChar[i] == ')')
                {
                    if (openBracketStack.Count == 0)
                        countMissingBrackets += 1;
                    else if (openBracketStack.Pop() != '(')
                        countMissingBrackets += 1;
                }
            }
            return countMissingBrackets + openBracketStack.Count;
        }

        //https://www.pramp.com/question/r1Kw0vwG6OhK9AEGAyWV
        public static double FindGrantsCap(double[] grantsArray, double newBudget)
        {
            Array.Reverse(grantsArray);
            double surplus = GetTotal(grantsArray) - newBudget;
            double potentialCap = 0;
            double totalGranthavingSurplus = 0;
            double difference = 0;
            Console.WriteLine("Surpslue " + surplus);
            for (int i = 0; i < grantsArray.Length; i++)
            {
                potentialCap = grantsArray[i];
                totalGranthavingSurplus += grantsArray[i];
                difference = totalGranthavingSurplus - ((i + 1) * potentialCap);
                Console.WriteLine("i" + i + " difference : " + difference + " potential cap" + potentialCap);
                if (difference >= surplus)
                {
                    Console.WriteLine("i" + i + " difference : " + difference + " potential cap" + potentialCap);
                    if (i != 0)
                        potentialCap = potentialCap + ((difference - surplus) / (i));
                    break;
                }

            }
            return potentialCap;

        }
        public static double GetTotal(double[] array1)
        {
            double total = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                total += array1[i];
            }
            return total;
        }

        //https://leetcode.com/problems/prison-cells-after-n-days/
        public static int[] PrisonAfterNDaysBruteForce(int[] cells, int N)
        {
            int[] temp = new int[cells.Length];
            Array.Copy(cells, 0, temp, 0, cells.Length);

            for (int n = 0; n < N; n++)
            {
                DisplayCells(cells);
                for (int i = 0; i < cells.Length; i++)
                {
                    if (i == 0 || i == cells.Length - 1)
                    {
                        temp[i] = 0;
                    }
                    else
                    {
                        temp[i] = GetState(cells[i - 1], cells[i + 1]);
                    }
                }

                Array.Copy(temp, 0, cells, 0, cells.Length);



            }
            return cells;

        }
        public static int[] PrisonAfterNDays(int[] cells, int N)
        {
            int[] temp = new int[cells.Length];
            Array.Copy(cells, 0, temp, 0, cells.Length);

            Dictionary<int, int[]> lookUpNextState = new Dictionary<int, int[]>();

            int nUpTo14 = N <= 14 ? N : 14;
            for (int n = 1; n <= nUpTo14; n++)
            {
                for (int i = 0; i < cells.Length; i++)
                {
                    if (i == 0 || i == cells.Length - 1)
                        temp[i] = 0;
                    else
                        temp[i] = GetState(cells[i - 1], cells[i + 1]);
                }
                if (N > 14)
                {
                    int[] temp2 = new int[temp.Length];
                    Array.Copy(temp, 0, temp2, 0, temp2.Length);
                    lookUpNextState.Add(n % 14, temp2);
                }
                Array.Copy(temp, 0, cells, 0, cells.Length);
            }
            if (N > 14)
            {
                if (lookUpNextState.ContainsKey(N % 14))
                {
                    Array.Copy(lookUpNextState[N % 14], 0, cells, 0, cells.Length);
                }
            }
            return cells;
        }
        protected static int GetState(int left, int right)
        {
            if (left == right)
                return 1;
            else
                return 0;
        }
        protected static int ConvertArrayToInt(int[] cells)
        {
            string s = "";
            for (int i = 0; i < cells.Length; i++)
            {
                s += cells[i];
            }
            return Int32.Parse(s);
        }
        public static void DisplayCells(int[] cells)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                Console.Write(cells[i] + " , ");
            }
            Console.WriteLine("");
        }
        public static void DisplayCells(string[] cells)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                Console.Write(cells[i] + " , ");
            }
            Console.WriteLine("");
        }

        //https://leetcode.com/interview/1/submissions/
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> yLookup = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!yLookup.ContainsKey(target - nums[i]))
                {

                    yLookup.Add(target - nums[i], i);
                }

            }
            for (int x = 0; x < nums.Length; x++)
            {
                if (yLookup.ContainsKey(nums[x]))
                {
                    if (x != yLookup[nums[x]])
                        return new int[2] { x, yLookup[nums[x]] };
                }
            }
            return new int[2] { 0, 0 };
        }


        //https://leetcode.com/problems/course-schedule/
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, LinkedList<int>> adjacencyList = new Dictionary<int, LinkedList<int>>();
            Stack<int> sorted = new Stack<int>();
            bool[] visited = new bool[numCourses];
            int[] courses = new int[numCourses];


            foreach (int[] pair in prerequisites)
            {
                if (!adjacencyList.ContainsKey(pair[0]))
                {
                    LinkedList<int> temp = new LinkedList<int>();
                    temp.AddFirst(pair[1]);
                    adjacencyList.Add(pair[0], temp);
                }
                else
                {
                    adjacencyList[pair[0]].AddLast(pair[1]);
                }
            }
            for (int course = 0; course < numCourses; course++)
            {
                //Check if is cyclic
                if (IsCyclic(course, adjacencyList, visited))
                    return false;

            }
            return true;

        }
        //BackTracking WAy
        protected static bool IsCyclic(int course, Dictionary<int, LinkedList<int>> adjacencyList, bool[] visited)
        {

            //Leaf Present - No Outgress Edge
            if (!adjacencyList.ContainsKey(course))
                return false;
            if (visited[course])
                return true;

            visited[course] = true;

            //BackTracking
            bool isCyclic = false;
            foreach (int nextCourse in adjacencyList[course])
            {
                isCyclic = IsCyclic(nextCourse, adjacencyList, visited);
                if (isCyclic)
                    break;
            }
            visited[course] = false;
            return isCyclic;
        }


        //https://leetcode.com/problems/course-schedule/
        public static bool CanFinish3(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, LinkedList<int>> adjacencyList = new Dictionary<int, LinkedList<int>>();
            Stack<int> sorted = new Stack<int>();
            bool[] visited = new bool[numCourses];
            int cntLeafACyclic = 0;
            foreach (int[] pair in prerequisites)
            {
                if (!adjacencyList.ContainsKey(pair[0]))
                {
                    LinkedList<int> temp = new LinkedList<int>();
                    temp.AddFirst(pair[1]);
                    adjacencyList.Add(pair[0], temp);
                }
                else
                {
                    adjacencyList[pair[0]].AddLast(pair[1]);
                }
            }
            foreach (KeyValuePair<int, LinkedList<int>> entry in adjacencyList)
            {
                if (!visited[entry.Key])
                {
                    visited[entry.Key] = true;
                    sorted.Push(entry.Key);
                }

                LinkedListNode<int> current = entry.Value.First;
                LinkedListNode<int> previous = null;

                while (current != null)
                {
                    if (!adjacencyList.ContainsKey(current.Value))
                    {
                        cntLeafACyclic += 1;
                    }
                    if (!visited[current.Value])
                    {
                        visited[current.Value] = true;
                        sorted.Push(current.Value);
                    }
                    previous = current;
                    current = current.Next;
                }
            }
            if (sorted.Count == numCourses && cntLeafACyclic >= 1)
                return true;
            return false;

        }

        //https://leetcode.com/problems/valid-parentheses/submissions/
        public bool IsValid(string s)
        {
            int cntR = 0;
            int cntC = 0;
            int cntS = 0;
            Stack<int> openingBrackets = new Stack<int>();
            foreach (char c in s.ToCharArray())
            {
                switch (c)
                {
                    case '(':
                        cntR += 1;
                        openingBrackets.Push(c);
                        break;
                    case '{':
                        openingBrackets.Push(c);
                        cntC += 1;
                        break;
                    case '[':
                        openingBrackets.Push(c);
                        cntS += 1;
                        break;
                    case ')':
                        if (openingBrackets.Count == 0)
                            return false;
                        if (openingBrackets.Pop() != '(')
                            return false;
                        cntR -= 1;
                        break;
                    case '}':
                        if (openingBrackets.Count == 0)
                            return false;
                        if (openingBrackets.Pop() != '{')
                            return false;
                        cntC -= 1;
                        break;
                    case ']':
                        if (openingBrackets.Count == 0)
                            return false;
                        if (openingBrackets.Pop() != '[')
                            return false;
                        cntS -= 1;
                        break;
                }
            }
            if (cntR == 0 && cntC == 0 && cntS == 0)
                return true;
            else
                return false;

        }

        //https://leetcode.com/problems/valid-parentheses/submissions/
        public bool IsValid2(string s)
        {

            Stack<int> openingBrackets = new Stack<int>();
            Dictionary<char, char> bracketTypes = new Dictionary<char, char>();
            bracketTypes.Add(')', '(');
            bracketTypes.Add('}', '{');
            bracketTypes.Add(']', '[');
            char[] sChars = s.ToCharArray();
            if (String.IsNullOrEmpty(s))
                return true;
            if (sChars.Length <= 1)
                return false;

            foreach (char c in sChars)
            {
                if (bracketTypes.ContainsKey(c))
                {
                    if (openingBrackets.Count == 0)
                        return false;
                    if (openingBrackets.Pop() != bracketTypes[c])
                        return false;
                }
                else
                {
                    openingBrackets.Push(c);
                }

            }
            if (openingBrackets.Count != 0)
                return false;
            return true;
        }

        public static void PrintLinkedList()
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddFirst(1);
            list1.AddLast(2);
            list1.AddLast(3);
            list1.AddLast(4);
            LinkedListNode<int> current = list1.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

        }

        //https://www.pramp.com/challenge/XdMZJgZoAnFXqwjJwnpZ
        public static int[,] FindPairsWithGivenDifference(int[] arr, int k)
        {
            if (arr.Length == 0)
                return new int[0, 0];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                map.Add(arr[i] - k, arr[i]);
            }
            List<Tuple<int, int>> diff = new List<Tuple<int, int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    diff.Add(new Tuple<int, int>(map[arr[i]], arr[i]));
                }
            }

            int[,] output = new int[diff.Count, 2];
            int row = 0;
            if (diff.Count == 0)
                return new int[0, 0];
            foreach (var t in diff)
            {
                output[row, 0] = t.Item1;
                output[row++, 1] = t.Item2;
            }
            return output;
        }

        //https://leetcode.com/problems/k-diff-pairs-in-an-array/submissions/
        public static int FindPairs(int[] nums, int k)
        {
            if (nums.Length == 0)
                return 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(Math.Abs(nums[i] - k)))
                    map.Add(Math.Abs(nums[i] - k), nums[i]);
            }
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    count = count + 1;
                    map.Remove(nums[i]);
                }
            }


            return count;


        }

        public static int[][] FindPairsWithGivenDifference3(int[] arr, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                map.Add(arr[i] - k, arr[i]);
            }
            int[][] output = new int[2][];
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    output[i][0] = arr[i];
                    output[i][1] = map[arr[i]];

                }
            }
            return output;
        }

        //https://leetcode.com/problems/find-the-town-judge/
        public static int FindJudge(int N, int[][] trust)
        {
            if (N == 1)
                return -1;
            Dictionary<int, LinkedList<int>> AdjacencyList = new Dictionary<int, LinkedList<int>>();
            for (int i = 0; i < trust.Length; i++)
            {
                if (!AdjacencyList.ContainsKey(trust[i][1]))
                {
                    LinkedList<int> b = new LinkedList<int>();
                    b.AddFirst(trust[i][0]);
                    AdjacencyList.Add(trust[i][1], b);
                }
                else
                {
                    AdjacencyList[trust[i][1]].AddLast(trust[i][0]);
                }

            }
            //int nodeVA_B=0, nodeVB_A=0;
            int nodeVA_B = AdjacencyList.FirstOrDefault(l => l.Value.Count == (N - 1)).Key;
            int nodeVB_A = AdjacencyList.FirstOrDefault(l => l.Value.Contains(nodeVA_B)).Key;

            if (nodeVB_A != 0)
                return -1;
            return nodeVA_B == 0 ? -1 : nodeVA_B;
        }

        public static int FindJudge2(int N, int[][] trust)
        {
            Dictionary<int, int> b = new Dictionary<int, int>();
            for (int i = 0; i < trust.Length; i++)
            {
                if (!b.ContainsKey(trust[i][1]))
                {
                    b.Add(trust[i][1], 1);
                }
                else
                {
                    b[trust[i][1]] += 1;
                }

            }

            int trustKey = b.FirstOrDefault(x => x.Value == (N - 1)).Key;
            return trustKey == 0 ? -1 : trustKey;
        }

        //https://leetcode.com/problems/number-of-islands/solution/
        //DFS
        //Time complexity : O(M×N)
        //Space complexity :O(M×N)
        public int NumIslands(char[][] grid)
        {
            int cntClusters = 0;
            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {

                    if (!IsVisited(grid[row][col]) && grid[row][col] == '1')
                    {
                        DFS(grid, row, col);
                        cntClusters += 1;
                    }
                }
            }
            return cntClusters;
        }
        public void DFS(char[][] grid, int row, int col)
        {
            grid[row][col] = SetVisited(grid[row][col]);
            if ((col - 1) >= 0 && grid[row][col - 1] == '1')
            {
                DFS(grid, row, col - 1);
            }
            if ((row - 1) >= 0 && grid[row - 1][col] == '1')
            {
                DFS(grid, row - 1, col);
            }
            if ((col + 1) < grid[0].Length && grid[row][col + 1] == '1')
            {
                DFS(grid, row, col + 1);
            }
            if ((row + 1) < grid.Length && grid[row + 1][col] == '1')
            {
                DFS(grid, row + 1, col);
            }

            grid[row][col] = SetVisited(grid[row][col]);
        }
        public bool IsVisited(char value)
        {
            if (value == '2' || value == '3')
                return true;
            else
                return false;
        }
        public char SetVisited(char value)
        {
            if (value == '1')
                return '2';
            else if (value == '0')
                return '3';
            else
                return value;
        }

        //End of DFS
        //https://leetcode.com/problems/reorder-data-in-log-files/submissions/
        public static string[] ReorderLogFiles(string[] logs)
        {
            SortedDictionary<String, String> sortedAlpha = new SortedDictionary<String, String>();
            LinkedList<String> numbers = new LinkedList<String>();
            string[] sorted = new string[logs.Length];
            int k = 0;
            foreach (string log in logs)
            {
                string[] words = log.Split(' ');
                if (Char.IsDigit(words[1].ToCharArray()[0]))
                {
                    if (numbers.Count == 0)
                        numbers.AddFirst(log);
                    else
                        numbers.AddLast(log);
                }
                else
                {
                    int index = log.IndexOf(" ");
                    if (index + 1 < log.Length)
                    {
                        string id = log.Substring(0, index);
                        Console.WriteLine("index: " + index);
                        Console.WriteLine("id: " + id);
                        if (index + 1 < log.Length)
                        {
                            string remaining = log.Substring(index + 1, (log.Length - (index + 1)));
                            Console.WriteLine("remain: " + remaining);
                            if (sortedAlpha.ContainsKey(remaining))
                                sortedAlpha.Add(id + remaining, log);
                            else
                                sortedAlpha.Add(remaining, log);
                        }
                        //
                        // sortedAlpha.Add(remaining, id);                  
                    }

                }
            }
            foreach (KeyValuePair<String, String> kpv in sortedAlpha)
            {
                // if(kpv.Value.Contains("0000"))
                //    sorted[k++]=kpv.Value;
                //    else
                //sorted[k++]=kpv.Value+" "+kpv.Key; 
                sorted[k++] = kpv.Value;
            }
            foreach (string x in numbers)
            {
                sorted[k++] = x;
            }
            return sorted;
        }
    }
}
