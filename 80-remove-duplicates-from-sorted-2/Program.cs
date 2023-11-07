using System;

namespace _80_remove_duplicates_from_sorted_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 1, 2, 2, 3 };
            Console.WriteLine(removeDuplicates(arr));
        }
        public static int removeDuplicates(int[] nums)
        {
            int count = 0;
            int count2 = 0;
            
            for(int i=0; i < nums.Length-1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    if (count2 == 1)
                    {
                        nums[count] = nums[i];
                            count2 = 0;
                    }
                    

                    count++;
                }

            }
            nums[count] = nums[nums.Length - 1];

            foreach(int element in nums)
            {
                Console.WriteLine(element);
            }
            return count+1;
        }
    }
}
