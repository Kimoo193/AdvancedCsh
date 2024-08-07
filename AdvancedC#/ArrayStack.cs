using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public class ArrayStack<T> : IStack<T>
    {
        private T[] stack;
        private int top;

        public ArrayStack(int capacity)
        {
            stack = new T[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            if (top >= stack.Length - 1)
            {
                throw new StackOverflowException("Stack is full.");
            }
                stack[++top] = item;
        }

        public T Pop()
        {
            if (top < 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return stack[top--];
        }
    }
    public class StackOverflowException : Exception
    {
        public StackOverflowException(string message) : base(message) { }
    }

    public class EmptyStackException : Exception
    {
        public EmptyStackException(string message) : base(message) { }
    }


}
