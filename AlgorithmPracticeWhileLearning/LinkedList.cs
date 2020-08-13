using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPracticeWhileLearning
{
    public class Node
    {
        public Node next;
        public int data;
        public Node(int data)
        {
            this.data = data;
        }

    }
    public class LinkedList
    {
        public Node head;
        public void append(int data)
        {
            if(head == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(data);
        }
        public void prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }
        public void deleteWithValue(int data)
        {
            if (head == null) return;

        }
    }
}
