using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2864.Maximum_Odd_Binary_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumOddBinaryNumber("01001");
        }
        public static string MaximumOddBinaryNumber(string s)
        {
            string zeroes = "";
            string ones = "";

            string output = "";

            foreach (char x in s)
            {

                if (x == '0')
                {
                    zeroes = zeroes.Insert(0, "0");
                }
                else
                {
                    if (string.IsNullOrEmpty(ones))
                    {
                        output = output.Insert(0, "1");
                        ones = ones.Insert(0, "1");
                    }
                    else
                    {
                        ones = ones.Insert(0, "1");
                    }
                }
            }
            ones = ones.Remove(0, 1);

            output = output.Insert(0, zeroes);
            output = output.Insert(0, ones);

            return output;
        }
    }
}
