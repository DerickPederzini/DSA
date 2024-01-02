using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakIndexInMountainArr
{
    internal class Program
    {
        //https://leetcode.com/problems/peak-index-in-a-mountain-array/

        static void Main(string[] args)
        {
            peakIndexInMountArr(new int[] { 1, 2, 3, 4, 10, 6, 7 });
        }

        public static int peakIndexInMountArr(int [] nums)
        {
            int s = 0;
            int e = nums.Length - 1;

            while(s < e)
            {
                int mid = s + (e - s) / 2;
                
                if (nums[mid] > nums[mid + 1])
                {
                    e = mid;

                }else
                {
                    s = mid + 1;
                }
            }
            return s;

        }
    }
}
