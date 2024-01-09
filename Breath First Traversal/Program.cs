using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breath_First_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<char>> dic = new Dictionary<char, List<char>>();
            dic['a'] = new List<char>() { 'c', 'b' };
            dic['b'] = new List<char>() { 'd' };
            dic['c'] = new List<char>() { 'e' };
            dic['d'] = new List<char>() { 'f' };
            dic['e'] = new List<char>() { };
            dic['f'] = new List<char>() { };

            breathFirstTraversal(dic, 'a');

            Console.ReadLine();
        }
        static void breathFirstTraversal(Dictionary<char, List<char>> dic, char source)
        {
            Queue<char> queue = new Queue<char>();
            queue.Enqueue(source);

            while(queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine(current);

                foreach(var neightbour in dic[current])
                {
                    queue.Enqueue(neightbour);
                }
            }

        }
    }
}
