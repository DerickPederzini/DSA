using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 6, 4, 8, 12, 56, 23, 7, 98, 236, 5, 7, 45, 0 };

            sort(arr, 0, arr.Length - 1);
        }

        public static void sort(int[] arr, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int s = low;
            int e = high;
            int m = s + (e - s) / 2;
            int pivot = arr[m];

            while (s <= e) 
            {
                while (arr[s] < pivot)
                {
                    s++;
                }
                while (arr[e] > pivot)
                {
                    e--;
                }

                if (s <= e) 
                {
                    int temp = arr[s];
                    arr[s] = arr[e];
                    arr[e] = temp;

                    s++;
                    e--;
                }

            }

            sort(arr, low, e);
            sort(arr, s, high);


        }

    }
}
