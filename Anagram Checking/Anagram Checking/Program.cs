using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Checking
{
    internal class Program
    { //anagram code
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First String : ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Your Second String : ");
            string s2 = Convert.ToString(Console.ReadLine());
            //i have given two strings from user then both strings converted in array of characters then i sorted array

            char[] chars = s1.ToCharArray();
            char[] chars2 = s2.ToCharArray();

            Array.Sort(chars);
            Array.Sort(chars2);
            //by using this method i sorted array and then assigned this value to string
            s1=new string(chars);
            s2=new string(chars2);
            Console.WriteLine(s1+" "+s2);
            //here compared both values with each other
            if(s1 == s2)
            {
                Console.WriteLine("Yes It Is Anagram...!");
            }
            else
            {
                Console.WriteLine("No It Is Not, Anagram...!");
            }
            Console.ReadLine();
            //time complexity for this code is O(n log n)
        }
    }
}
