using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    internal class DLL
    {
        private Node head;

        //if you are inserting at first, then the head needs to point to null, aswell as the second node
        public void insertFirst(int val)
        {
            Node node = new Node(val);
            node.next = head;
            node.prev = null;
            if (head != null)
            {
                head.prev = node;
            }
            head = node;
        }

        public void display()
        {
            Node node = head;
            Node last = null;
            while (node != null)
            {
                Console.WriteLine(node.val + " -> ");
                last = node;
                node = node.next;
            }
            Console.WriteLine("END");

           // Console.WriteLine("Print in reverse");
           // while (last != null)
           // {
           //     Console.WriteLine(last.val + " -> ");
           //     last = last.prev;
           // }
           //Console.WriteLine("START");
        }

        //if you are inserting at last, the next element needs to point to null and to the one before it
        public void insertLast(int val)
        {
            Node node = new Node(val);
            Node last = head;

            node.next = null;

            if (head == null)
            {
                node.prev = null;
                head = node;
                return;
            }

            while (last.next != null)
            {
                last = last.next;
            }

            last.next = node;
            node.prev = last;
        }

        private Node find(int value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.val == value)
                {
                    return node;
                }
                node = node.next;
            }
            return null;
        }

        //if you want to insert at a expecific index, pass the number of where you want to insert
        //then be careful not to break the chain between nodes
        //- First you need to create a link between the node you want to insert and the value that comes after it
        //- Also dont forget to make a connection backwards to the node that comes after the insert value, only if not inserting at last index

        public void insert(int after, int val)
        {
            Node p = find(after);

            if (p == null)
            {
                Console.WriteLine("does not exist");
                return;
            }

            Node node = new Node(val);
            node.next = p.next;
            p.next = node;
            node.prev = p;
            if (node.next != null)
            {
                node.next.prev = node;
            }
        }

        private class Node
        {
            public int val;
            public Node next;
            public Node prev;

            public Node(int val)
            {
                this.val = val;
            }

            public Node(int val, Node next, Node prev)
            {
                this.val = val;
                this.next = next;
                this.prev = prev;
            }
        }
    }
}
