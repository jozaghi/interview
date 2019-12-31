using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.Graph
{
    public class GraphNode<T>
    {
        public T Value { get; set; }
        public List<GraphNode<T>> Children { get; }

        public GraphNode(T value)
        {
            Value = value;
            Children = new List<GraphNode<T>>();
        }

        public GraphNode<T> AddChild(GraphNode<T> node)
        {
            Children.Add(node);
            return this;
        }
    }
}
