using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public BinaryTree()
        {

        }

        private class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node root;

        // insert elements, start with root node and populate the other elemnts
        public void populate()
        {
            Console.WriteLine("Enter the root Node: ");
            int value = Convert.ToInt32(Console.ReadLine());
            root = new Node(value);
            populate(root);
        }

        //creates elements and their pointers
        private void populate(Node node)
        {
            Console.WriteLine("Do you want to enter left of " + node.value);
            bool left = Convert.ToBoolean(Console.ReadLine());
            if (left)
            {
                Console.WriteLine("Enter the value of the left of " + node.value);
                int value = Convert.ToInt32(Console.ReadLine());
                node.left = new Node(value);
                populate(node.left);
            }

            Console.WriteLine("Do you want to enter right of " + node.value);
            bool right = Convert.ToBoolean(Console.ReadLine());
            if (right)
            {
                Console.WriteLine("Enter the value of the right of " + node.value);
                int value = Convert.ToInt32(Console.ReadLine());
                node.right = new Node(value);
                populate(node.right);
            }

        }

        public void display()
        {
            display(this.root, "");
        }

        private void display(Node node, String indent)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(indent + node.value);
            display(node.left, indent + "\t");
            display(node.right, indent + "\t");
        }

        public void prettyDisplay()
        {
            prettyDisplay(root, 0);
        }

        private void prettyDisplay(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            prettyDisplay(node.right, level + 1);

            //level is not ascending, starts from root and goes to leaf
            if (level != 0)
            {
                for (int i = 0; i < level - 1; i++)
                {
                    Console.WriteLine("|\t\t");
                }
                Console.WriteLine("|------->" + node.value);
            }
            else
            {
                Console.WriteLine(node.value);
            }
            prettyDisplay(node.left, level + 1);
        }

        public void preOrder()
        {
            preOrder(root);
        }

        private void preOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.value + " ");
            preOrder(node.left);
            preOrder(node.right);
        }

        public void inOrder()
        {
            preOrder(root);
        }

        //different ways to represent it
        private void inOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            preOrder(node.left);
            Console.WriteLine(node.value + " ");
            preOrder(node.right);
        }

        public void postOrder()
        {
            preOrder(root);
        }

        private void postOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            preOrder(node.left);
            preOrder(node.right);
            Console.WriteLine(node.value + " ");
        }

    }
}
