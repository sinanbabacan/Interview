using System;
using System.Collections;
using System.Collections.Generic;

namespace Interview.QueueViaStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();


            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());

            myQueue.Enqueue(5);
            myQueue.Enqueue(6);

        }
    }

    public class MyQueue
    {
        Stack<int> s1, s2;

        public MyQueue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }

        public int Dequeue()
        {
            if (s2.Count == 0)
            {
                int count = s1.Count;
                
                for (int i = 0; i < count; i++)
                {
                    s2.Push(s1.Pop());
                }
            }

            return s2.Pop();
        }

        public void Enqueue(int item)
        {
            if (s1.Count == 0)
            {
                int count = s2.Count;
                
                for (int i = 0; i < count; i++)
                {
                    s1.Push(s2.Pop());
                }
            }

            s1.Push(item);
        }
    }
}
