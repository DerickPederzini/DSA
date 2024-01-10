using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _409.LongestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("abccccdde"));
        }
        public static int LongestPalindrome(string s)
        {
            int result = 0;
            if(s.Length == 1) return 1;
            if (s.Length == 0) return 0;


            Dictionary<char, int> dic = new Dictionary<char, int>();
            //i dont know why i used a dictionary here, could have used a hashset, but ok

            foreach(char c in s)
            {
                if (!(dic.ContainsKey(c)))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    //dic only has the singular characters, not duplicate ones, if there is a duplicate, remove
                    //if c present in dictionary, that means there is a pair, so add 2
                    result+=2;
                    dic.Remove(c);
                    
                }
            }
            //if there is still one left over value, it can always be placed in the middle of a palindrome, so add one to result
            if (!dic.Count.Equals(0)) result++;
            return result;

        }
    }
}
