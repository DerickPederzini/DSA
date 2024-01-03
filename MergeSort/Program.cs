using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {6, 3, 1, 2};

            Merge(arr, 0, arr.Length);
        }

        static void Merge(int[] arr, int s, int e)
        {
            if (e - s == 1)
            {
                return;
            }

            int m = s + (e - s) / 2;

            Merge(arr, s, m);
            Merge(arr, m, e);

            Sorting(arr, s, m, e);
        }

        private static void Sorting(int[] arr, int s, int m, int e)
        {
            int[] mix = new int[e - s];

            int i = s;
            int j = m;
            int k = 0;

            while (i < m && j < e)
            {
                if (arr[i] < arr[j])
                {
                    mix[k] = arr[i];
                    i++;
                }
                else
                {
                    mix[k] = arr[j];
                    j++;
                }
                k++;
            }

            // it may be possible that one of the arrays is not complete
            // copy the remaining elements
            while (i < m)
            {
                mix[k] = arr[i];
                i++;
                k++;
            }

            while (j < e)
            {
                mix[k] = arr[j];
                j++;
                k++;
            }

            for (int l = 0; l < mix.Length; l++)
            {
                arr[s + l] = mix[l];
            }
        }
    }
}
