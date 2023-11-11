using System;

namespace _169_Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 1, 1, 4, 1, 1, 5, 1, 1, 6, 2, 2 };

            Console.WriteLine(MajortiyElement(arr));
        }
        public static int MajortiyElement(int[] nums)
        {
            int count = 0, collector = 0, majEle = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                if (count > collector)
                {
                    majEle = nums[i];
                    collector = count;
                }
                
                count = 0;
                
            }
            return majEle;
        }
    }
}
