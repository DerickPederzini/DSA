using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class LL
    {

        private Node head;
        private Node tail;
        private int size;

        public LL()
        {
            this.size = 0;
        }

        public void insertFirst(int val)
        {
            Node node = new Node(val);
            node.next = head;
            head = node;

            if (tail == null)
            {
                tail = head;
            }
            size += 1;
        }

        public void insertLast(int val)
        {
            if (tail == null)
            {
                insertFirst(val);
                return;
            }
            Node node = new Node(val);
            tail.next = node;
            tail = node;
            size++;
        }

        public void insert(int val, int index)
        {
            if (index == 0)
            {
                insertFirst(val);
                return;
            }
            if (index == size)
            {
                insertLast(val);
                return;
            }

            Node temp = head;
            for (int i = 1; i < index; i++)
            {
                temp = temp.next;
            }

            Node node = new Node(val, temp.next);
            temp.next = node;

            size++;
        }

        // insert using recursion
        public void insertRec(int val, int index)
        {
            head = insertRecursion(val, index, head);
        }

        private Node insertRecursion(int val, int index, Node node)
        {
            if (index == 0)
            {
                Node temp = new Node(val, node);
                size++;
                return temp;
            }

            node.next = insertRecursion(val, index - 1, node.next);
            return node;
        }


        public int deleteLast()
        {
            if (size <= 1)
            {
                return deleteFirst();
            }

            Node secondLast = get(size - 2);
            int val = tail.value;
            tail = secondLast;
            tail.next = null;
            size--;
            return val;
        }

        public int delete(int index)
        {
            if (index == 0)
            {
                return deleteFirst();
            }
            if (index == size - 1)
            {
                return deleteLast();
            }

            Node prev = get(index - 1);
            int val = prev.next.value;

            prev.next = prev.next.next;
            size--;
            return val;
        }
        public int deleteFirst()
        {
            int val = head.value;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            size--;
            return val;
        }

        public Node find(int value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == value)
                {
                    return node;
                }
                node = node.next;
            }
            return null;
        }

        public Node get(int index)
        {
            Node node = head;
            for (int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }


        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("END");
        }

        // https://leetcode.com/problems/remove-duplicates-from-sorted-list
        public void duplicates()
        {
            Node node = head;

            while (node.next != null)
            {
                if (node.value == node.next.value)
                {
                    //If there is a duplicate, just skip it,
                    node.next = node.next.next;
                    size--;
                }
                else
                {
                    //if there is not, continue iterating
                    node = node.next;
                }
            }
            tail = node;
            tail.next = null;
        }

        // https://leetcode.com/problems/merge-two-sorted-lists/submissions/
        public static LL merge(LL first, LL second)
        {
            Node f = first.head;
            Node s = second.head;

            LL ans = new LL();

            while (f != null && s != null)
            {
                //compare the values and iterate
                if (f.value < s.value)
                {
                    ans.insertLast(f.value);
                    f = f.next;
                }
                else
                {
                    ans.insertLast(s.value);
                    s = s.next;
                }
            }

            //insert values left over
            while (f != null)
            {
                ans.insertLast(f.value);
                f = f.next;
            }

            while (s != null)
            {
                ans.insertLast(s.value);
                s = s.next;
            }

            return ans;
        }

        // recursion reverse
        private void reverse(Node node)
        {
            if (node == tail)
            {
                head = tail;
                return;
            }
            reverse(node.next);
            tail.next = node;
            tail = node;
            tail.next = null;
        }

        // in place reversal of linked list
        // google, microsoft, apple, amazon: https://leetcode.com/problems/reverse-linked-list/
        public void reverse()
        {
            if (size < 2)
            {
                return;
            }

            Node prev = null;
            Node current = head;
            Node next = current.next;

            while(current != null)
            {
                current.next = prev;
                prev = current;
                current = next;
                if (next != null)
                {
                    next = next.next;
                }
            }
            head = prev;

        }

        //https://leetcode.com/problems/middle-of-the-linked-list/
        public Node MiddleNode(Node head)
        {
            Node fast = head;
            Node slow = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        public class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
            }

            public Node(int value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }
    }
}
