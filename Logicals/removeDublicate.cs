using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
    internal class removeDublicate
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,1, 2, 3, 4, 5, 6, 7,3,2};
            int a=Array.IndexOf(arr, 2);
            for(int i=0;i<arr.Length; i++)
            {
                int num = 0;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] == arr[i])
                    {
                        num = arr[j];
                        break;
                    }
                }
                if(num != 0)
                {
            int[] arr2=arr.Where(x => x == num).ToArray();
                Console.WriteLine(num);
            for(int j=0;j< arr2.Length; j++) 
                    {
                        Console.WriteLine("ar2"+arr[j]);
                    }

                }
        }
                Console.ReadLine();
            }
    }
}

/*
 
 int[] arr = { 1,1, 2, 3, 4, 5, 6, 7,3,2};
            int count = 0;
       //     int[] arr2= new int[count];
            for(int i=0;i<arr.Length; i++)
            {
                int a = 0;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        a = arr[i];
                    }
                if(a != 0)
                {
                count++;
                Console.WriteLine(a+""+count);
                break;
                }
                }
                int[] arr2=new int[count];
                for(int j=0;j<arr2.Length ; j++)
                {
                    arr2[j] = a;
                    Console.WriteLine(+arr[j]);
                }
               
            }
                Console.WriteLine("count"+count);
                Console.ReadLine();
        }
 
 */