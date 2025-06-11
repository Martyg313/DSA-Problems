namespace _24._Swap_Nodes_in_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SwapPairs(your_input);
        }

        static private ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            else
            {
                int count = 0;
                ListNode node1 = null!;
                ListNode node2 = null!;
                ListNode node3 = head;

                ListNode curr = head;
                while (curr != null)
                {
                    if (count % 2 == 0)
                    {
                        node1 = curr;    // Reference to odd nodes
                    }
                    else
                    {
                        node2 = curr;    // Reference to even nodes

                        // Swaps nodes
                        ListNode tempNode = node2.next;
                        node2.next = node1;
                        node1.next = tempNode;
                        curr = node1;

                        if (count >= 3)
                        {
                            node3.next = node2;
                            node3 = node1;
                        }
                    }


                    if (count == 1) // Sets head to appropriate position for return
                    {
                        head = node2;
                    }
                    curr = curr.next;
                    count++;
                }
                return head;
            }
        }
    }
}
