using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Calculator
    {
        public static long FactorialOf(int n)
        {
            int fact = 1;

            while (n > 0)
            {
                fact = fact * n;
                n--;
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
