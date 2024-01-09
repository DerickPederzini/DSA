using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(canSum(7, new int [] { 1,2,3,4,5,6,7}));
            Console.Write(canSum(300, new int[] { 7, 14 }));

            Console.Read();
        }

        public static bool canSum(int targetSum, int[] numbers)
        {
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            foreach (var num in  numbers)
            {
                int remainder = targetSum - num;
                if (canSum(remainder, numbers) == true) return true;
            }
            return false;

        }
    }
}
