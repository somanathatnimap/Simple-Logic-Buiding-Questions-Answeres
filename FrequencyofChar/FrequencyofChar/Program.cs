using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyofChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Engineer";
            string s1=s.ToLower();

            for(char ch='a'; ch<='z'; ch++)
            {
                int count = 0;
                for(int i=0; i<s1.Length; i++)
                {
                    if(ch == s1[i]) 
                    {

                    count++;
                    }
                    
                }
                if (count != 0)
                {

                Console.Write(ch+"="+count+",");
                }
                
            }
            Console.ReadLine();
        }
    }
}
