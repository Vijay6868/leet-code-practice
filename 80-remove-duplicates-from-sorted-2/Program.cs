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
            int i = 0;

            while ( i< nums.Length - 1) 
            {
                // comparing 
                if (nums[i] == nums[i + 1])
                {
                    nums[count] = nums[i];
                    nums[count + 1] = nums[i + 1];
                    count = count + 2;
                    i = i + 2;
                    if (nums[i] == nums[i - 1])
                    {

                    }
                }
                else if (nums[i] != nums[i + 1])
                {
                    if (i == 0)
                    {
                        i=i+2;
                    }
                    else if(i>0 && nums[i]!=nums[i-1])
                }
                
                else
                {

                }

            }
            //nums[count] = nums[nums.Length - 1];

            foreach(int element in nums)
            {
                Console.WriteLine(element);
            }
            return count+1;
        }
    }
}
