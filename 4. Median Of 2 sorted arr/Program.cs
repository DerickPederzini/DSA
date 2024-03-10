using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Median_Of_2_sorted_arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //https://leetcode.com/problems/median-of-two-sorted-arrays/description/
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double[] ans = new double[nums1.Length + nums2.Length];

            int i = 0;
            int c = 0;
            int j = 0;

            while (nums1.Length > c && nums2.Length > j)
            {
                if (nums1[c] > nums2[j])
                {
                    ans[i++] = nums2[j++];
                }
                else
                {
                    ans[i++] = nums1[c++];
                }

            }
            while (c < nums1.Length)
            {
                ans[i++] = nums1[c++];
            }
            while (j < nums2.Length)
            {
                ans[i++] = nums2[j++];
            }

            int mid = (ans.Length - 1) / 2;

            if (ans.Length % 2 == 0)
            {
                return (ans[mid] + ans[mid + 1]) / 2;
            }


            return ans[mid];
        }
    }
}
