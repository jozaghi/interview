using System;
using System.Collections.Generic;
using System.Text;

/*
 Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

The cache is initialized with a positive capacity.

Follow up:
Could you do both operations in O(1) time complexity?

Example:

LRUCache cache = new LRUCache( 2  );

cache.put(1, 1);
cache.put(2, 2);
cache.get(1);       // returns 1
cache.put(3, 3);    // evicts key 2
cache.get(2);       // returns -1 (not found)
cache.put(4, 4);    // evicts key 1
cache.get(1);       // returns -1 (not found)
cache.get(3);       // returns 3
cache.get(4);       // returns 4
*/



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
                if (node.Next == null) 
                    _tail = node.Prev;

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
