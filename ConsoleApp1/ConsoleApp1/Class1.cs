using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Class1
    {
        //static void Main(string[] args)
        void Main()
        {
            // Console.WriteLine("test");
            //Console.ReadLine();
            //T = Number of Integers
            int T = Convert.ToInt32(Console.ReadLine());

            //array to contain the integers
            int[] integersNArrayInt = new int[T];

            string integerstring = Console.ReadLine();

            string[] ArrayIntegersStr = new string[T];
            ArrayIntegersStr = integerstring.Split(' ');

            integersNArrayInt = Array.ConvertAll<string, int>(ArrayIntegersStr, int.Parse);

            for (int i = 0; i < T; i++)
            {
                
                for(int j=1; j<= integersNArrayInt[i]; j++)
                {
                    bool stringDisplayed = false;
                    if (j % 3 == 0)
                    {
                        stringDisplayed = true;
                        Console.Write("Fizz");
                    }
                       
                    if (j % 5 == 0)
                    {
                        stringDisplayed = true;
                        Console.Write("Buzz");
                    }
                        
                   if(!stringDisplayed)
                        Console.Write(j.ToString());
                    Console.Write("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
