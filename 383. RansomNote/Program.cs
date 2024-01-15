using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383.RansomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CanConstruct("aa", "aab");
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            for(int i = 0; i < magazine.Length; i++)
            {
                if (!(dic.ContainsKey(magazine[i])))
                {
                    dic.Add(magazine[i], 1);
                }
                else
                {
                    dic.TryGetValue(magazine[i], out var count);
                    dic[magazine[i]] = count + 1;
                }
            }

            for(int i = 0; i < ransomNote.Length; i++)
            {
                if (!(dic.ContainsKey(ransomNote[i]))&& dic[ransomNote[i]] > 0)
                {
                    return false;
                }
                dic.TryGetValue(ransomNote[i], out var count);
                dic[ransomNote[i]] = count - 1;

            }

            return true;

    }
    }
}
