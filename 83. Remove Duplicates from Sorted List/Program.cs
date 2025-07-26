namespace _83._Remove_Duplicates_from_Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DeleteDuplicates(your_input);
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;
            else
            {
                ListNode start = head;
                ListNode lastNode = head;
                head = head.next;

                while (head != null)
                {
                    if (head.val == lastNode.val)
                        lastNode.next = head.next;
                    else
                        lastNode = head;
                    head = head.next;
                }
                return start;
            }
        }
    }
}
