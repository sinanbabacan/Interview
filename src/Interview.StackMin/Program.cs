﻿using System;
using System.Collections.Generic;

namespace Interview.StackMin
{

    public class MyStack : Stack<int>
    {
        Stack<int> mins;
        public MyStack()
        {
            mins = new Stack<int>();
        }


        public new void Push(int item)
        {
            if (item <= Min())
            {
                mins.Push(item);
            }

            base.Push(item);
        }

        public new int Pop()
        {
            int item = this.Peek();

            if (item == Min())
            {
                mins.Pop();
            }

            return base.Pop();
        }

        public int Min()
        {
            return mins.Count > 0 ? mins.Peek() : int.MaxValue;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStacks = new MyStack();

            myStacks.Push(0);
            myStacks.Push(1);
            myStacks.Push(0);
          
            Console.WriteLine(myStacks.Min());

            myStacks.Pop();

            Console.WriteLine(myStacks.Min());

        }



    }
}
