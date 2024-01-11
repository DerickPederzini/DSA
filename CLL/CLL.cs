using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLL
{
    internal class CLL
    {

            private Node head;
            private Node tail;

            public CLL()
            {
                this.head = null;
                this.tail = null;
            }

            public void insert(int val)
            {
                Node node = new Node(val);
                if (head == null)
                {
                    head = node;
                    tail = node;
                    return;
                }

                tail.next = node;
                node.next = head;
                tail = node;
            }

            public void display()
            {
                Node node = head;
                if (head != null)
                {
                    do
                    {
                        Console.WriteLine(node.val + " -> ");
                        if (node.next != null)
                        {
                            node = node.next;
                        }
                    } while (node != head);
                }
               Console.WriteLine("HEAD");
            }

            public void delete(int val)
            {
                Node node = head;
                if (node == null)
                {
                    return;
                }

                if (head == tail)
                {
                    head = null;
                    tail = null;
                    return;
                }

                if (node.val == val)
                {
                    head = head.next;
                    tail.next = head;
                    return;
                }

                do
                {
                    Node n = node.next;
                    if (n.val == val)
                    {
                        node.next = n.next;
                        break;
                    }
                    node = node.next;
                } while (node != head);

            }

            private class Node
            {
                public int val;
                public Node next;

                public Node(int val)
                {
                    this.val = val;
                }
            }
        }
}
