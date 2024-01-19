using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_MinimalPathSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] path = new int[,]
            {
                {1, 3, 1 },{ 1,5, 1 }, {4, 2 ,1}
            };

           Console.WriteLine( minimalPath(path, new Dictionary<int, int>()));
        }

        public static int minimalPath(int[,] path, Dictionary<int, int> memo) 
        {

            if (path.Length == 1 && path.GetLength(0) == 1) return path[0,0];

            int[,] dp = new int[path.Length , path.GetLength(0)];

            for (int i = 0; i < path.Length; i++)
            {
                for (int j = 0; j < path.GetLength(0); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i,j] = path[i,j];
                    }
                    else if (i == 0)
                    {
                        dp[i,j] = path[i,j] + dp[i,j - 1];
                    }
                    else if (j == 0)
                    {
                        dp[i,j] = path[i,j] + dp[i - 1,j];
                    }
                    else
                    {
                        dp[i,j] = path[i,j] + Math.Min(dp[i - 1,j], dp[i,j - 1]);
                    }
                }
            }

            return dp[dp.Length - 1,dp.GetLength(0) - 1];

        }
    }
}
