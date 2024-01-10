using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] edges = new char[][]
            {
            new char[] { 'w', 'x' },
            new char[] { 'x', 'y' },
            new char[] { 'z', 'y' },
            new char[] { 'z', 'v'},
            new char[] { 'w', 'v' }
            };

            Dictionary<char, List<char>> graph = BuildGraph(edges);

            Console.WriteLine(ShortestPath(graph, 'w', 'z'));

            Console.Read();
            
        }

        static int ShortestPath(Dictionary<char, List<char>> graph, char nodeA, char nodeB)
        {
            Queue<Tuple<char, int>> queue = new Queue<Tuple<char, int>>();

            HashSet<char> visited = new HashSet<char>
            {
                nodeA
            }; 

            queue.Enqueue(new Tuple<char, int>(nodeA, 0));


            while(queue.Count > 0)
            {
                Tuple<char, int> removed = queue.Dequeue();

                if (removed.Item1 == nodeB)
                {
                    return removed.Item2;
                }

                foreach(var neighbour in graph[removed.Item1])
                {
                    if (!visited.Contains(neighbour))
                    {
                       visited.Add(neighbour);
                       queue.Enqueue(new Tuple<char, int>(neighbour, removed.Item2 + 1));
                    }
                }
            }

            return -1;
        }


        static Dictionary<char, List<char>> BuildGraph(char[][] edges)
        {
            Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();

            foreach (var edge in edges)
            {
                char a = edge[0];
                char b = edge[1];

                if (!graph.ContainsKey(a)) graph[a] = new List<char>();
                if (!graph.ContainsKey(b)) graph[b] = new List<char>();

                graph[a].Add(b);
                graph[b].Add(a);
            }

            return graph;
        }


    }
}
