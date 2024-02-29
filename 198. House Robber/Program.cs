using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _198.House_Robber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rob(new int[] {1, 2, 3, 1});
        }


        //two values to keep track of the maximum amount being robbed at each house
        //rob1 basically represents the not adjacent house from rob2
        //rob2 represents the maximum value that can be obtained, that is because when the loop is over
        //by adding the current house robbed to rob1 (house not adjancent) 
        //and passing this max value to rob2, there will be a point where rob2 spots changing because maximum value has been reached
        public static int Rob(int[] nums)
        {
            int rob1 = 0, rob2 = 0;

            foreach(int x in nums)
            {
                int temp = Math.Max(x + rob1, rob2);
                rob1 = rob2;
                rob2 = rob2 = temp;
            }

            return rob2;
        }
        //ex 1, 2, 3, 1
        //on the first iteration: maxValue = 1 so rob2 = 1, rob1 = 0
        //on the second iteration: maxValue = 2, so rob2 = 2, rob1 = 1 ( last value that rob2 was ) 
        //on third iteration: maxValue = 4 (rob1 + current value) so rob2 = 4 (rob2 is the always max value from that iteration) and rob 1 = 2
        //on last iteration: maxValue = 4, (value from rob2) rob2 = same, rob1 = rob2;

    }
}
