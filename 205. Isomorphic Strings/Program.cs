using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205.Isomorphic_Strings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {

            if (s.Length != t.Length) return false;

            if (s.Length < 2 && t.Length < 2) return true;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {

                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                }
                else
                {
                    dic.Add(s[i], i);
                }
                if (dic2.ContainsKey(t[i]))
                {
                    dic2[t[i]]++;
                }
                else
                {
                    dic2.Add(t[i], i);
                }

            }

            for (int i = 0; i < s.Length; i++)
            {

                if (dic[s[i]] != dic2[t[i]])
                {
                    return false;
                }
                else if (dic[s[i]] != dic2[t[i]] && s[i] == t[i]) return true;

            }
            return true;

        }
    }
}
