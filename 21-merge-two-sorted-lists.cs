
namespace leetcode.csharp
{
    public class Solution21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(-1);

            ListNode h = dummy;
            ListNode h1 = list1;
            ListNode h2 = list2;

            while (h1 != null && h2 != null)
            {
                if (h1.val < h2.val)
                {
                    h.next = h1;
                    h1 = h1.next;
                }
                else
                {
                    h.next = h2;
                    h2 = h2.next;
                }
                h = h.next;

            }
            if (h1 != null)
            {
                h.next = h1;
            }
            if (h2 != null)
            {
                h.next = h2;
            }
            return dummy.next;
        }

        // public static void Main(string[] args)
        // {
        //     ListNode list1 = new ListNode(1);
        //     list1.next = new ListNode(2);
        //     list1.next.next = new ListNode(3);

        //     ListNode list2 = new ListNode(3);
        //     list2.next = new ListNode(4);
        //     list2.next.next = new ListNode(5);

        //     Solution21 s = new Solution21();
        //     ListNode result = s.MergeTwoLists(list1, list2);

        //     while (result != null)
        //     {
        //         System.Console.WriteLine(result.val);
        //         result = result.next;
        //     }
        // }
    }
}