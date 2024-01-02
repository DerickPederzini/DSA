using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121.BestTimeToSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        }
        public static int MaxProfit(int[] prices)
        {

            return rec(prices);

        }
        public static int rec(int[] prices)
        {

            int min_price = prices[0];
            int maxprof = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                maxprof = Math.Max(maxprof, prices[i] - min_price);
                min_price = Math.Min(prices[i], min_price);
            }

            return maxprof;
        }
    }
}
