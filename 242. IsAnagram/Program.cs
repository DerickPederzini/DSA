using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242.IsAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsAnagram("ccac", "aacc"));

            Console.ReadLine();
        }
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char ch in s)
            {
                if (dic.ContainsKey(ch))
                {
                    dic[ch]++;
                }
                else
                {
                    dic[ch] = 1;
                }
            }

            foreach (char ch in t)
            {
                if (!dic.ContainsKey(ch))
                {
                    return false;
                }

                dic[ch]--;
                if (dic[ch] == 0)
                {
                    dic.Remove(ch);
                }
            }

            return dic.Count == 0;


        }
    }
}
