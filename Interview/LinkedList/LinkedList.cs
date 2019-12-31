using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LinkedList
{
   public class Node<T>
    {
        public readonly T Value;
        public Node<T> Next { get;  set; }
        public Node(T value)
        {
            Value = value;
        }
        public static Node<T> Empty => null;
    }

    public class LinkedList<T>
    {
        private Node<T> _head { get; set; } = Node<T>.Empty;
        public Result<T> FindNthItemFromTheEnd(int n)
        {
            var notFoundResult = Result.Fail("item not found");
            var pointer = _head;

            if (pointer == null)
                return notFoundResult;

            Result<T> result = null;
            TraverseToNthItemFromEnd(_head, n,ref result);
            return result ?? notFoundResult;
        }

        private int TraverseToNthItemFromEnd(Node<T> pointer,int n,ref Result<T> result)
        {
            if (pointer == null)
                return 0;

            var itemsCountToEnd = 1 + TraverseToNthItemFromEnd(pointer.Next, n, ref result);
            if (itemsCountToEnd == n)
            {
                result = Result<T>.Ok(pointer.Value);
            }
            return itemsCountToEnd;
        }

        public LinkedList<T> Prepend(T value)
        {
            var newNode = new Node<T>(value);
            if (_head != Node<T>.Empty)
                newNode.Next = _head;
            _head = newNode;

            return this;
        }

        public static Result<int> Sum(LinkedList<T> fistList, LinkedList<T> linkedList)
        {
            return Result.Fail("not implemented");
        }
    }
}
