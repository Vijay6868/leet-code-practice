using System;

namespace _27_Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int[] nums1 = { 3, 2, 2, 3 };
            int val1 = 2;
            //Console.WriteLine(nums1);
            Console.WriteLine(RemoveElement(nums1, val1));
            
        }
        public static int RemoveElement(int[]nums, int val)
        {
            int result = 0;
            foreach (int item in nums)
            {
                if (item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }
    }
}
