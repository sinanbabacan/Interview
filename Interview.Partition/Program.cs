using System;

namespace Interview.Partition
{
    public class Node
    {
        public Node Next { get; set; }

        public int Value { get; }

        public Node(int value)
        {
            Value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(6);
            head.Next = new Node(5);
            head.Next.Next = new Node(4);
            head.Next.Next.Next = new Node(3);
            head.Next.Next.Next.Next = new Node(2);
            head.Next.Next.Next.Next.Next = new Node(1);
            head.Next.Next.Next.Next.Next.Next = new Node(0);

            Node result = Part(head, 3);

        }


        private static Node Part(Node node, int x)
        {
            Node head = node;
            Node tail = node;

            while (node != null)
            {
                Node next = node.Next;

                if (node.Value < x)
                {
                    node.Next = head;
                    head = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;
                }

                node = next;
            }

            tail.Next = null;

            return head;
        }
    }
}

