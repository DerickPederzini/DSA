using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _56.MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] data = new int[][] {
            new int[] {1,3},
            new int[] {8,10},
            new int[] {15,18},
            new int [] {2, 6} };

            Merge(data);

        }
        public static int[][] Merge(int[][] intervals)
        {
            //O(nlogn)

            //sort the array for making things easier
            Array.Sort(intervals, new Comparison<int[]>(
                (x, y) => { return x[1] < y[1] ? -1 : 
                    (x[1] > y[1] ? 1 : 0); }));

            //A list so the intervals can be added properly
            List<int[]> output = new List<int[]>
            {
                intervals[0]
            };

            //interval is a jagged array
            foreach (var interval in intervals.Skip(1))
            {
                //lastInterval is the lastInterval value (one behind current), so an array containg 0 and 1 indexes only for this casew
                int[] lastInterval = output.Last();
                //lastEnd is the last part of the interval last
                int lastEnd = lastInterval[1];
                //start and end marks the current interval
                int start = interval[0];
                int end = interval[1];

                //then we have overlap
                if (start <= lastEnd)
                {
                    lastInterval[1] = Math.Max(lastEnd, end);
                }
                //ese we add and update lastInterval
                else
                {
                    output.Add(new int[] { start, end });
                }
            }

            return output.ToArray();

        }
    }
}
