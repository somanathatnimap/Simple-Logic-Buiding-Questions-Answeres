using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            int rev = 0;
            int temp = 0;
            while(num > 0)
            {
                temp = num % 10;
                rev=(rev*10)+temp;
                num /= 10;
            }
            Console.WriteLine(rev);
            Console.ReadLine();
        }

    }
}
