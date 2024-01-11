using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            int[] nums = { 5, 2, 7, 1, 4, 6, 9, 8, 3, 10 };
            tree.populate(nums);
            tree.display();
        }
    }
}
