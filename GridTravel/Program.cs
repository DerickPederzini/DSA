using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridTravel
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<string, long> table = new Dictionary<string, long>();

            Console.WriteLine(grid(18, 18, table));
            Console.WriteLine(gridNotDynamic(4, 3));

            Console.ReadKey();

        }

        public static long grid(int r, int c, Dictionary<string, long> memo)
        {

            String key = r + "," + c;

            if (memo.ContainsKey(key)) return memo[key];

            if (r == 1 && c == 1) return 1L;
            if (r == 0 || c == 0) return 0L;

            memo.Add(key, grid(r - 1, c, memo) + grid(r, c - 1, memo));

            return memo[key];
        }

        public static int gridNotDynamic(int r, int c)
        {
            if (r == 0 || c == 0) return 0;
            if (r == 1 && c == 1) return 1;

            return gridNotDynamic(r - 1, c) + gridNotDynamic(r, c - 1);
        }
    }
}
