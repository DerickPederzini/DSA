using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> result = allConstruct("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd", "ef", "c" });

            Console.WriteLine("All Constructed Ways:");
            foreach (var way in result)
            {
                Console.WriteLine($"[{string.Join(", ", way)}]");
            }
        }


        //given an string s and a workdbank, return a list of strings of all of the ways that we can form the string s with the wordbank values
        public static List<List<string>> allConstruct(string s, List<string> wordbank) 
        {
            if (s == "")
                return new List<List<string>> { new List<string>() };

            List<List<string>> result = new List<List<string>>();

            foreach (var word in wordbank)
            {
                if (s.IndexOf(word) == 0)
                {
                    string suffix = s.Substring(word.Length);
                    List<List<string>> suffixWays = allConstruct(suffix, wordbank);
                    List<List<string>> sWays = suffixWays.Select(way => new List<string> { word }.Concat(way).ToList()).ToList();
                    result.AddRange(sWays);
                }
            }

            return result;

        }
    }
}
