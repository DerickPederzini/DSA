using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232.Implements_Queue_using_Stack
{
    internal class MyQueue
    {
        private Stack<int> s1;
        private Stack<int> s2;
        static void Main(string[] args)
        {
            MyQueue obj = new MyQueue();
            obj.Push(12);
            obj.Push(15);
            obj.Pop();
            obj.Peek();
            obj.Empty();
        }
        public MyQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        public void Push(int x)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(x);
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }

        }

        public int Pop()
        {
            return s1.Pop();
        }

        public int Peek()
        {
            return s1.Peek();
        }

        public bool Empty()
        {
            return s1.Count == 0;
        }
    }

}




