using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57.Insert_Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int n = intervals.Length;
            int i = 0;

            var list = new List<int[]>();

            //if there is no overlapp, push into ans 
            while (i < n && intervals[i][1] < newInterval[0])
            {
                list.Add(intervals[i]);
                i++;
            }

            //there is overlapping, update the new interval start point with min, update the other one using max
            while(i < n && newInterval[1] >= intervals[i][0])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            //push the answer of the biggest interval in the answer
            list.Add(newInterval);

            //add the intervals left after the merge
            while (i < n)
            {
                list.Add(intervals[i]);
                i++;
            }

            return list.ToArray();


        }
    }
}
