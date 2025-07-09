using System.Globalization;

namespace _2._Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddTwoNumbers(your_input);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            bool carry = false;

            while (l1 != null || l2 != null)
            {
                ListNode n = new ListNode();

                // Carry check
                if (carry)
                {
                    n.val++;
                    carry = false;
                }

                // Cases
                if (l1 != null && l2 == null)
                {
                    n.val += l1.val;
                    l1 = l1.next;
                }
                else if (l1 == null && l2 != null)
                {
                    n.val += l2.val;
                    l2 = l2.next;
                }
                else if (l1 != null && l2 != null)
                {
                    int sum = l1.val + l2.val;
                    if (sum >= 10) // Store the carry
                    {
                        carry = true;
                        sum -= 10;
                    }
                    n.val += sum;
                    l1 = l1.next;
                    l2 = l2.next;
                }

                // Handle carry overflow
                if (n.val >= 10)
                {
                    carry = true;
                    n.val -= 10;
                }

                current.next = n;
                current = n;

            }

            // Handle final carry
            if (carry)
            {
                current.next = new ListNode(1);
            }

            return dummy.next;
        }
    }
}
