using System;
using System.Collections.Generic;

namespace MissingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                int element;
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                }
                arr[i] = element;
            }

            Console.WriteLine("Enter the start of the range:");
            int start;
            while (!int.TryParse(Console.ReadLine(), out start))
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }

            Console.WriteLine("Enter the end of the range:");
            int end;
            while (!int.TryParse(Console.ReadLine(), out end))
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }

            List<int> missingElements = FindMissingElements(arr, start, end);

            Console.WriteLine("Missing elements in the array:");
            foreach (int element in missingElements)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }

        static List<int> FindMissingElements(int[] arr, int start, int end)
        {
            List<int> missingElements = new List<int>();

            // Create a HashSet to store the elements of the array
            HashSet<int> elements = new HashSet<int>(arr);

            // Iterate through the range from start to end
            for (int i = start; i <= end; i++)
            {
                // Check if the element is missing in the HashSet
                if (!elements.Contains(i))
                {
                    missingElements.Add(i);
                }
            }

            return missingElements;
        }
    }
}
