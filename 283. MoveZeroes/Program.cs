using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283.MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes(new int [] { 0, 1, 0, 3, 12 });
        }

        public static void MoveZeroes(int[] nums)
        {

            if (nums.Length == 1)
            {
                return;
            }
                
            int j = 0;

            //check for the amount of zeroes in array via their index
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }

            }

            //add the amount of zeroes to the end of array
            while (j < nums.Length)
            {
                nums[j] = 0;
                j++;
            }

        }
    }
}
