using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Calculator
    {
        public static long FactorialOf(int num)
        {
            int fact = 1;

            while (num > 0)
            {
                fact = fact * num;
                num--;
            }

            return fact;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of 5 = " + Calculator.FactorialOf(5));
        }
    }
}
