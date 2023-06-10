using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
            //this is reverstring by using reverse method
            string s1 = "soma";
            //converted string in array of char's and then that array we reversed
            char[] chars = s1.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(chars);
            */
            //another way is using for loop

            string s2 = "soma";
            char[] chars2 = s2.ToCharArray();
            int start = 0;
            int end = chars2.Length-1;
         //   Console.WriteLine(start+" "+end);
         while(start < end)
            {
                /* declared temp with start of char array then swap that char to last 
                 */
                char temp = chars2[start];
                chars2[start] = chars2[end];
                chars2[end]= temp;

                start++;
                end--;
            }
            string s3 = new string(chars2);
         Console.WriteLine(s3);
            Console.ReadLine();

        }

    }
}
