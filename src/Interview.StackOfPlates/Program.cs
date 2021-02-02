using System;
using System.Collections;
using System.Collections.Generic;

namespace Interview.StackOfPlates
{
    class Program
    {
        static void Main(string[] args)
        {
            StackPlates stackPlates = new StackPlates(3);

            stackPlates.Push(1);
            stackPlates.Push(2);
            stackPlates.Push(3);
            stackPlates.Push(4);
            stackPlates.Push(5);
            stackPlates.Push(6);
            stackPlates.Push(7);
            stackPlates.Push(8);
            stackPlates.Push(9);
            stackPlates.Push(10);

            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();

            stackPlates.Push(11);
            stackPlates.Push(12);
            stackPlates.Push(13);

        }


    }


    public class StackPlates
    {

        Stack<Stack<int>> stacks;

        public StackPlates(int max)
        {
            stacks = new Stack<Stack<int>>();
            Max = max;
        }

        public int Max { get; }

        public void Push(int item)
        {
            Stack<int> stack;

            if (stacks.Count == 0)
            {
                stacks.Push(new Stack<int>());
            }

            stack = stacks.Peek();

            if (stack.Count < Max)
            {
                stack.Push(item);
            }
            else
            {
                Stack<int> newStack = new Stack<int>();

                newStack.Push(item);

                stacks.Push(newStack);
            }
        }

        public int Pop()
        {
            Stack<int> stack = stacks.Peek();

            int item = stack.Pop();

            if (stack.Count == 0)
            {
                stacks.Pop();
            }

            return item;
        }
    }
}
