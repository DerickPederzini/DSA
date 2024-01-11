using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision___QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 9, 2, 3, 5, 7, 3, 2, 2, 13, 5 };
            Sort(nums, nums.Length - 1, 0);
        }
        static void Sort(int[] nums, int high, int low)
        {
            if(high <= low)
            {
                return;
            }
            int s = low;
            int e = high;
            int mid = s + (e - s) / 2;
            int pivot = nums[mid];

            while(s <= e)
            {
                while (nums[e] > pivot)
                {
                    e--;
                }

                while (nums[s] < pivot)
                {
                    s++;
                }

                if(s<= e)
                {
                    int temp = nums[s];
                    nums[s] = nums[e];
                    nums[e] = temp;

                    s++;
                    e--;    
                }
            }

            Sort(nums, high, s);
            Sort(nums, e, low);


        }
    }
}
