using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        public static object Long { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] a = new int[] { 1, 1, 2, 2, 1 
            //int[] a = new int[] { 10, 2 };
            //int[] a = new int[] { 2, 3, 1, 5, 6 };
            String[] queryType = { "insert", "insert", "addToValue", "addToKey", "get" };
            // int[][] query = new int[,] { { 1, 2 }, { 2, 3 }, { 2 }, { 1 }, { 3 } };

            int[][] jaggedArrayQuery = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[]  { 2 },
                new int[]  { 1 },
                new int[]  { 3 }
            };
            //Console.WriteLine(firstDuplicate(a).ToString());

            //Console.WriteLine(concatenationsSum(a).ToString());

            //Console.WriteLine(mutateTheArray(5,a)[0].ToString());
            //Console.WriteLine(mutateTheArray(5, a)[1].ToString());
            //Console.WriteLine(mutateTheArray(5, a)[2].ToString());
            //Console.WriteLine(mutateTheArray(5, a)[3].ToString());
            //Console.WriteLine(mutateTheArray(5, a)[4].ToString());



            // Console.WriteLine(hashMap(queryType, jaggedArrayQuery).ToString());
            //drawTriangle(5);
            // Console.ReadLine();
            //writeFibo(10);
            //binary(1041);
            //binary(1041);
            //Console.WriteLine(binary(42));
            //int[] a = new int[] { -3, 1, 2, -2, 5, 6 };
            //int[] a = new int[] { -5, 5, -5, 4 };
            int[] a2 = new int[] { -10, -2, -4 };
            int[] A = new int[] { 1, -2, 0, 9, -1, -2 };
            //Console.WriteLine(maxProduct(a));
            /*
            int a=5;
            int b=100000;
            float c;
            c = (a * b) / (float)1000000;
            */

            int[] unordered = new int[] { 5, 9, 6, 1, 3, 4, 2,6,7,1,3,9 };
            //Console.WriteLine(c);
            String a = "cab";
            Console.WriteLine(isPalindrome(a));


            String b = "bcc";
            Console.WriteLine(isRoundRotation( a,  b));

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(5);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(8);
            list.AddLast(3);
            list.AddLast(4);
            
            list.AddLast(6);
            list.AddLast(7);
            
            Console.WriteLine("Rearrange");
            list = Rearrange(list);
            //Console.WriteLine(Rearrange(list));
            Console.WriteLine("Rearrange-End");

            int[] ordered = SortArrayAscending(unordered);
           // int[] ordered = BubbleSort(unordered);
            for (int i = 0; i < ordered.Length; i++)
                Console.Write(ordered[i]);
            Console.WriteLine("");
            Console.WriteLine(BinarySearch(ordered,6));
            Console.WriteLine(num_ways(4));

            int[] a1 = { -1, 3, 8, 2, 9, 5 };
            int[] b1 = { 4, 1, 2, 10, 5, 20 };
            int[] c = { 2, 4, 1, 6, 5, 40, -1 };
            int[] d = { 1, 3, 1, 3, 3, 4, 5, 5, 5, 5, 5, 5, 5, 9 };
            
            Console.WriteLine(isSumK(a1, 11));
            Console.WriteLine("mostfrequent");
            Console.WriteLine(MostFrequent(d));
            Console.WriteLine("common elements");


            int[] f = { 1, 3, 4, 6, 7, 9 };
            int[] g = { 1, 1, 4, 5, 9, 10 };
            int[] e = CommonElements(f, g);
            for(int i=0;i<e.Length;i++)
            {
                Console.Write((e[i]) + " ,");
            }
            
            Console.WriteLine("distinct");
            String s = "abccab";
            Console.WriteLine(NonRepeatingChar(s));
            Console.WriteLine("product");

            //int[] x1 = { 3, 2, 1 };
            int[] x1 = { 1, 2, 3, 4, 5};
            int[] prd = ProductofArray(x1);
            for (int i = 0; i < x1.Length; i++)
                Console.Write(prd[i]+",");

            Console.WriteLine("fib");
            int n = 7;
            List<int> result = new List<int>();

            Fibo2(n);

            Console.WriteLine("fib Recurssive ");
            Console.Write("Result: " +Fibo(n) + ",");
            Console.WriteLine("Pairs in Equation");


            matchingEquation(3);

            Console.WriteLine("smallest integer");
            //int[] ax = { 2, 3, 7, 6, 8, -1, -10, 15 };
            // int[] ax = { 2, 3, -7, 6, 8, 1, -10, 15 ;
            int[] ax = { 1, 1, 0, -1, -2 };
            Console.WriteLine(SmallestPositiveInteger(ax));
            Console.WriteLine("isPowerOf");
            Console.WriteLine(IsPower2(32));
            Console.WriteLine("LCM");
            Console.WriteLine(gcd(98, 56));
            
            Console.WriteLine("states");
           // int[] states = { 1, 0, 0, 0, 0, 1, 0, 0 };
           // int days = 1;

            int[] states = { 1,1,1,0,1,1,1,1};
            int days = 3;
            
            states = CellCompete(states, days);
            for (int i = 0; i < states.Length; i++)
                Console.Write(states[i] + ",");

            countInActiveActiveInCellCompete(states);

            Console.WriteLine("Lcm");
            Console.WriteLine(lcm(98, 56));
            Console.WriteLine(IsPowerOf2(7));
            Console.ReadLine();
        }


        static List<Int> BreadthFirstSearch(BSTree t)
        {
            return null;
        }


        static Boolean IsPowerOf2(int x)
        {
            int rem = -1;

            while(x>1 )
            {
                if (x == 2 && rem == 0)
                    return true;
                rem = x % 2;
                x = x / 2;
                Console.WriteLine("x: "+x);
                Console.WriteLine("rem: "+rem);
            }
            return false;
        }




        static int[] CellCompete(int[] states, int days)
        {
            int e = states.Length;
            int[] newStates = new int[(e+2)];
            newStates[0] = 0;
            newStates[e+1] = 0;
            Array.Copy(states, 0, newStates, 1, e);
            for (int d = 0; d < days; d++)
            {
                states = Enumerable.Range(1, e).Select(x => newStates[x - 1] ^ newStates[x + 1]).ToArray();
                newStates[0] = 0;
                newStates[e + 1] = 0;
                Array.Copy(states, 0, newStates, 1, e);
            }
            return states;
        }
        static void countInActiveActiveInCellCompete(int[] states)
        {
            int a = states.Where(x => x == 1).Count();
            System.Console.WriteLine("Active: " + a);

            int b = states.Where(x => x == 0).Count();
            System.Console.WriteLine("InActive: " +b);

        }

        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }

        static int lcm(int a, int b)
        {
            int greatest = a;
            int smallest = b;
            if (b > a)
            {
                greatest = b;
                smallest = a;
            }
            for(int i= greatest; ;i+= greatest)
            {
                if (i % smallest==0)
                    return i;
            }
        }
        static Boolean IsPower2(int x)
        {
            double r = ((double)Math.Log(x) / (double) Math.Log(2));
            Console.WriteLine(r);
            //if (Math.Ceiling(r)==Math.Floor(r
            if (r/1==(int) r)
            {
                return true;
            }
            else
            return false;
        }
        static int SmallestPositiveInteger(int[] a)
        {
            Array.Sort(a);
           //int smallestPos = 1;
            for(int i=0;i<a.Length;i++)
            {

                if (i <= a.Length - 2)
                {
                    if (a[i] < 0)
                    {
                        a[i] = 0;
                    }
                    if (a[i+1] < 0)
                    {
                        a[i+1] = 0;
                    }
                    if (a[i] == a[i + 1] || (a[i] + 1) == (a[i + 1]))
                    {
                        Console.Write("b: ");
                        continue;
                    }
                    else if ((a[i] + 1) != a[i + 1])
                    {
                        Console.Write("c: ");
                        return a[i] + 1;
                    }
                }

            }
            return a[a.Length-1] + 1;
        }

        static void matchingEquation( int n)
        {
            Dictionary<int, List<String>> mapresultab = new Dictionary<int, List<String>>();
            int val;
            String pair;
            for (int a=1;a<=n;a++)
            {
                for(int b=1;b<=n;b++)
                {
                    List<String> list = new List<string>();
                    val = (int)Math.Pow(a, 3) + (int)Math.Pow(b, 3);
                    pair = a + "," + b;
                    if (!mapresultab.ContainsKey(val))
                    {
                        list.Add(pair);
                        mapresultab.Add(val,list );
                    }
                    else
                    {
                        list = mapresultab[val];
                        list.Add(pair);
                        mapresultab[val] = list;
                    }
                }
            }
 
                for (int c = 1; c <= n; c++)
                {
                    for (int d = 1; d <= n; d++)
                    {
                        
                        val = (int)Math.Pow(c, 3) + (int)Math.Pow(d, 3);
                        
                        if (mapresultab.ContainsKey(val))
                        {
                            List<String> list = new List<string>();
                            list = mapresultab[val];
                            pair = c + "." + d;
                            list.Add(pair);
                            mapresultab[val]= list;
                        }
                    }
                }

            foreach (KeyValuePair<int, List<String>> validPair in mapresultab)
            {
                foreach(String s in validPair.Value)
                {
                    Console.Write(s+"  ");
                }
                Console.WriteLine(" ");
            }

            //}




        }

        static int Fibo(int n)
        {
            //Console.Write(n+",");
            if (n == 0)
            {
                
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            else
            {
                return Fibo(n - 1)+Fibo(n-2);
            }
        }


        static void Fibo2(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0 ;
            Console.Write(n1 + ",");
            Console.Write(n2 + ",");
            //Console.WriteLine("");
            for (int i = 2; i <= n; i++)
            {

                //Console.WriteLine("   inside n1:"+n1 + ",");
                //Console.WriteLine("  inside n2:" + n2 + ",");

                n3 = n1 + n2;
                Console.WriteLine(n3 + ",");
                //Console.WriteLine("n3:"+ n3 + ",");
                n1 = n2;
                n2 = n3;
                
            }

        }
        static int[] ProductofArray(int[] a)
        {
            List<int> result = new List<int>();
            int prod = a.Aggregate(1, (x, y)=>x*y);
            for(int i=0;i<a.Length;i++)
            {
                result.Add(prod / a[i]);
            }

            return result.ToArray();
        }

        static  Char? NonRepeatingChar(String s)
        {
            Char[] chars = s.ToCharArray();
            Array.Sort(chars);
            Dictionary<char, int> cnt = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if(cnt.ContainsKey(chars[i]))
                {
                    cnt[chars[i]] += 1;
                    //Console.WriteLine(chars[i]+" "+ cnt[chars[i]]);
                }
                else
                {
                    cnt.Add(chars[i], 1);
                   // Console.WriteLine(chars[i] + " " + cnt[chars[i]]);
                }
            }
            char uniqueKey = cnt.Where(item => item.Value.Equals(1)).Select(item => item.Key).FirstOrDefault();
            Console.WriteLine(uniqueKey);
            if (uniqueKey == (char)' ')
                return null;
            return uniqueKey;
        }

        static int MostFrequent(int[] a)
        {
            Dictionary<int, int> keyPairsCount = new Dictionary<int, int>();
            //HashMap<int, int> a = new hashMap<int, int>();
            int maxCnt = -1;
            int maxItem = a[0];
            for (int i=0;i<a.Length;i++)
            {
                if(keyPairsCount.ContainsKey(a[i]))
                {
                    int newcnt;
                    bool isV= keyPairsCount.TryGetValue(a[i], out newcnt);
                    newcnt += 1;
                    keyPairsCount.Remove(a[i]);
                    keyPairsCount.Add(a[i], newcnt);                   
                }
                else
                {
                    keyPairsCount.Add(a[i], 1);
                }
                if (keyPairsCount.GetValueOrDefault(a[i])>maxCnt)
                {
                    maxCnt = keyPairsCount.GetValueOrDefault(a[i]);
                    maxItem = a[i];
                }
            }
            
            return maxItem;
        }

        static Boolean isSumK(int[] a, int k)
        {
            //int j = 0;
            for(int i=0;i<a.Length-1;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if ((a[i] + a[j]) == k)
                        
                        return true;
                }

            }
            return false;
        }

        static int[] CommonElements(int[] a, int[] b)
        {
            List<int> c=new List<int>();
            int p1 = 0;
            int p2 = 0;
            while (p1 < a.Length && p2 < b.Length)
            {
                if (a[p1] == b[p2])
                {
                    c.Add(a[p1]);
                    p2 += 1;
                    p1 += 1;
                }
                else if (a[p1] < b[p2])
                {
                    p1+=1;
                }
                else if (a[p1] > b[p2])
                {
                    p2 += 1;
                }
            }
            return c.ToArray();
        }

        static int SumClosestToTarget(int[] a, int[] b, int target)
        {
            int sum=0;
            int csum= a[0] + b[0];
            for (int i=0;i<a.Length;i++)
            {
                for(int j=0;j<b.Length;j++)
                {
                    sum = a[i] + b[j];
                    if (Math.Abs((sum - target)) < Math.Abs((csum - target)))
                        csum = sum;
                  
                }
            }
            return csum;
        }

        static double num_ways(int N)
        {
            return Math.Pow(2, N - 1);
           // return 0;
        }

        static int BinarySearch(int[] a, int b)
        {
            int l = 0;
            int r = a.Length - 1;
            while (l<=r)
            {
                int mid =  (l+r) / 2;
                if (b==a[mid] )
                    return mid;
                else if (b > a[mid])
                {
                    l = mid + 1;
                }
                else if(b<a[mid])
                {
                    r = mid-1;
              
                }
                
            }
            return -1;
        }


        static int[] SortArrayAscending(int[] array1)
        {
            int temp;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int y = 0; y < array1.Length - 1; y++)
                {
                    if (array1[y] > array1[y + 1])
                    {
                        temp = array1[y];
                        array1[y] = array1[y + 1];
                        array1[y + 1] = temp;
                        Console.WriteLine("value moved"+ temp);
                    }

                }
            }
            return array1;
        }

        static int[] BubbleSort(int[] a)
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]>a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
        private static LinkedList<int> Rearrange(LinkedList<int> list1)
        {
            LinkedList<int> list2 = new LinkedList<int>();


            int j = list1.Count - 1;
            int cnt = list1.Count;

            while (list1.Count>0)
            {
                LinkedListNode<int> node1 = new LinkedListNode<int>(list1.First.Value);
                list2.AddLast(node1);
                list1.RemoveFirst();

                LinkedListNode<int> node2= new LinkedListNode<int>(list1.Last.Value);
                list2.AddLast(node2);
                list1.RemoveLast();

                Console.WriteLine(node1.Value);
                Console.WriteLine(node2.Value);

            }

            return list2;
        }

        private static List<int> zigZagTraversal(List<int> a)
        {
            return null;
        }

        static int isRoundRotation(String a, String b)
        {
            String aa = String.Concat(a, a);
            for(int i=1;i<=a.Length;i++)
            {
                if (aa.Substring(i, a.Length).ToLower().Equals(b.ToLower()))
                    return 1;
            }
            return -1;
        }

        private static int grayCodeFromInt(int t1, int t2)
        {
            byte term1;
            byte term2;
            bool b = Byte.TryParse(t1.ToString(), out term1);
            b = Byte.TryParse(t2.ToString(), out term2);
            return grayCode(term1, term2);
        }



        private static int grayCode(byte term1, byte term2)
        {
            byte x = (byte)(term1 ^ term2);  // why use XOR?
            int count = 0;
            while (x != 0)
            {
                x = (byte)(x & (x - 1));  // why use bitwise operator?
                count++;               // what is count?
            }
            if (count == 1)
                return 1;
            else
                return 0;
        }
        static Boolean isPalindrome(string a)
        {
            char[] ch = a.ToCharArray();
            Array.Reverse(ch);
            String rev = new string(ch);
            Console.Write(rev);
            Console.Write(a);
            if (rev.ToLower().Equals(a.ToLower()))
                return true;

            return false;
        }
        static int firstDuplicate(int[] a)
        {
            int res = -1;
            int d = 0;
            for (int i = 0; i < a.Length; i++)
            {

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {

                        if (d > j - i || d == 0)
                        { res = a[i]; d = j - i; }



                    }
                }
            }
            return res;
        }
        static long concatenationsSum(int[] a)
        {
            long res = 0;
            string[] str = new string[a.Length];
            //Console.Write("This prints to the console when you Run Tests"+ "Hello, " + res.ToString());
            for (int i = 0; i < a.Length; i++)
            {
                str[i] = a[i].ToString();
                if (i == 0 || i == a.Length - 1)
                {
                    res += Int64.Parse(String.Concat(str[i], str[i]));
                }
                if (i <= a.Length - 2)
                {
                    res += Int64.Parse(String.Concat(str[i], str[i + 1]));

                    res += Int64.Parse(String.Concat(str[i + 1], str[i]));
                }

            }

            return res;
        }

        static long hashMap(string[] queryType, int[][] query)
        {

            //Console.Write("This prints to the console when you Run Tests");


            Dictionary<int, int> hash = new Dictionary<int, int>();
            long queryResult = 0;
            int[] keys;
            int[] values;
            for (int i = 0; i < queryType.Length; i++)
            {
                switch (queryType[i])
                {
                    case "insert":
                        hash.Add(query[i][0], query[i][1]);
                        break;
                    case "addToValue":
                        keys = new int[hash.Keys.Count];
                        hash.Keys.CopyTo(keys, 0);

                        for (int j = 0; j < keys.Length; j++)
                        {
                            int sum = hash[keys[j]] + query[i][0];
                            hash.Remove(keys[j]);
                            hash.TryAdd(keys[j], sum);
                        }
                        break;
                    case "addToKey":
                        keys = new int[hash.Keys.Count];
                        values = new int[hash.Keys.Count];
                        hash.Keys.CopyTo(keys, 0);
                        hash.Values.CopyTo(values, 0);
                        int[] newKeys = new int [hash.Keys.Count];
                        hash.Clear();
                        for (int j = 0; j < keys.Length; j++)
                        {
                            newKeys[j]=keys[j] + query[i][0];
                            hash.TryAdd(newKeys[j], values[j]);
                        }
                        break;

                    case "get":
                        queryResult = hash[query[i][0]];
                        break;

                    default: break;


                }
            }
            //Console.WriteLine(hash[1]);
            Console.WriteLine(hash[2]);
            Console.WriteLine(hash[3]);
            return queryResult;

        }


        static int[] mutateTheArray(int n, int[] a)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                    b[i] = 0 + a[i] + a[i + 1];
                else if (i == (a.Length - 1))
                    b[i] = a[i - 1] + a[i] + 0;
                else
                    b[i] = a[i - 1] + a[i] + a[i + 1];

            }
            return b;
        }
        static int[] mutateTheArray2(int n, int[] a)
        {

            int[] b = new int[n];
            Console.Write(n);
            for (int i = 0; i <= n - 1; i++)
            {
                if (n == 1)
                {
                    if (i == 0)
                        b[i] = 0 + a[i] + 0;
                }
                if (n == 2)
                {
                    if (i == 0)
                        b[i] = 0 + a[i] + a[i + 1];
                    if (i == n - 1)
                        b[i] = 0 + a[i] + 0;
                }
                else if (n > 2)
                {
                    if (i == 0)
                        b[i] = 0 + a[i] + a[i + 1];
                    else if (i == n - 1)
                        b[i] = a[i - 1] + a[i] + 0;
                    else
                        b[i] = a[i - 1] + a[i] + a[i + 1];
                }

            }
            return b;
        }
        static void drawTriangle(int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.Write("*");
                for (int j=0;j<i;j++)
                {
                    Console.Write("o");
                }
                Console.WriteLine("");
            }
        }
        static void writeFibo(int n)
        {
            int a = 0;
            int b = 1;
            Console.Write(b);
            Console.Write(",");
            while (a<=n)
            {
                
                int c = a + b;

                Console.Write(c);
                Console.Write(",");
                a = b;
                b = c;
            }
        }

        static int binary(int N)
        {
            int i;
            int maxGap = 0;
            int currentGap = 0;
            int countPrev1 = 0;
            int remain = 0;
            int remainPrev = 0;
            for ( i = 0; N > 0; i++)
            {
                remainPrev = remain;
                 remain = N % 2;
                N = N / 2;
               
 
                 if(remain ==1)
                {
                    countPrev1++;
                    if (countPrev1 > 1 && remainPrev ==0)
                    {
                        maxGap = Math.Max(maxGap, currentGap);
                       
                    }
                    currentGap = 0;
                }
                else if (remain == 0 )
                {
                    currentGap += 1;

                
                }
                Console.Write(remain);
            }
            Console.WriteLine("+");
            //Console.WriteLine(maxGap);
            return maxGap;
        }
        static int getGap(int []b, int l)
        {
            int pos1 = -1;
            int pos2 = -1;
           int  longestgap = 0;
            for(int i=0;i<l;i++)
            {
                pos1 = Array.IndexOf(b, 1, i);
                pos2 = Array.IndexOf(b, 1, pos1+1);

            
                longestgap = pos2 - pos1-1 > longestgap? pos2 - pos1 -1 : longestgap;

            }
            return longestgap;
        }

        static int maxProduct(int[] A)
        {
            Array.Sort(A);
            int[] B = A;
            int currMax=0;
            int  max = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("x:" + A[i]);
                
            }
            currMax = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            max = Math.Max(currMax,max);
            currMax = A[0] * A[1] * A[A.Length - 1];
            max = Math.Max(currMax, max);
            currMax = A[0] * A[A.Length - 2] * A[A.Length - 1];
            max = Math.Max(currMax, max);

            return max;
           
        }
        /*static int sumGame(int[] A)
        {
            int sum =A[0];
            for(int i=1;i<A.Length;i++)
            {
                for(int i=i;i<)
            }
            return sum;
        }*/


        //        void ZigZagBinaryTree()
        //        {
        //https://stackoverflow.com/questions/17485773/print-level-order-traversal-of-binary-tree-in-zigzag-manner
        //            spiralLevelOrder(root) {
        //                S1 = new Stack()
        //    S2 = new Stack()
        //    S1.push(root)
        //    spiralLevelOrderRecursion(S1, S2, 1)
        //}

        //            spiralLevelOrderRecursion(S1, S2, level) {
        //                while (S1 not empty) {
        //                    node = S1.pop()
        //                     visit(node)
        //                     if (level is odd)
        //                    {
        //                        S2.push(node.rightNode)
        //            S2.push(node.leftNode)
        //        }
        //                    else
        //                    {
        //                        S2.push(node.leftNode)
        //                        S2.push(node.rightNode)
        //                    }
        //                }
        //                if (S2 not empty)
        //        spiralLevelOrderRecursion(S2, S1, level + 1)
        //            }
        //        }
    }
}
