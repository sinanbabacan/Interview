using System;
using System.Collections.Generic;

namespace Interview.RemoveDuplicates
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
            Node head = new Node(5);
            head.Next = new Node(4);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(3);
            head.Next.Next.Next.Next = new Node(2);
            head.Next.Next.Next.Next.Next = new Node(1);
            head.Next.Next.Next.Next.Next.Next = new Node(3);
            head.Next.Next.Next.Next.Next.Next.Next = new Node(1);
            head.Next.Next.Next.Next.Next.Next.Next.Next = new Node(1);
            head.Next.Next.Next.Next.Next.Next.Next.Next.Next = new Node(3);

            // RemoveDups(head);
            RemoveDups2(head);
        }


        private static void RemoveDups(Node node)
        {
            HashSet<int> set = new HashSet<int>();

            Node previous = null;

            while (node != null)
            {
                if (set.Contains(node.Value))
                {
                    previous.Next = node.Next;
                }
                else
                {
                    set.Add(node.Value);
                    previous = node;
                }

                node = node.Next;
            }
        }

        // fast runner algorithm
        private static void RemoveDups2(Node node)
        {
            Node current = node;

            while (current != null)
            {
                Node runner = current;

                while (runner.Next != null)
                {
                    if (current.Value == runner.Next.Value)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                current = current.Next;
            }
        }
    }
}
