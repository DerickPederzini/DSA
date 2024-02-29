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
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
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
        //Redoing BestTimeToSell
        //Problem think through

        //With the array given
        //since you cant go back to sell, two pointers are a very good option 
        //one pointer for the lower price and one for the max price
        //1 - When find maxProfit, update maxprofit
        public static int bestTime(int[] prices)
        {

            int left = 0, right = 1;

            int maxProfit = 0;

            while(right < prices.Length)
            {
                //check if it is a profitable transaction
                if (prices[left] < prices[right])
                {
                    //update profit and compare it to maximum price
                    int profit = prices[right] - prices[left];
                    maxProfit = Math.Max(maxProfit, profit);
                }else
                {
                    //we found a very low price, so start checking again
                    left = right;
                    right += 1;
                }
            }
            return maxProfit;

        }
    }
}
