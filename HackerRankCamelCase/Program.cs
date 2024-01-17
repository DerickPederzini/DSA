using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCamelCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "saveChangesInTheEditor";
            Console.Write(camelcase(s));
        }
        public static int camelcase(string s)
        {
            if(s.Equals(null))
            {
                return 0;
            }
            int count = 1;
            

            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    count++;
                }
            }

            return count;


        }
    }
}
