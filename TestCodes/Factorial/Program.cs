using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum;
            string sNum;


            bool isSuccess;
            Console.Write("Enter an integer that you want a number of: ");
            sNum = Console.ReadLine();

            isSuccess = int.TryParse(sNum, out iNum);

            if (isSuccess && iNum >= 0)
            {
                int iFactorial = Fact(iNum);
                Console.WriteLine(iFactorial);
            }
            else
            {
                Console.WriteLine("Invalid user input");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        public static int Fact(int _iNum)
        {
            if (_iNum > 1)
            {
                return _iNum * Fact(_iNum - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
