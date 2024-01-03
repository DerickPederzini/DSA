using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dice("", 4);

            Console.ReadLine();
        }
        static void dice(string p, int target)
        {
            if (target == 0)
            {
               Console.WriteLine(p);
               return;
            }

            for (int i = 1; i <= 6 && i <= target; i++)
            {
                dice(p + i, target - i);
            }
        }
    }
}
