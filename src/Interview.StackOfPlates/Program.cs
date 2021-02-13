using System;
using System.Collections;
using System.Collections.Generic;

namespace Interview.StackOfPlates
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
["DinnerPlates","push","push","push","push","push","push","push","push",
            "popAtStack","popAtStack","popAtStack","popAtStack","popAtStack","popAtStack","popAtStack","popAtStack","popAtStack","popAtStack",
            "push","push","push","push","push","push","push","push",
            "pop","pop","pop","pop","pop","pop","pop","pop","pop","pop"]
[[472],[106],[497],[498],[73],[115],[437],[461],
            [3],[3],[1],[3],[0],[2],[2],[1],[1],[3],
            [197],[239],[129],[449],[460],[240],[386],[343]
            ,[],[],[],[],[],[],[],[],[],[]]
             */

            DinnerPlates stackPlates = new DinnerPlates(2);

            stackPlates.Push(1);
            stackPlates.Push(2);
            stackPlates.Push(3);
            stackPlates.Push(7);
            stackPlates.Push(4);
            stackPlates.Push(7);
            stackPlates.Push(7);
            stackPlates.Push(7);

            stackPlates.PopAtStack(3);
            stackPlates.PopAtStack(3);
            stackPlates.PopAtStack(1);
            stackPlates.PopAtStack(3);
            stackPlates.PopAtStack(0);
            stackPlates.PopAtStack(2);
            stackPlates.PopAtStack(2);
            stackPlates.PopAtStack(1);
            stackPlates.PopAtStack(1);
            stackPlates.PopAtStack(3);

            stackPlates.Push(1);
            stackPlates.Push(2);
            stackPlates.Push(3);
            stackPlates.Push(7);
            stackPlates.Push(4);
            stackPlates.Push(7);
            stackPlates.Push(7);
            stackPlates.Push(7);



            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();
            stackPlates.Pop();

           

        }


    }

    public class DinnerPlates
    {
        private Stack<int> _mins;
        private Stack<int> _minTemps;
        private List<Stack<int>> _stacks;
        private Dictionary<int, Stack<int>> _freeStacks;
        private int _capacity { get; }

        public DinnerPlates(int capacity)
        {
            _mins = new Stack<int>();

            _minTemps = new Stack<int>();

            _stacks = new List<Stack<int>>();

            _freeStacks = new Dictionary<int, Stack<int>>();

            _capacity = capacity;
        }

        public void Push(int val)
        {
            Stack<int> stack = null;

            int min = GetMin();

            if (min < 0)
            {
                stack = new Stack<int>();

                min = _stacks.Count;

                _freeStacks[min] = stack;

                AddValue(min);

                _stacks.Add(stack);
            }

            stack = _freeStacks[min];

            stack.Push(val);

            if (stack.Count == _capacity)
            {
                _freeStacks.Remove(min);

                RemoveValue(min);
            }
        }

        public int Pop()
        {
            return PopAtStack(_stacks.Count - 1);
        }

        public int PopAtStack(int index)
        {
            if (index < 0 || index > _stacks.Count - 1)
            {
                return -1;
            }

            Stack<int> stack = _stacks[index];

            if (stack == null || stack.Count == 0)
            {
                return -1;
            }

            if (stack.Count == _capacity)
            {
                _freeStacks[index] = stack;

                AddValue(index);
            }

            int v = stack.Pop();

            if (_stacks.Count - 1 == index)
            {
                while (index >= 0 && _stacks[index] != null && _stacks[index].Count == 0)
                {
                    _freeStacks.Remove(index);
                    _stacks.RemoveAt(index);
                    RemoveValue(index);
                    index--;
                }
            }

            return v;
        }

        private void AddValue(int val)
        {
            while (_mins.Count > 0 && val > _mins.Peek())
            {
                _minTemps.Push(_mins.Pop());
            }

            _mins.Push(val);

            while (_minTemps.Count > 0)
            {
                _mins.Push(_minTemps.Pop());
            }
        }

        private void RemoveValue(int val)
        {
            while (_mins.Count > 0)
            {
                int v = _mins.Pop();

                if (v == val)
                {
                    break;
                }

                _minTemps.Push(v);
            }

            while (_minTemps.Count > 0)
            {
                _mins.Push(_minTemps.Pop());
            }
        }

        private int GetMin()
        {
            int v = -1;

            if (_mins.Count > 0)
            {
                v = _mins.Peek();
            }

            return v;
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
