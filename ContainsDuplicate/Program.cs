using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217.ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
            Console.Write(ContainsDuplicateReview(new int[] { 1, 2, 3,4,5,6,7,8,1 }));

            Console.Read();
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary <int,int> dic = new Dictionary<int, int> ();
            foreach (int num in nums) 
            {
                if (!dic.ContainsKey(num))
                {
                    dic.Add (num, num);
                }
                else
                {
                    return true;
                }
            }
            return false;


        }

        public static bool ContainsDuplicateReview(int[] nums)
        {
            if (nums.Length < 2) return false;

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int> ();

            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(nums[i])) return true;

                keyValuePairs.Add(nums[i], i);
            }

            return false;

        }
    }
}
