using System;

// Delete last K nodes from linked list (two-pointer approach)
// Author: Raparla Karthikeya

public class ListNode
{
    public string data;
    public ListNode next;

    public ListNode(string data)
    {
        this.data = data;
        this.next = null;
    }
}

public class DeleteLastKDemo
{
    public static ListNode DeleteLastK(ListNode head, int k)
    {
        if (head == null || k <= 0)
            return head;

        ListNode slow = head;
        ListNode fast = head;
        for (int i = 0; i < k; i++)
        {
            if (fast == null)
                return null;
            fast = fast.next;
        }

        if (fast == null)
            return null;
        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        slow.next = null;

        return head;
    }

    public static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.data);
            if (current.next != null)
                Console.Write(" → ");
            current = current.next;
        }
    }
}
