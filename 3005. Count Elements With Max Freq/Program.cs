using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3005.Count_Elements_With_Max_Freq
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //https://leetcode.com/problems/count-elements-with-maximum-frequency/
        public int MaxFrequencyElements(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int repetead = 0;

            //after filling the map with all the values
            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                    map[num] = 0;
                map[num]++;
            }
            //we create a max variable that will compare the frequency of each number with its current 
            //maximum
            int max = 0;

            foreach (int num in map.Values)
            {
                //get the maximum frequency of elements
                max = Math.Max(max, num);
            }

            //if the maximum frequence of each value is equal to the max repetead value of the
            //array, then add to repetead
            foreach (int freq in map.Values)
            {
                if (freq == max)
                    repetead += max;
            }
            //the problem asks for the maximum frequent element, so if we have 3 17, the
            //maximum value is 3, but if we have another 3 12, the maximum value becomes 6

            return repetead;
        }
    }
}
