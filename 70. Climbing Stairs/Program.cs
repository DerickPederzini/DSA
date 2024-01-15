using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClimbStairs(4);
        }

        static int ClimbStairs(int n)
        {
            int c = Count(n, new Dictionary<int, int>());
            return c;
        }

        static int Count(int n,  Dictionary<int, int > memo)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            if (!memo.ContainsKey(n))
            {
                memo.Add(n, Count(n - 1, memo) + Count(n - 2, memo));
            }
            return memo[n];
        }
    }
}
