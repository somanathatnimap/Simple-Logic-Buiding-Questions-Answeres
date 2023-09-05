using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
    internal class SumOfGivenRange
    {
        public int Sum(int start, int end)
        {
            int count = start;
            int sum = 0;
            while (count <= end)
            {
                sum=sum+ count;
                count++;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            SumOfGivenRange sumOfGivenRange = new SumOfGivenRange();
            int x=sumOfGivenRange.Sum(10, 20);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
