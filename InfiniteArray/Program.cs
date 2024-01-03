using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checksInfinite(new int[] { 1, 23, 45, 67, 43, 100, 200, 3000, 5664, 32456, 43433, 12512, 4636332, 3253256, 3253296, 3283296, 3283298 }, 200);      
        }

        public static int checksInfinite(int[] arr, int target)
        {
            int s = 0;
            int e = 1;

            while (arr[e] < target)
            {
                int temp = e + 1;// new start
                e =  e + (e - s + 1) * 2;//making end bigger
                s = temp;
            }


            return search(arr, target, s, e);
        }

        public static int search(int[]arr, int target, int s, int e)
        {
            int mid = s + (e - s) / 2;

            while (e >= s)
            {
                if (arr[mid] < target)
                {
                    e = mid - 1;
                }else if (arr[mid] > target)
                {
                    s = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
