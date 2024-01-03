using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchIn2DArr
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int [ , ] arr = {
                 {1, 2, 3 , 4 },
                 {5, 6, 7 ,8 },
                 {9, 10, 11 ,12 },
    
            };


            Console.WriteLine((search(arr, 11).ToString()));
        }

        static int[] search(int[ , ] arr, int target)
        {
            int r = 0;
            int c = arr.GetLength(0);

            while (r < arr.Length && c >= 0)
            {
                if (arr[r , c] == target)
                {
                    return new int[] { r, c };
                }
                if (arr[r , c] < target)
                {
                    r++;
                }
                else
                {
                    c--;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
