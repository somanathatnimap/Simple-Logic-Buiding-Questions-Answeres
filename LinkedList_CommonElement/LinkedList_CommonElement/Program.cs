using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_CommonElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>(new []{4, 5, 6, 7, 8, 9});
            LinkedList<int> l2 = new LinkedList<int>(new[] { 11, 12, 13, 6, 7, 8, 9 });

            foreach (int i in l1)
            {
                bool isTrue = false;
                foreach(int j in l2)
                {
                    if(i == j)
                    {
                        isTrue = true;
                        break;
                    }
                }
                if(isTrue)
                {

                Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            }
        //time complexity of this code  O(N*M)
    }
}

