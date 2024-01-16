using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree_Questions;

namespace BinaryTree_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            bt.populate();
            bt.isBalanced(bt);

            bt.MaxDepth(bt);

            int[] arr = bt.TraversalValues(bt);


            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
