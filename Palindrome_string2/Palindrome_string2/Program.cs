using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_string2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "level";
            string rev=string.Empty;
            for(int i=0;i<s.Length;i++ )
            {
                rev = rev + s[i].ToString() ;
            }
            Console.WriteLine(rev+" "+s);
            if (s == rev)
            {
                Console.WriteLine("String is Palidrome");
            }
            else
            {
                Console.WriteLine("String is not Palidrome");
            }
            Console.ReadLine();
        }
    }
}
