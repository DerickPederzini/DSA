using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_Questions
{
    public class BinaryTree
    {
        public BinaryTree()
        {

        }

        private class Node
        {
            public int value;
            public Node left = null;
            public Node right = null;

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
        public void Traversal(BinaryTree tree)
        {
            Node root = tree.root;
            Traversal(root);
        }

        private void Traversal(Node root)
        {

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                Console.WriteLine(node.value);

                if (node.right != null) stack.Push(node.right);

                if (node.left != null) stack.Push(node.left);

            }
        }

        public int[] TraversalValues(BinaryTree tree)
        {
            Node root = tree.root;
            return TraversalValues(root);
        }

        private int[] TraversalValues(Node root)
        {
            if (root == null)
            {
                return new int[] { };
            }
            int[] left = TraversalValues(root.left);
            int[] right = TraversalValues(root.right);

            int[] result = new int[left.Length + right.Length + 1];
            result[0] = root.value;
            left.CopyTo(result, 1);
            right.CopyTo(result, left.Length + 1);

            return result;
        }



        //https://leetcode.com/problems/balanced-binary-tree/
        public bool isBalanced(BinaryTree tree)
        {
            Node root = tree.root;
            return isBalanced(root);
        }
        private bool isBalanced(Node root)
        {
            if (root == null) return true;

            if (height(root) == -1) return false;
            return true;
        }
        private int height(Node root)
        {
            if (root == null) return 0;

            int left = height(root.left);
            int right = height(root.right);

            if (left == -1 || right == -1) return -1;
            if (Math.Abs(left - right) > 1) return -1;
            return Math.Max(left, right) + 1;
        }

        //https://leetcode.com/problems/invert-binary-tree/

        private Node InvertTree(BinaryTree tree)
        {
            Node root = tree.root;
            return InvertTree(root);
        }
        private Node InvertTree(Node root)
        {
            if(root == null) return null;

            Node temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }

        //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/description/
        private Node LowestCommonAncestor(BinaryTree tree, Node q, Node p)
        {
            Node root = tree.root;
            return LowestCommonAncestor(root, q, p);
        }
        private Node LowestCommonAncestor(Node root, Node q, Node p)
        {
            Node current = root;  

            while(current != null)
            {
                if (root.value < q.value && root.value < p.value)
                    current = current.right;
                else if (root.value > q.value && root.value > p.value)
                    current = current.left;
                else
                    return current;
                
            }

            return null;

        }

        //https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
        public int MaxDepth(BinaryTree tree)
        {
            Node root = tree.root;
            return MaxDepth(root);

        }

        private int MaxDepth(Node root)
        {
            int c = calculate(root, 0);

            return c;

        }

        private int calculate(Node root, int c)
        {
            if (root == null)
            {
                return 0;
            }

            int left = calculate(root.left, c++);
            int right = calculate(root.right, c++);

            return Math.Max(left, right) + 1;
            
        }
    }
}