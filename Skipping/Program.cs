using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skipping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            skip("", "apple");

            string p = skipReturn("", "kraft");
            Console.WriteLine(p);

            Console.WriteLine(skipApple("apple"));

            Console.WriteLine(skipAppleandApp("bacapplcdah"));

            Console.Read();

        }
        static void skip(string p, string up)
        {
            if (up.Equals(""))
            {
                Console.WriteLine(p);
                return;
            }
            char ch = up[0];

            if (ch == 'a')
            {
                skip(p, up.Substring(1));
            }
            else
            {
                skip(p + ch, up.Substring(1));
            }
        }

        static string skipReturn(string p, string up)
        {
            if (up.Equals("")) return p;

            char ch = up[0];

            if(ch == 'a')
            {
                return skipReturn(p, up.Substring(1));
            }
            else
            {
                return skipReturn(p + ch, up.Substring(1));
            }

        }
        static string skipApple(string up)
        {
            if (up.Equals("")) return "";

            if (up.StartsWith("apple"))
            {
                return skipApple(up.Substring(5));
            }
            else
            {
                return (up[0] + skipApple(up.Substring(1)));
            }

        }

        static string skipAppleandApp( string up)
        {
            if (up.Equals("")) return "";

            if (up.StartsWith("app") || up.StartsWith("apple"))
            {
                return skipAppleandApp(up.Substring(5));
            }
            else
            {
                return (up[0] + skipAppleandApp(up.Substring(1)));
            }

        }
    }
}
