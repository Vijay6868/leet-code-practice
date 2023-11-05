using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1= { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;

            Merge(nums1, m, nums2, n);
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for(int i=0; i < m + n; i++)
            {
                if (nums1[i] == 0)
                {
                    int j = 0;
                    while (j < n)
                    {
                        nums1[i] = nums2[j];
                        j++;
                        break;
                    }
                }
                Console.WriteLine(nums1[i]);
            }
        }
    }
}
