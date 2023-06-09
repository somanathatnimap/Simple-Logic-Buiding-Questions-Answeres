using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_highest_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {   //initialized array
            int[] arr = new int[] { 12, 35, 1, 10, 34, 1, 35 };
            //set largest and second largest element as 0
            int max = 0;
            int secmax = 0;
            //put array in loop
            foreach(int i in arr)
            {
                //if element in array is grater than max 
                if (max < i)
                { //this will comapre elements one by one to each other and until find gretest elemnt in array
                    secmax = max;
                    max = i;

                }
                else if(secmax < i && max > i)
                { //this will compare element with current elemnt 
                    secmax = i;
                }
                //time complexity of this code is O(n)
                
            }
            Console.WriteLine(secmax);
            Console.ReadLine();
        }
    }
}
