using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqureRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int n1=Convert.ToInt32(Math.Sqrt(n));

            double d1 = n / 2;
            Console.WriteLine(n1);
            Console.ReadLine();
        }
    }
}
