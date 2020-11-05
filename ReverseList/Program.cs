using System;

namespace ReverseList
{
    class Program
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }

        public static void DisplayList(ListNode head)
        {
            ListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.val);
                runner = runner.next;
            } 
        }
        //public static ListNode ReverseList(ListNode head)
        //{
        //    ListNode pivot = head;
        //    ListNode walker = null;
        //    while (pivot != null)
        //    {
        //        ListNode runner = pivot.next;
        //        pivot.next = walker;
        //        walker = pivot;
        //        pivot = runner;
        //    }
        //    return walker;
        //}

        public static ListNode ReverseList(ListNode head)
        {
            ListNode pivot = head;
            ListNode walker = null;
            while(pivot != null)
            {
                ListNode runner = pivot.next;
                pivot.next = walker;
                walker = pivot;
                pivot = runner;
            }
            return walker;

        }




        static void Main(string[] args)
        {
            ListNode five = new ListNode(5);
            ListNode four = new ListNode(4, five);
            ListNode three = new ListNode(3, four);
            ListNode two = new ListNode(2, three);
            ListNode one = new ListNode(1, two);
            DisplayList(ReverseList(one));
        }
    }
}
