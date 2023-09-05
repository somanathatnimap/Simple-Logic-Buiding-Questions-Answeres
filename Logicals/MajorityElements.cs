using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals
{
    internal class MajorityElements
    {
        public int MajorityElement(int[] nums)
        {
            int candidate = 0;
            int count = 0;

            for(int i=0;i<nums.Length;i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }

                if (nums[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }
        static void Main(string[] args)
        {
        MajorityElements majorityElements = new MajorityElements();
        int[] nums1 = { 3, 2, 3 };
        int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };

            int result1= majorityElements.MajorityElement(nums1);
            int result2 = majorityElements.MajorityElement(nums2);

        Console.WriteLine(result1); 
        Console.WriteLine(result2); 
        Console.ReadLine();
        }


    }
}
