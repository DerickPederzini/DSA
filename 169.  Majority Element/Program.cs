using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169.Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(MajorityElement(new int[] { 6, 5, 5 }));

            Console.Read();
        }
        public static int MajorityElement(int[] nums)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 1);
                }
                else
                {
                    dic[nums[i]] += dic[nums[i]];
                }
            }
            return dic.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;


        }
    }
}
