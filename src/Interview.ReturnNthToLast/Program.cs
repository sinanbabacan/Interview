using System;

namespace Interview.ReturnNthToLast
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
            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);
            head.Next.Next.Next.Next = new Node(5);
            head.Next.Next.Next.Next.Next = new Node(6);
            head.Next.Next.Next.Next.Next.Next = new Node(7);
            head.Next.Next.Next.Next.Next.Next.Next = new Node(8);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new Node(9);

            Node node = ReturnNode(head, 2);

            Console.WriteLine(node.Value);
            
        }


        private static Node ReturnNode(Node head, int k)
        {
            Node p1 = head;
            Node p2 = head;

            for (int i = 0; i < k; i++)
            {
                p1 = p1.Next;
            }

            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p2;
        }
    }
}
