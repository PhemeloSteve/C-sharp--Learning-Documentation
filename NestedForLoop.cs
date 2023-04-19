/*
  In this program we will be making use of nested for loops to print out numbers between 1-25
*/

using System;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            int x = 0;

            for (int i = 1; i<=5; i++)
            {
                for(int j = 1; j<=5; j++)
                {
                    x+=1;
                    Console.WriteLine(x);

                }
            }
            //Console.WriteLine(x);
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        }
    }
}
