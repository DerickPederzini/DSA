using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
             permutations("", "abc");

            Console.WriteLine("----------------");
            Console.WriteLine("----------------");

            ArrayList ans = permutationsList("", "abc");
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");

            int ans2 = permutationsCount("", "abcd");

            Console.WriteLine(ans2);

            Console.ReadKey();
        }
        static void permutations(string p, string up)
        {
            if (up.Equals(""))
            {
                Console.WriteLine(p);
                return;
            }
            char ch = up[0];
            for (int i = 0; i <= p.Length; i++)
            {
                string f = p.Substring(0, i);
                string s = p.Substring(i);
                permutations(f + ch + s, up.Substring(1));
            }
        }

        static ArrayList permutationsList(string p, string up)
        {
            if(up.Equals(""))
            {
                ArrayList list = new ArrayList();
                list.Add(p);
                return list;
            }
            char ch = up[0];

            // local to this call
            ArrayList ans = new ArrayList();

            for (int i = 0; i <= p.Length; i++)
            {
                string f = p.Substring(0, i);
                string s = p.Substring(i);
                ans.AddRange(permutationsList(f + ch + s, up.Substring(1)));
            }
            return ans;
        }

        static int permutationsCount(string p, string up)
        {
            if (up.Equals(""))
            {
                return 1;
            }
            int c = 0;
            char ch = up[0];
            for (int i = 0; i <= p.Length; i++)
            {
                string f = p.Substring(0, i);
                string s = p.Substring(i);
                c = c + permutationsCount(f + ch + s, up.Substring(1));
            }
            return c;
        }
    }
}
