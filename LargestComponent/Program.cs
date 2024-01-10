using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestComponent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>
            {
                { 0, new List<int> { 8, 1, 5 } },
                { 1, new List<int> { 0 } },
                { 5, new List<int> { 0, 8 } },
                { 8, new List<int> { 0, 5 } },
                { 2, new List<int> { 3, 4 } },
                { 3, new List<int> { 2, 4 } },
                { 4, new List<int> { 3, 2 } }
            };

            Console.WriteLine(LargestComponent(graph));

            Console.Read();
        }
        static int LargestComponent(Dictionary<int, List<int>> graph)
        {
            HashSet<int> visited = new HashSet<int>();
            int longest = 0;

            foreach (var node in graph.Keys)
            {
                int size = Explore(graph, node, visited);

                if (size > longest) longest = size;
            }

            return longest;
        }

        static int Explore(Dictionary<int, List<int>> graph, int current, HashSet<int> visited)
        {
            if (visited.Contains(current)) return 0;

            visited.Add(current);

            var size = 1;

            foreach (var neighbour in graph[current])
            {
                size += Explore(graph, neighbour, visited);
            }

            return size;
        }
    }
}
