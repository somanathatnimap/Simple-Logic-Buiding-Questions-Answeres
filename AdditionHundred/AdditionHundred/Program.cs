using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionHundred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 80, 60, 10, 50, 30, 100, 0, 50 };
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0;j<arr.Length; j++)
                {
                    if (arr[i] + arr[j] ==100)
                    {
                        Console.WriteLine(arr[i]+" + " + arr[j]+" = 100");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
        //time complexity of this code is O(n^2)
    }
}
