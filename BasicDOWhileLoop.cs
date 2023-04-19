/*
  In this program we will be making use of a basic DoWhile loop that display intehers betweeen 0-14
*/

using System;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i+=1;
            }
            while(i<15);
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        }
    }
}
