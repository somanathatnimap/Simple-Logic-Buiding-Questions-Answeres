using System;

namespace Fibonacci_Series
{
    internal class Program
    {
        class one
        {
            private int x = 0;
            private int y = 1;
            private int z = 0;

            public void Fibbo(int i)
            {
                if (i < 100)
                {
                    z = x + y;
                    x = y;
                    y = z;
                    Console.WriteLine(z);
                    Fibbo(i + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            one f = new one();
            f.Fibbo(0);
            Console.ReadLine();
        }
    }
}
