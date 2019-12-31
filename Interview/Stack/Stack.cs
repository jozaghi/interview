using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Stack
{
    internal class StackNode<T>
    {
        public T Data { get; set; }
        public StackNode<T> Next { get; set; }
        public StackNode(T data, StackNode<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }
    public class Stack<T>
    {
        private StackNode<T> _top;

        private StackNode<T> _min;

        public Result<T> Min { 
            get
            {
                if (_min == null)
                    return Result.Fail("No minimum exists in the stack");
                return Result<T>.Ok(_min.Data);
            }
        }

        public Stack()
        {
            _top = null;
        }
        public Stack<T> Push(T value)
        {
            var node = new StackNode<T>(value, _top);
            _top = node;

            if (_min == null)
            {
                _min = node;
            }
            else
            {
                _min = Compare(_min.Data,node.Data)>0?node:_min;
            }

            return this;
        }

        public Result<T> Peek()
        {
            if (_top == null)
                return Result.Fail("stack is empty");
            return Result<T>.Ok(_top.Data);
        }

        public bool IsEmpty() => _top == null;

        public Result<T> Pop()
        {
            if (_top == null)
                return Result.Fail("stack is empty");
            var data = _top.Data;
            _top = _top.Next;
            return Result<T>.Ok(data);
        }
        private int Compare(T first, T second)=>Comparer<T>.Default.Compare(first, second);
    }
}
