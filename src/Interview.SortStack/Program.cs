using System;
using System.Collections.Generic;

namespace Interview.SortStack
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedStack sortedStack = new SortedStack();

            sortedStack.Push(4);
            sortedStack.Push(5);
            sortedStack.Push(2);
            sortedStack.Push(6);
            sortedStack.Push(7);

            

        }
    }

    public class SortedStack
    {
        Stack<int> _stack;
        Stack<int> _temp;
        public SortedStack()
        {
            _stack = new Stack<int>();
            _temp = new Stack<int>();
        }

        public void Push(int val)
        {
            while (_stack.Count > 0 && val > _stack.Peek())
            {
                _temp.Push(_stack.Pop());
            }

            _stack.Push(val);

            while (_temp.Count > 0)
            {
                _stack.Push(_temp.Pop());
            }
        }

        public int Pop()
        {
            return _stack.Pop();
        }

        public int Peek()
        {

            return _stack.Peek();
        }

       
    }

}
