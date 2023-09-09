using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
    interface IHello
    {
        void Hello();
    }
    internal class simplelogic:IHello
    {
        public void Hello()
        {
            string str = "Engineer";
            str.ToLower();
            char[] ch1= str.ToCharArray();
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                int count = 0;
               for(int i=0; i < ch1.Length; i++)
                {
                    if (ch1[i] == ch)
                    {
                        count++;
                    }
                }
               if(count != 0)
                {
                    Console.WriteLine(ch+""+count);
                }

               // Console.WriteLine(ch+""+count);
            }
            Console.ReadLine();
        }
      static void Main(string[] args)
        {
            simplelogic sl= new simplelogic();
            sl.Hello();
        }
    }
}


/*
 int sum = 0;
            for(int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

static void Main(string[] args)
        {
            string s1 = "saom";
            string s2 = "soma";

            char[] ch = s1.ToCharArray();
            char[] ch1 = s2.ToCharArray();

            Array.Sort(ch);
            Array.Sort(ch1);

            s1 = new string(ch);
            s2=new string(ch1);

            if (s1 == s2)
            {
                Console.WriteLine("Anagram string");
            }
            else
            {
                Console.WriteLine("Non-Anagram String");
            }
            Console.ReadLine();
 int[] arr = { 2, 3, 4, 5,3, 2,3};
            for(int i=0;i<=arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        Console.WriteLine(arr[i]);
                        break;
                    }
                }
            }
            Console.ReadLine();

 List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            foreach(int i in list)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
//0,1,1,2,3,5
            int first = 0;
            int second=1;
            int fibbo = 0;
            for( int i = 0; i < 100; i++)
            {
                fibbo = first + second;
                first = second;
                second=fibbo;
                Console.WriteLine(fibbo);
            }
            Console.ReadLine();
  int first = 0;
        int second = 1;
        int series = 0;
        void fibbonacci()
        {            
            //0,1,1,2,3,5
            series = first + second;
            first = second;
            second = series;
            Console.WriteLine(series);
            fibbonacci();
        }
       static void Main(string[] args)
        {
            simplelogic simplelogic = new simplelogic();
            simplelogic.fibbonacci();
        } 
 */