using System;
using System.Collections.Generic;

namespace MedianOfTwoSortedArrays
{
    internal class Program
    {
        //Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
        // nums1.length == m, nums2.length == n

        static void Main(string[] args)
        {
            int[] test1 = { 1, 3 };
            int[] test2 = { 2 };

            Console.WriteLine($"Expected: 2, Output: {FindMedianSortedArrays(test1, test2)}");

            int[] test3= { 1, 2 };
            int[] test4 = { 3, 4 }; 

            Console.WriteLine($"Expected: 2.5, Output: {FindMedianSortedArrays(test3, test4)}");
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<double> numsList = new List<double>();
            foreach (int num in nums1)
            {
                numsList.Add((double)num);
            }
            foreach (int num in nums2)
            {
                numsList.Add((double)num);
            }
            numsList.Sort();

            if (numsList.Count % 2 != 0)
            {
                return numsList[numsList.Count / 2];
            }
            else
            {
                return (numsList[(numsList.Count / 2) - 1] + numsList[numsList.Count / 2]) / 2.0;
            }
        }
    }
}
