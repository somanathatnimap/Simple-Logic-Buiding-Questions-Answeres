﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logicals
{
    internal class LeetcodeProblems
    {
       static void Main(string[] args)
        {
            //1*2*3*4
            int fact = 1;
           for(int i = 1; i <= 4; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

            Console.ReadLine();
        }
    }
}


/*
    List<int> list = new List<int> { 2, 3, 4, 5, 3, 5, 6, 2, 7 };
            List<int> ans = new List<int>{ 2,3};
            List<int> ans1 = new List<int>();

            for(int i = 0; i < list.Count; i++)
            {
                if (!ans.Contains(list[i]))
                {
                    ans.Add(list[i]);
                }
                else if (!ans1.Contains(list[i]))
                {
                    ans1.Add(list[i]);
                }
            }
            foreach(int i in ans) 
            {
                Console.WriteLine(i+"ans");
            }
            foreach (int i in ans1)
            {
                Console.WriteLine(i+"ans1");
            }
            Console.ReadLine();

List<int> list = new List<int> { 2, 3, 4, 5, 3, 5, 6, 2, 7 };
            bool a= list.Contains(1);
            Console.WriteLine(a);
            Console.ReadLine();'

 static void Main(string[] args)
        {
            int[] arr = { 2, 2, 3, 4, 5, 6, 7, 3, 4, 8,2 };
            HashSet<int> set = new HashSet<int>();
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                }
                else
                {
                    set.Add(arr[i]);
                }
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
static void Main(string[] args)
        {
            int[] arr = { 80, 60, 10,40, 50, 30, 100, 0, 50 };
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] + arr[j] == 100)
                    {
                        Console.WriteLine(arr[i] + "+" + arr[j]);
                    }
                }
            }
            Console.ReadLine();
        }
int[] arr = { 1, 2, 3, 4, 5, 6, 7,8 };
            int last=arr.Length;
            int mid=last/2;
            Console.WriteLine(arr[mid]);
            Console.ReadLine();

 {
            int count = 0;
            int sum = 0;
            for(int i = 2; i <= 100; i++)
            {
                bool isPrime=true;
                for(int j = 2; j <= 100; j++)
                {
                    if(i%j==0 & i != j)
                    {
                        isPrime= false;
                    }
                }
                if(isPrime & count<4)
                {
                    sum = sum + (i * i);
                    count++;
                   
                }

            }
                    Console.WriteLine(sum);
            
            Console.ReadLine();
        }
 string str = "Engineer".ToLower();
            
            for (char i = 'a'; i <= 'z'; i++)
            {
                int count = 0;
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[j] == i)
                    {
                        count++;
                    }
                }
                if(count != 0) {
                    {
                        Console.WriteLine(i+" "+count);
                    } }
            }
            Console.ReadLine();
 string s1 = "string";
            string s2 = "trings";

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

             s1=new string(ch1);
             s2=new string(ch2);
            if (s1 == s2)
            {
                Console.WriteLine("Annagram String");
            }
            else
            {
                Console.WriteLine("Not Anagram string");
            }
 */