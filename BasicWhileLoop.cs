/*
  In this Program we will be making use of basic while loop that display nummbers from 0-9
*/

using System;

namespace Test
{
    public class Program
    {
        public static void Main()
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine(i);
                i+=1;
            }
        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        }
    }
}
