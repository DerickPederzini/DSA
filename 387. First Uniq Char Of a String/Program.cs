using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _387.First_Uniq_Char_Of_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstUniqChar("aadadaad");
        }
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!hash.ContainsKey(s[i]))
                {
                    hash.Add(s[i], 1);
                }
                else
                {
                    hash[s[i]]--;
                }
            }
            if (hash.Count() == 0) return -1;
            int j = 0;
            while (hash.Count() > 0)
            {
                if (hash.ContainsKey(s[j]) && hash[s[j]] <= 0) hash.Remove(s[j]);

                if (hash.ContainsKey(s[j])) return j;

                j++;
            }
            return -1;
        }
    }
}
