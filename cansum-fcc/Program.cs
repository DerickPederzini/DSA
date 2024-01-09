using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cansum_fcc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(canSum(7, new int[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(canSum(30, new int[] { 7, 14 }));

            Console.WriteLine("|\nV memoization");

            Console.WriteLine(canSumMemo(7, new int[] { 1, 2, 3, 4, 5, 6, 7 }, new Dictionary<int, bool>() { }));
            Console.WriteLine(canSumMemo(300, new int[] { 7, 14 }, new Dictionary<int, bool> () { }));

            Console.ReadKey();
        }
        public static bool canSum(int targetSum, int[] numbers)
        {
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            foreach (var num in numbers)
            {
                int remainder = targetSum - num;
                if (canSum(remainder, numbers) == true) return true;
            }
            return false;

        }

        public static bool canSumMemo(int targetSum, int[] numbers, Dictionary<int, bool> memo)
        {
            if (memo.ContainsKey(targetSum)) return memo[targetSum];
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            foreach (var num in numbers)
            {
                int remainder = targetSum - num;
                if (canSumMemo(remainder, numbers, memo) == true)
                {
                memo[targetSum] = true;

                return true;
                }
            }
            memo[targetSum] = false;
            return false;

        }
    }
}
