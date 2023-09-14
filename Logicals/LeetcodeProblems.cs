using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logicals
{
    internal class LeetcodeProblems
    {
       static void Main(string[] args)
        {
            
            IEnumerable<int> list=new List<int>() { 1,2,3,4,5,5};
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 5 };
            
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
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
string str="soma";
        char ch;
        for(int i=str.Length-1;i>=0;i--)
        {
            ch=str[i];
            str=str+ch;
            //str1=str1+str[i];
        }
        Console.WriteLine(str);
   public static void Main(string[] args)
    {
       string s1="JavaProgrammer";
       string s2=s1+s1;
       string s3="";
       char[] ch=s2.ToCharArray();
       for(int i=4;i<s1.Length+4;i++){
           s3=s3+ch[i];
       }
       Console.WriteLine(s3);
    }
   int[] arr = { 2, 5, 1, 6, 3, 9 };
            int min = int.MaxValue;
            int max = int.MinValue;
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                 if (arr[i] < min)
                {
                    min = arr[i];
                }
                temp = max;
                max = min;
                min= temp;
            }
            Console.ReadLine();

  int[] arr = {3,4,5,1,2,6,7,3 };
            int min = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        arr[j] = arr[i];
                    }
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
 Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "soma");
            hashtable.Add(2, "mama");

            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(1, 1);
            dic.Add(2, 2);

 enum Week
        {
            Monday,
            Tuesday
        }
int a=(int)Week.Monday;
            Console.WriteLine(a);
 */