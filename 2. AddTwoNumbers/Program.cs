using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AddTwoNumbers
{
    public class ListNode
    {
      public int val;
      public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode();
            l1.next = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next = new ListNode(3);

            ListNode l2 = new ListNode();
            l2.next = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next = new ListNode(7);

            AddTwoNumbers(l1, l2);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;
            int carry = 0;

            if (l1 == null && l2 == null) return dummy;

            while(l1 != null || l2 != null || carry == 1) 
            {
                int sum = 0;

                if(l1!= null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if(l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                sum += carry;
                carry = sum/10;
                ListNode node = new ListNode(sum%10);
                tail.next = node;
                tail = tail.next;
            }

            return dummy.next;
        }
    }

}
