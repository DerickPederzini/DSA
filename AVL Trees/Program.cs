using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVL tree = new AVL();

            for (int i = 0; i < 1000; i++)
            {
                tree.insert(i);
            }

            Console.WriteLine(tree.height());
        }
    }
}
