using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300.Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
        }

        public static int LengthOfLIS(int[] nums)
        {

            return calculate(nums, 0);

        }

        public static int calculate(int[] nums, int count)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums.Length == i)
                {
                    return stack.Count();
                }

                if (nums[i] > nums[i+1]) 
                {
                    count--; 
                }
                if (nums[i] < nums[i + 1])
                {
                    stack.Push(nums[i]);
                }
            }
            return stack.Count();

        }


        
    }
}
