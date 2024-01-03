using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInMountArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ ] arr = { 1 , 4, 6, 5, 3, 2 };

            peakInd(arr, 3);
        }

        public static int peakInd(int[] arr, int target)
        {
            int peak = findPeak(arr, target);
            int firstTry = search(arr, 0, peak, target);
            if(firstTry != -1)
            {
                return firstTry;
            }
            return search(arr, peak + 1, arr.Length - 1, target);
        }

        public static int findPeak(int[] arr, int target)
        {
            int s = 0;
            int e = arr.Length - 1;
        
            while(s < e)
            {
                int m = s + (e - s) / 2;
                if (arr[m] > arr[m  + 1])
                {
                    e = m;
                }else
                {
                    s = m + 1;
                }
            }
            return s;
            
        }
        public static int search(int[] arr, int start, int end, int target)
        {
            bool isAsc = arr[start] < arr[end];

            while (start <= end)
            {
                int mid = start + (end - start) / 2;



                if (arr[mid] == target)
                {
                    return mid;
                }

                if (isAsc)
                {
                    if (arr[mid] > target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if (arr[mid] < target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

            }

            return -1;


        }
    }
}
