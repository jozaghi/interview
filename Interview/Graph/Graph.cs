using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Graph
{
    public class Graph<T>
    {
        private Dictionary<T, GraphNode<T>> _children;

        public Graph()
        {
            _children = new Dictionary<T, GraphNode<T>>();
        }

        public Result AddChild(GraphNode<T> node)
        {
            if (node == null) return Result.Fail("graph node cannot be null");
            if (_children.ContainsKey(node.Value)) return Result.Fail("node with a same value exists");

            _children.Add(node.Value, node);
            return Result.Ok();
        }
    }
}
