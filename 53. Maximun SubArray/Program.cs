using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Maximun_SubArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 90});
        }
        public static int MaxSubArray(int[] nums)
        {
            int n  = nums.Length;
            int max = int.MinValue;
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                sum+= nums[i];
                max = Math.Max(max, sum);

                if (sum < 0) sum = 0;
            }

            return max;
        }
    }
}
