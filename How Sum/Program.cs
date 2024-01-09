using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(howSum(new int[] { 2, 5, 3 }, 7, new Dictionary<int, int>() { }));
            

            Console.ReadLine();
        }

        public static int [] howSum(int[] nums, int target, Dictionary<int, int> memo)
        {
            if(target == 0) return new int[] { 0 };
            if(target < 1) return null;

            for(int i = 0; i < nums.Length; i++) 
            {
                int rest = target - nums[i];
                int [] remainderResult = howSum(nums, rest, memo);

                if (remainderResult[i] != null)
                {
                    memo.Add(1, 1);
                }  

            }
            return null;


        }
    }
}
