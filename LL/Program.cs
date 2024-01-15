using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LL first = new LL();
            LL second = new LL();

            first.insertLast(1);
            first.insertLast(3);
            first.insertLast(5);

            second.insertLast(1);
            second.insertLast(2);
            second.insertLast(3);
            second.insertLast(4);
            second.insertLast(5);
            second.insertLast(6);

            second.MiddleNode(second.get(0));

            LL ans = LL.merge(first, second);
            ans.display();

            LL list = new LL();
            for (int i = 7; i > 0; i--)
            {
                list.insertLast(i);
            }
            list.display();

            list.reverse();
            list.display();

            Console.Read();
        }
    }
}
