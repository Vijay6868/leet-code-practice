using System;

namespace _26_remove_duplicates_from_sorted_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(nums));
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int temp = 0;
            for (int i=0; i < nums.Length-1; i++)
            {
                
                if (nums[i] != nums[i + 1])
                {
                    nums[temp] = nums[i];
                    temp++;
                }
            }
            
            nums[temp] = nums[nums.Length-1];
            return temp+1;
        }
    }
}
