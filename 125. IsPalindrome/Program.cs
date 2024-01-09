using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125.IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ispalindrome("a man, a plan, a canal: panama"));
            Console.Read();
        }
        public static bool ispalindrome(string s)
        {
            char start = s[0];
            char end = s[s.Length - 1];

            for (int i = 1; i < s.Length - 1; i++)
            {
                if (start == end)
                {
                    start = s[i];
                    end = s[s.Length - i - 1];
                }
                else return false;
            }
            return true;

        }
    }
}
