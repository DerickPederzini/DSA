using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _49.Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var groups = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] count = new char[26];
                foreach(char c in strs[i])
                {
                    count[c - 'a']++;
                }

                string key = new string(count);
                if (!groups.ContainsKey(key))
                {
                    groups[key] = new List<string>();
                }
                groups[key].Add(strs[i]);

            }

            return groups.Values.ToList();

        }
    }
}
