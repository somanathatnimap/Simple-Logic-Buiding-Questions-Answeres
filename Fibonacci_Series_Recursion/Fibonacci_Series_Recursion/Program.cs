using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            for(int i=0;i<100;i++)
            {
                c = b + a;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
