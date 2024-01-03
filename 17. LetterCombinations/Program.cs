using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList <string> list = LetterCombinations("23");

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
        public static IList<string> LetterCombinations(string digits)
        {

            IList<string> ans = new List<string>();

            if (digits.Equals("")) return ans;

            IList<string> list = finished("", digits, ans);

            return list;

        }

        static IList<string> finished(string processed, string digits, IList<string> ans)
        {

            if (digits.Equals(""))
            {
                ans.Add(processed);
                return ans;
            }


            int digit = digits[0] - '1';

            if (digit == 6 || digit == 8)
            {
                for (int i = (digit - 1) * 3; i < digit * 3 + 1; i++)
                {
                    char ch = (char)('a' + i);

                    finished(processed + ch, digits.Substring(1), ans);
                }
            }
            else
            {
                for (int i = (digit - 1) * 3; i < digit * 3; i++)
                {
                    char ch = (char)('a' + i);

                    finished(processed + ch, digits.Substring(1), ans);

                }
            }

            return ans;
        }
    }
}
