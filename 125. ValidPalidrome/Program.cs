using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125.ValidPalidrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(IsPalindromeReview("A man, a plan, a canal: Panama"));
        }

        public static bool IsPalindrome(string s)
        {
            if (s.Length < 2)
            {
                //0 or 1 letter are palindromes
                return true;
            }

            int start = 0;//keep 2 pointers to track the strings iteration
            int end = s.Length - 1;

            s = s.ToLowerInvariant();//making to lower now so i dont have to latter

            while(start < end)
            {
                char leftChar = s[start];
                char rightChar = s[end];

                /*
                 *Char.Is****OrDigit allows to check if you have commas, periods, parentheses, etc 
                 *also i just learned this form of comment, which is pretty cool
                */

                if (!(Char.IsLetterOrDigit(leftChar)))
                {
                    start++;//skip if not a letter or digit
                }
                else if (!(Char.IsLetterOrDigit(rightChar)))
                {
                    end--;//skip if not a letter or digit
                }
                else
                {
                    if(leftChar != rightChar) return false;

                    start++;
                    end--;
                }
            }
            return true;

        }

        public static bool IsPalindromeReview(string s)
        {
            if(s.Length < 2) return true;
            
            int start = 0;
            int end = s.Length - 1;

            s = s.ToLowerInvariant();

            while( start < end )
            {

                char leftchar = s[start];
                char rightChar = s[end];

                if (!Char.IsLetterOrDigit(leftchar))
                {
                    start++;
                }
                else if (!Char.IsLetterOrDigit(rightChar))
                {
                    end--;
                }
                else
                {
                    if (leftchar != rightChar) return false;

                    start++;
                    end--;
                }
                
            }
            return true;


        }
    }
}
