using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136.SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleNumber(new int[] { 1, 2, 2, 5, 5 });
        }
        public static int SingleNumber(int[] nums)
        {
            if(nums.Length < 2)
                return nums[0];
            

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(nums[i])) keyValuePairs.Add(nums[i], i);
                else keyValuePairs.Remove(nums[i]);
            }

            foreach(var i in keyValuePairs.Keys)
            {
                return i;
            }

            return 0;



        }
    }
}
