using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a;
            int temp=0;
            int sum = 0;
            while (a > 0)
            {
                temp = a % 10;
                sum=(sum*10)+temp;
                a = a / 10;

            }
            Console.WriteLine(sum);
            if (b == sum)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not Palidrome Number");
            }
            Console.ReadLine();
        }
    }
}
