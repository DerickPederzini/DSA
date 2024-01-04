using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();

            Console.WriteLine(fib(5, table));
            Console.WriteLine(fib(12, table));
            Console.WriteLine(fib(7, table));
            Console.WriteLine(fib(48, table));

            Console.ReadLine();
        }
        public static int fib(int n, Dictionary<int, int> table)
        {

            //  Using normal recursion
            //        if (n <= 2) return 1;
            //        return fib(n - 1) + fib(n - 2);

            //  Using Dynamic Programming
            //memoization
            //store duplicate subproblems to use later on

            if (table.ContainsKey(n)) return table[n];
            if (n <= 2) return 1;
            table.Add(n, (fib(n - 1, table) + fib(n - 2, table)));
            return table[n];



        }
    }
}
