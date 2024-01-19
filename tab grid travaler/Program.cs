using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tab_grid_travaler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gridTraveler(3, 3));
            Console.WriteLine(gridTraveler(15, 15));
        }

        public static int gridTraveler(int r, int c)
        {
            var table = new int [r + 1,c + 1];
            Array.Clear(table, 0, c);

            table[1, 1] = 1;

            for (int i = 0; i <= r; i++)
            {
                for(int j = 0; j <= c; j++)
                {
                    var current = table[i,j];
                    if(j + 1 <= c) table[i,j + 1] += current;
                    if(i + 1 <= r) table[i + 1,j] += current;
                }
            }
            
            return table[r,c];
        }
    }
}
