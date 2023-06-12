using System;

namespace DuplicateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 54, 13, 14, 12, 11, 15, 14, 12, 14 };

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                {
                    Console.WriteLine("Duplicate Number: " + arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
