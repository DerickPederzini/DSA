using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connected_Components_Count
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

            Console.WriteLine(ConnectedComponentsCount(graph));

            Console.Read();
        }

        static int ConnectedComponentsCount(Dictionary<int, List<int>> graph)
        {
            HashSet<int> visited = new HashSet<int>();
            int count = 0;

            foreach (var node in graph.Keys)
            {
                if (!visited.Contains(node))
                {
                    Explore(graph, node, visited);
                    count++;
                }
            }

            return count;
        }

        static void Explore(Dictionary<int, List<int>> graph, int current, HashSet<int> visited)
        {
            if (visited.Contains(current)) return;

            visited.Add(current);

            foreach (var neighbour in graph[current])
            {
                Explore(graph, neighbour, visited);
            }
        }
    }
}
