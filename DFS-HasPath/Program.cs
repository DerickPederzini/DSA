using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_HasPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<char>> dic = new Dictionary<char, List<char>>();
            dic['f'] = new List<char>() {'g', 'i'} ;
            dic['g'] = new List<char>() {'h'};
            dic['h'] = new List<char>() { };
            dic['i'] = new List<char>() {'g', 'k'};
            dic['j'] = new List<char>() {'i'};
            dic['k'] = new List<char>() { };

            Console.WriteLine(hasPath(dic, 'f', 'k'));
            Console.ReadLine();
        }

        static bool hasPath(Dictionary<char, List<char>> dic, char source, char destination) 
        {
            if(source == destination) return true;

            Stack<char> stack = new Stack<char>();
            stack.Push(source);
            while(stack.Count() > 0)
            {
                var current = stack.Pop();
                if (current == destination)
                {
                    return true;
                }
                else
                {
                    foreach(var neightbour in dic[current]) 
                    {
                        stack.Push(neightbour);
                    }
                }
            }
            return false;

        }
    }
}
