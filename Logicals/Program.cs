using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
    internal class RemoveElementInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5,5 };
            int number = 5;
            /*
            arr=arr.Where(x=>x!= number).ToArray();
            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine($"Element in array are {arr[i]}");
            }
                Console.WriteLine($"Length of array is {arr.Length}");
            */
            Array.FindAll(arr, x=>x!=5);
            List<int> list = new List<int>()
           {
               1,3,4,5,6,7
           };
            list.RemoveAt(1);
            Console.ReadLine();

            
        }
    }
}
