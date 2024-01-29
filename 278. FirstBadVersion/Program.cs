using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _278.FirstBadVersion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstBadVersion(5));
        }

        //https://leetcode.com/problems/first-bad-version/
        public static int FirstBadVersion(int n)
        {

            if (n < 2) return n;

            int start = 0;
            int end = n;

            while (end > start)
            {
                int mid = start + (end - start) / 2;

                if (!IsBadVersion(mid))
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return end;

        }

        public static bool IsBadVersion(int n)
        {
            //this should do something, but the problem just gives to me
            return false;
        }
    }
}
