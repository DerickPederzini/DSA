using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(6));
        }

        public static int fib(int n)
        {
            if (n <= 1)
                return n;

            int[] tab = new int[n + 1];
            Array.Clear(tab, 0, tab.Length);
            tab[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                tab[i] = tab[i - 1] + tab[i - 2];
            }

            return tab[n];
        }
    }
}
