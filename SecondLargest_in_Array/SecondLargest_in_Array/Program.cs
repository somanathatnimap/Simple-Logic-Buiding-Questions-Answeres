using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLargest_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largest = int.MinValue;
            int secondlargest = int.MinValue;
            int[] arr = { 4, 5, 7, 5, 23, 65, 21 };
            for(int i=0;i<arr.Length; i++)
            {
                if (largest < arr[i])
                {
                    secondlargest = largest;
                    largest = arr[i];
                }
                else if(secondlargest < arr[i] && arr[i]!=largest)
                {
                    secondlargest= arr[i];
                }
            }
            Console.WriteLine(secondlargest);
            Console.ReadLine();
        }
    }
}
