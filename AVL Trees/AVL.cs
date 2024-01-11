using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Trees
{
    internal class AVL
    {
        //An AVL Tree is a self balancing tree, it rotates whenever it sees the node being inserted will make it unbalanced
        private class Node
        {
            public int value;
            public Node left;
            public Node right;
            public int height;

            public Node(int value)
            {
                this.value = value;
            }

            public int getValue()
            {
                return value;
            }
        }

        private Node root;

        public AVL()
        {

        }

        public int height()
        {
            return height(root);
        }
        private int height(Node node)
        {
            if (node == null)
            {
                return -1;
            }
            return node.height;
        }

        public void insert(int value)
        {
            root = insert(value, root);
        }

        //it is a binary search tree, so elements to the left are smaller and right greater
        private Node insert(int value, Node node)
        {
            if (node == null)
            {
                node = new Node(value);
                return node;
            }

            if (value < node.value)
            {
                node.left = insert(value, node.left);
            }

            if (value > node.value)
            {
                node.right = insert(value, node.right);
            }

            //always call rotate function, the point is to check at every node if the tree will be unbalanced
            node.height = Math.Max(height(node.left), height(node.right)) + 1;
            return rotate(node);
        }

        private Node rotate(Node node)
        {

            //tree is unbalanced check
            if (height(node.left) - height(node.right) > 1)
            {
                //Tree is unbalanced - To the left of node

                //find the configuration of the rotation
                if (height(node.left.left) - height(node.left.right) < 0)
                {
                    // left right case
                    node.left = leftRotate(node.left);
                    return rightRotate(node);
                }
                // left heavy
                if (height(node.left.left) - height(node.left.right) > 0)
                {
                    // left left case
                    return rightRotate(node);
                }
            }

            //tree is unbalanced check
            if (height(node.left) - height(node.right) < - 1)
            {
                //Tree is unbalanced - To the right of node

                //find the configuration of the rotation
                // right heavy
                if (height(node.right.left) - height(node.right.right) < 0)
                {
                    // right right case
                    return leftRotate(node);
                }
                if (height(node.right.left) - height(node.right.right) > 0)
                {
                    // left right case
                    node.right = rightRotate(node.right);
                    return leftRotate(node);
                }
            }

            return node;
        }

        //rotates and correct the height
        private Node rightRotate(Node p)
        {
            Node c = p.left;
            Node t = c.right;

            c.right = p;
            p.left = t;

            p.height = Math.Max(height(p.left), height(p.right)) + 1;
            c.height = Math.Max(height(c.left), height(c.right)) + 1;

            return c;
        }

        //rotates and correct the height
        private Node leftRotate(Node c)
        {
            Node p = c.right;
            Node t = p.left;

            p.left = c;
            c.right = t;

            c.height = Math.Max(height(c.left), height(c.right)) + 1;
            p.height = Math.Max(height(p.left), height(p.right)) + 1;

            return p;
        }

        public void populate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                this.insert(nums[i]);
            }
        }

        public void populatedSorted(int[] nums)
        {
            populatedSorted(nums, 0, nums.Length);
        }

        private void populatedSorted(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int mid = (start + end) / 2;

            this.insert(nums[mid]);
            populatedSorted(nums, start, mid);
            populatedSorted(nums, mid + 1, end);
        }

        public void display()
        {
            display(this.root, "Root Node: ");
        }

        private void display(Node node, String details)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(details + node.value);
            display(node.left, "Left child of " + node.value + " : ");
            display(node.right, "Right child of " + node.value + " : ");
        }

        public bool isEmpty()
        {
            return root == null;
        }

        public bool balanced()
        {
            return balanced(root);
        }

        private bool balanced(Node node)
        {
            if (node == null)
            {
                return true;
            }
            return Math.Abs(height(node.left) - height(node.right)) <= 1 && balanced(node.left) && balanced(node.right);
        }
    }
}
