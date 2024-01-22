using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsValid("()[]");
            IsValidReview("(]");
        }

        public static bool IsValid(string s)
        {

            var stack = new Stack<char>();
            var dic = new Dictionary<char, char>()
            {
                [')'] = '(',
                [']'] = '[',
                ['}'] = '{'
            };

            foreach (char c in s)
            {
                if (!dic.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0 || stack.Pop() != dic[c])
                {
                    return false;
                }
            }

            return stack.Count == 0;

        }

        public static bool IsValidReview(string s)
        {
            Stack<char>stack = new Stack<char>();
            var dic = new Dictionary<char, char>()
            {
                {')','('},
                {']','['},
                {'}','{'}
            };

            foreach(char c in s)
            {
                if (!dic.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (stack.Count == 0 || stack.Pop() != dic[c]) return false;
            }
            return stack.Count == 0;
;            
        }

    }
}
