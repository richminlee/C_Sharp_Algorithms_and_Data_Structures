
using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace SinglyLinkedList
{
    class Node
    {
        public int Val;
        public Node Next;
        public Node(int val)
        {
            this.Val = val;
            this.Next = null;
        }
    }
    class SinglyLinkedList
    {
        public Node Head;
        public Node Tail;
        public int Length;
        public SinglyLinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Length = 0;
        }
        public void Push(int val)
        {
            Node newNode = new Node(val);
            if(this.Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;
                this.Length = 1;
            }
            else
            {
                Node runner = this.Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
                this.Tail = newNode;
                this.Length++;
            }
        }
        public void Display()
        {
            Node runner = this.Head;
            while (runner.Next != null)
            {
                Console.WriteLine(runner.Val);
                runner = runner.Next;
            }
            Console.WriteLine(runner.Val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Push(10);
            list.Push(11);
            list.Push(12);
            list.Push(13);
            list.Push(14);
            list.Display();
        }
    }
}