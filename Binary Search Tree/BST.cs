using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    internal class BST
    {
        public class Node
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

        public BST()
        {

        }

        //height is distance to any given node down to its furtherst leaf
        public int height(Node node)
        {
            if (node == null)
            {
                return -1;
            }
            return node.height;
        }

        public bool isEmpty()
        {
            return root == null;
        }

        public void insert(int value)
        {
            root = insert(value, root);
        }

        //On binary search trees, elements smaller than the value stay at the left of it and elements greater, to the right
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

            //increments the height every time an node is added
            node.height = Math.Max(height(node.left), height(node.right)) + 1;
            return node;
        }

        public void populate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                insert(nums[i]);
            }
        }

        public void populatedSorted(int[] nums)
        {
            populatedSorted(nums, 0, nums.Length);
        }

        //make a sorted array into a tree
        private void populatedSorted(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int mid = (start + end) / 2;

            insert(nums[mid]);
            populatedSorted(nums, start, mid);
            populatedSorted(nums, mid + 1, end);
        }

        public bool balanced()
        {
            return balanced(root);
        }

        //tree is balanced if the difference between the distance of given nodes at the
        //same level down to their leafs is not greater than 1
        private bool balanced(Node node)
        {
            if (node == null)
            {
                return true;
            }
            return Math.Abs(height(node.left) - height(node.right)) <= 1 && balanced(node.left) && balanced(node.right);
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
    }
}
