using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
    internal class patterns
    {
        public static void Main(string[] args)
        {
            Func<int, double> squre = x => Math.Sqrt(x);
            Console.WriteLine(squre(16));
            Console.ReadLine();

        }
    }
    }


/*
 int n = 4; 

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

 List<int> list=new List<int>{ 1,2,3,4,5};
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {

                Console.WriteLine(list[i]); 
                }
            }

// 4*3*2*1
            int num = 5;
            int temp = 1;
            for(int i = 1; i <= num; i++)
            {
                temp = temp * i;
            }
            Console.WriteLine(temp);
            Console.ReadLine();

 static void Main(string[] args)
        {
            int a = 15;
            
            Console.WriteLine(Math.Sqrt(a));
            Console.ReadLine();
        }

 string str = "soma";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                str += str[i];
            }
            Console.WriteLine(str);
            Console.ReadLine();

 StringBuilder sb = new StringBuilder();
            sb.Append("soma");
            sb.Insert(3, "oo");
            Console.WriteLine(sb);
            Console.ReadLine();
            
 Func<int, int, int> sum = (x, y) => x + y;
            Console.WriteLine(sum(10,11));

            Action<string> name = msg => Console.WriteLine(msg);
            name("soma");

            Predicate<int> isGreaterThan = (x) => x != 0;

            Console.WriteLine(isGreaterThan(0));
            //Console.WriteLine(isTrue);
            //Console.WriteLine);
            Console.ReadLine();


class A
    {
        void PrintA()
        {
            Console.WriteLine("Method From A");
        }
    }
    class B : A
    {
        void PrintA()
        {
            Console.WriteLine("Method From A");
        }
    }
    class C : A
    {
        void PrintA()
        {
            Console.WriteLine("Method From A");
        }
    }
    class D : B, C
    {
        void PrintA()
        {
            Console.WriteLine("Method From A");
        }
    }
interface IA
    {
        void PrintA();
    }
    interface IB
    {
        void PrintB();
    }
    class C:IA,IB
    {
         public void PrintA()
        {
            Console.WriteLine("Method from interface a");
        }
        public void PrintB()
        {
            Console.WriteLine("Method from interface b");
        }
    }
   
    internal class patterns
    {
       
        public static void Main(string[] args)
        {
            C c=new C();
            c.PrintA();
            c.PrintB();
            Console.ReadLine();
        }
interface IA
    {
         void PrintA();
    }
    interface IB
    {
        void PrintB();
    }
    class A:IA
    {
        public virtual void PrintA()
        {
            Console.WriteLine("Method from A");
        }
    }
    class C:A,IA,IB
    {
         public override void PrintA()
        {
            Console.WriteLine("Method from C");
        }
        public void PrintB()
        {
            Console.WriteLine("Method from C");
        }
    }
    internal class patterns
    {
       
        public static void Main(string[] args)
        {
            C c=new C();
            c.PrintA();
            c.PrintB();
            Console.ReadLine();
        }
        
 */