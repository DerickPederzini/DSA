using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depth_First_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<char>> dic = new Dictionary<char, List<char>>();
            dic['a'] = new List<char>() {'b', 'c' };
            dic['b'] = new List<char>() { 'd' };
            dic['c'] = new List<char>() { 'e' };
            dic['d'] = new List<char>() { 'f' };
            dic['e'] = new List<char>() { };
            dic['f'] = new List<char>() { };

            depthFirst(dic, 'a');

            Console.WriteLine("=============\nRecursion result ");
            Console.WriteLine("|\nV");

            depthFirstRecursive(dic, 'a');

            Console.ReadLine();
        }

        static void depthFirst (Dictionary<char, List<char>> dic, char source)
        {
            Stack<char> stack = new Stack<char>();
            stack.Push(source);

            while (stack.Count() > 0)
            {
                var current = stack.Pop();
                Console.WriteLine(current);

                foreach (var item in dic[current])
                {
                    stack.Push(item);
                }
            }
        }

        static void depthFirstRecursive(Dictionary<char, List<char>> dic, char source)
        {
            Console.WriteLine(source);

            foreach (var neightbour in dic[source])
            {
                depthFirstRecursive(dic, neightbour);
            }

        }


    }

}
