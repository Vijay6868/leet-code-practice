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
            
            
            for(int i=0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    i++;
                    Console.WriteLine("if executed");
                }
                Console.WriteLine("value of "+i);
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
