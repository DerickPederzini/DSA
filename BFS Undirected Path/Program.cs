using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS_Undirected_Path
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Dictionary<char, List<char>> dic = new Dictionary<char, List<char>>();
            dic['i'] = new List<char>() { 'j', 'k' };
            dic['j'] = new List<char>() { 'i' };
            dic['k'] = new List<char>() { 'i', 'm', 'l' };
            dic['m'] = new List<char>() { 'k' };
            dic['l'] = new List<char>() { 'k' };
            dic['o'] = new List<char>() { 'n' };
            dic['n'] = new List<char>() { 'o' };

            Console.WriteLine(hasPath(dic, 'i', 'm', new HashSet<char>()));

            Console.ReadLine();
        }

        static bool hasPath(Dictionary<char, List<char>> dic, char source, char destination, HashSet<char> visited)
        {
            if (source == destination) return true;
            if (visited.Contains(source)) return false;

            visited.Add(source);

            foreach (var neighbour in dic[source])
            {
                if (hasPath(dic, neighbour, destination, visited) == true) return true;
            }

            return false;
        }
    }
}
