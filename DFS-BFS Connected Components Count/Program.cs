using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_BFS_Connected_Components_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            dic[0] = new List<int>() { 8, 1, 5 };
            dic[1] = new List<int>() { 0 };
            dic[5] = new List<int>() { 0, 8 };
            dic[8] = new List<int>() { 0, 5 };
            dic[2] = new List<int>() { 3, 4 };
          


            Console.WriteLine(graphCount(dic, 0));
            Console.Read();
        }

        static int graphCount(Dictionary<int, List<int>> graph, int source)
        {

            var count = 0;
            Dictionary<int, bool> visited = new Dictionary<int, bool>();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);

            while(queue.Count != 0)
            {
                var current = queue.Dequeue();

                

                foreach (var neightbour in graph[current])
                {
                    if (!visited.ContainsKey(neightbour))
                    {
                        visited.Add(neightbour, false);
                        queue.Enqueue(neightbour);
                    }
                    if (!visited.ContainsKey(current))
                    {
                        count++;
                    }
                }

            }
            return count;
        }
        
    }
}
