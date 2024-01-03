using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            search(arr, 0, arr.Length - 1, 4);
        }
        //22
        public static int search(int[] arr, int start, int end, int target)
        {
            while(start <= end) 
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return -1;


        }
    }
}
