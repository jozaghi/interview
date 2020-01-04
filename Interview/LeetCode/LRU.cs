using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    class Node
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int key, int value, Node next = null, Node prev = null)
        {
            Key = key;
            Value = value;
            Next = next;
            Prev = prev;
        }
    }


    public class LRUCache
    {

        private Dictionary<int, Node> _map;
        private int _capacity;
        private Node _head;
        private Node _tail;


        public LRUCache(int capacity)
        {
            _map = new Dictionary<int, Node>();
            _capacity = capacity;
            _head = null;
            _tail = _head;
        }

        public int Get(int key)
        {
            if (!_map.ContainsKey(key))
                return -1;

            var node = _map[key];
            BringNodeToFront(node);
            return node.Value;
        }

        private void BringNodeToFront(Node node)
        {
            if (node.Prev != null)
            {
                if (node.Next == null) _tail = node.Prev;

                node.Prev.Next = node.Next;
                if (node.Next != null)
                    node.Next.Prev = node.Prev;
                node.Next = _head;
                _head.Prev = node;
                node.Prev = null;
                _head = node;

            }
        }

        public void Put(int key, int value)
        {
            if (_map.ContainsKey(key))
            {
                var node = _map[key];
                BringNodeToFront(node);
                node.Value = value;
                return;
            }
            if (!_map.ContainsKey(key) &&_map.Count + 1 > _capacity)
            {
                var keyToRemove = _tail.Key;
                _tail = _tail.Prev;
                if(_tail!=null)
                    _tail.Next = null;
                _map.Remove(keyToRemove);
            }

            Node newNode =new Node(key, value, _head);
            _map.Add(key, newNode);
            if (_head != null)
                _head.Prev = newNode;
            _head = newNode;
            
            if (_tail == null)
                _tail = newNode;

        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
