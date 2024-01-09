using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] n = TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int rest = target - nums[i];
                if (map.ContainsKey(rest))
                {
                    return new int[] { map[rest], i };
                }
                map.Add(nums[i], i);
            }

            return new int[] { };


        }
    }
}
