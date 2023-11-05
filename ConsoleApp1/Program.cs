using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case 1");
            int[] nums1= { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            
            Merge(nums1, m, nums2, n);

            Console.WriteLine("\nCase 2");
            int[] nums3 = { 1 };
            int a = 1;
            int[] nums4 = {};
            int b = 0;

            Merge(nums3, a, nums4, b);

            Console.WriteLine("\nCase 3");
            int[] nums5 = { 0 };
            int[] nums6 = { 1 };
            int c = 0, d = 1;

            Merge(nums5, c, nums6, d);
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0;
            for (int i=0; i < m + n; i++)
            {
                if (nums1[i] == 0)
                {
                    
                    while (j < n)
                    {
                        nums1[i] = nums2[j];
                        
                        break;
                    }
                    j++;
                }
                //Console.WriteLine(nums1[i]);
            }
            //performing bubble sort
            for(int k=0; k < m + n; k++)
            {
                for(int l = 0; l < m + n-1; l++)
                {
                    if (nums1[l] > nums1[l+1])
                    {
                        int temp = nums1[l + 1];
                        nums1[l+1] = nums1[l];
                        nums1[l] = temp;
                    }
                }
            }
            for(int p=0; p < m + n; p++)
            {
                Console.WriteLine(nums1[p]);
            }
        }
    }
}
