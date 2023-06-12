using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<n;i++)
            {
                bool isTrue = true;
                for (int j = 2; j < n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                   
                }
                    if (isTrue)
                    {

                        Console.WriteLine(i);
                    }
                
            }
            Console.ReadKey();
        }
    }
}
