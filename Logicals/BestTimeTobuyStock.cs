using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
        /*
         * Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
         */
    internal class BestTimeTobuyStock
    {
        static void Main(string[] args)
        {
            int[] prices = {7, 1, 5, 3, 6, 4};
            int small = prices[0];
            int index = 0;
            int big = prices[prices.Length-1];
            for(int i=0; i<prices.Length; i++)
            {
                if (prices[i] < small)
                {
                    small= prices[i];
                    index=i;
                    if (prices[index] > big && index !=0)
                    {
                        big = prices[index];
                    }
                }
               
            }
            Console.WriteLine(small+""+big);

            Console.ReadLine();
        }
    }
}
/*
 int[] prices = {7, 1, 5, 3, 6, 4};
            int small = prices[0];
            for(int i=0; i<prices.Length; i++)
            {
                if (prices[i] < small)
                {
                    small= prices[i];
                }
            }
            Console.WriteLine(small);

int large = 0;
            for(int i=index;i<prices.Length; i++)
            {
                if (prices[i] >= small)
                {
                    large= prices[i];
                }
            }
            int profit = large - small;
            Console.WriteLine(profit);
 */